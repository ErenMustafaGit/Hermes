using Hermes.DataModel;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes
{
    public static class PdfExporter
    {
        // To force French strings (my Windows isn't set up in French, you see)
        private static CultureInfo frFR = new CultureInfo("fr-FR");

        private static PdfFont MakeFont(AppFont font)
        {
            return PdfFontFactory.CreateFont(FontManager.GetFontData(font), PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);
        }

        private class PdfSummary : IDisposable
        {
            readonly PdfFont m_Light, m_Regular, m_Medium, m_Bold;

            readonly PartyEvent m_PartyEvent;
            readonly Participant m_Guest;

            readonly Document m_Document;

            public PdfSummary(FileStream stream, PartyEvent e, Participant p)
            {
                m_PartyEvent = e;
                m_Guest = p;

                m_Light = MakeFont(AppFont.HelveticaNeue_Light);
                m_Regular = MakeFont(AppFont.HelveticaNeue);
                m_Medium = MakeFont(AppFont.HelveticaNeue_Medium);
                m_Bold = MakeFont(AppFont.HelveticaNeue_Bold);

                m_Document = new Document(new PdfDocument(new PdfWriter(stream)));
            }

            public void Dispose()
            {
                ((IDisposable)m_Document).Dispose();
            }

            Table CreateTable((string, float)[] headers)
            {
                float[] headerProportions = headers.Select(h => h.Item2).ToArray();
                Table table = new Table(UnitValue.CreatePercentArray(headerProportions));
                table.SetWidth(UnitValue.CreatePercentValue(100));

                foreach ((string header, float _) in headers)
                {
                    var h = new Paragraph(header);
                    h.SetFont(m_Medium);
                    h.SetTextAlignment(TextAlignment.CENTER);
                    table.AddHeaderCell(h);
                }

                return table;
            }

            Cell CreateCell(string text, TextAlignment alignment = TextAlignment.LEFT)
            {
                Paragraph paragraph = new Paragraph(text);
                paragraph.SetTextAlignment(alignment);
                paragraph.SetFont(m_Regular);
                return new Cell().Add(paragraph);
            }

            void RenderLineSeparator()
            {
                m_Document.Add(new LineSeparator(new SolidLine()).SetMargins(10, 0, 15, 0));
            }

            void RenderHeader()
            {
                Paragraph paragraph = new Paragraph("Hermès");
                paragraph.SetTextAlignment(TextAlignment.RIGHT);
                paragraph.SetFontSize(24);
                paragraph.SetFont(m_Bold);
                paragraph.SetFontColor(new DeviceRgb(38, 147, 248));
                paragraph.SetMargins(0, 10, 25, 0);

                m_Document.Add(paragraph);
            }

            void RenderEventInformation()
            {
                Paragraph paragraph = new Paragraph();
                paragraph.SetFont(m_Light);
                {
                    Text text = new Text("Récapitulatif de l'évènement « ");
                    text.SetFont(m_Regular);
                    paragraph.Add(text);

                    paragraph.Add(new Text(m_PartyEvent.Name).SetFont(m_Bold));

                    paragraph.Add(new Text(" » pour ").SetFont(m_Regular));

                    text = new Text(m_Guest.FirstName + " " + m_Guest.LastName + "\n\n");
                    text.SetFont(m_Bold);
                    paragraph.Add(text);
                }
                {
                    string shares = String.Format("{0} part{1}\n",
                        m_Guest.NbParts, m_Guest.NbParts == 1 ? "" : "s");
                    paragraph.Add("Invité comptabilisé pour ");
                    paragraph.Add(new Text(shares).SetFont(m_Medium));
                }
                {
                    paragraph.Add("Évènement du ");
                    paragraph.Add(new Text(m_PartyEvent.StartDate.ToString("D", frFR)).SetFont(m_Medium));

                    if (m_PartyEvent.StartDate != m_PartyEvent.EndDate)
                    {
                        paragraph.Add(" au ");
                        paragraph.Add(new Text(m_PartyEvent.EndDate.ToString("D", frFR)).SetFont(m_Medium));;
                    }

                    paragraph.Add("\n");
                }
                {
                    paragraph.Add("Description : « ");
                    paragraph.Add(new Text(m_PartyEvent.Description).SetItalic());
                    paragraph.Add(" »\n");
                }

                m_Document.Add(paragraph);
            }

            void RenderSpendings(List<UserSpendingRecord> spendings)
            {
                Paragraph paragraph = new Paragraph();
                paragraph.SetFont(m_Light);
                {
                    string title = String.Format("Dépenses effectuées :\n");
                    if (spendings.Count == 0)
                        title = "Aucune dépense effectuée.\n";

                    var text = new Text(title);
                    text.SetFont(m_Medium);
                    paragraph.Add(text);
                }
                m_Document.Add(paragraph);

                // Stop here if we don't have anything to show
                if (spendings.Count == 0)
                    return;

                var table = this.CreateTable(new[] { ("Date", 3f), ("Dépense", 5f), ("Montant", 2f) });
                foreach (UserSpendingRecord record in spendings)
                {
                    table.AddCell(this.CreateCell(record.Date.ToString("D", frFR)));
                    table.AddCell(this.CreateCell(record.Description));
                    table.AddCell(this.CreateCell(record.Amount.ToString("C", frFR), TextAlignment.RIGHT));
                }

                m_Document.Add(table);
            }

            void RenderParticipation(List<UserParticipationRecord> participation)
            {
                Paragraph paragraph = new Paragraph();
                paragraph.SetFont(m_Light);
                {
                    string title = String.Format("Bénéficie des dépenses :\n");
                    if (participation.Count == 0)
                        title = "Ne bénéficie d'aucune dépense.\n";

                    var text = new Text(title);
                    text.SetFont(m_Medium);
                    paragraph.Add(text);
                }
                m_Document.Add(paragraph);

                // Stop here if we don't have anything to show
                if (participation.Count == 0)
                    return;

                var table = this.CreateTable(new[] { ("Date", 3f), ("Dépense", 5f), ("Montant", 2f) });
                foreach (UserParticipationRecord record in participation)
                {
                    table.AddCell(this.CreateCell(record.Expense.Date.ToString("D", frFR)));
                    table.AddCell(this.CreateCell(record.Expense.Description));
                    table.AddCell(this.CreateCell(record.Amount.ToString("C", frFR), TextAlignment.RIGHT));
                }

                m_Document.Add(table);
            }

            void RenderDuesToGive(List<PartyEvent.Due> duesToGive)
            {
                Paragraph paragraph = new Paragraph();
                paragraph.SetFont(m_Light);
                {
                    string title = String.Format("Dûs à payer :\n");
                    if (duesToGive.Count == 0)
                        title = "Aucun dû à payer.\n";

                    var text = new Text(title);
                    text.SetFont(m_Medium);
                    paragraph.Add(text);
                }
                m_Document.Add(paragraph);

                // Stop here if we don't have anything to show
                if (duesToGive.Count == 0)
                    return;

                var table = this.CreateTable(new[] { ("Destinataire", 5f), ("Montant", 2f) });
                foreach (PartyEvent.Due due in duesToGive)
                {
                    table.AddCell(this.CreateCell(due.To.FirstName + " " + due.To.LastName));
                    table.AddCell(this.CreateCell(due.Amount.ToString("C", frFR), TextAlignment.RIGHT));
                }

                m_Document.Add(table);
            }

            void RenderDuesToReceive(List<PartyEvent.Due> duesToReceive)
            {
                Paragraph paragraph = new Paragraph();
                paragraph.SetFont(m_Light);
                {
                    string title = String.Format("Dûs à recevoir :\n");
                    if (duesToReceive.Count == 0)
                        title = "Aucun dû à recevoir.\n";

                    var text = new Text(title);
                    text.SetFont(m_Medium);
                    paragraph.Add(text);
                }
                m_Document.Add(paragraph);

                // Stop here if we don't have anything to show
                if (duesToReceive.Count == 0)
                    return;


                var table = this.CreateTable(new[] { ("Émetteur", 5f), ("Montant", 2f) });
                foreach (PartyEvent.Due due in duesToReceive)
                {
                    table.AddCell(this.CreateCell(due.From.FirstName + " " + due.From.LastName));
                    table.AddCell(this.CreateCell(due.Amount.ToString("C", frFR), TextAlignment.RIGHT));
                }

                m_Document.Add(table);
            }

            public void Render(List<UserSpendingRecord> spendings, List<UserParticipationRecord> participation,
                List<PartyEvent.Due> duesToGive, List<PartyEvent.Due> duesToReceive)
            {
                this.RenderHeader();

                // Event information
                this.RenderEventInformation();
                this.RenderLineSeparator();

                // Spending information
                this.RenderSpendings(spendings);
                this.RenderLineSeparator();

                // Participation information
                this.RenderParticipation(participation);
                this.RenderLineSeparator();

                // Dues (sending)
                this.RenderDuesToGive(duesToGive);
                this.RenderLineSeparator();

                // Dues (receiving)
                this.RenderDuesToReceive(duesToReceive);
            }
        }

        private static string NormalizeFilename(string filename)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
                filename = filename.Replace(c, '_');

            return filename;
        }

        public static void ExportEventSummaries(string path, PartyEvent e)
        {
            List<Expense> expenses = e.GetExpenses();
            List<Participant> guests = e.GetGuests();
            List<PartyEvent.Due> dues = e.CalculateDues();

            string eventNormalizedName = NormalizeFilename(e.Name);

            foreach (Participant p in guests)
            {
                var duesToGive = dues.FindAll(d => d.FromId == p.CodeParticipant);
                var duesToReceive = dues.FindAll(d => d.ToId == p.CodeParticipant);

                string filename = eventNormalizedName + " - " + NormalizeFilename(p.LastName) + ".pdf";
                string filepath = Path.Combine(path, filename);

                FileStream stream = new FileStream(filepath, FileMode.Create, FileAccess.Write);

                List<UserSpendingRecord> spendings = Database.QuerySpendings(e, p);
                List<UserParticipationRecord> participation = Database.QueryParticipation(e, p);

                using (PdfSummary summary = new PdfSummary(stream, e, p))
                    summary.Render(spendings, participation, duesToGive, duesToReceive);
            }
        }
    }
}
