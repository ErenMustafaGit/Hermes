using Hermes.DataModel;
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
        private static PdfFont MakeFont(AppFont font)
        {
           return PdfFontFactory.CreateFont(FontManager.GetFontData(font), PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);
        }

        private static string NormalizeFilename(string filename)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
                filename = filename.Replace(c, '_');

            return filename;
        }

        private static void RenderHeader(Document document)
        {
            Paragraph paragraph = new Paragraph("Hermès");
            paragraph.SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT);
            paragraph.SetFontSize(18);
            paragraph.SetFont(MakeFont(AppFont.HelveticaNeue_Bold));
            document.Add(paragraph);
        }

        private static void RenderLineSeparator(Document document)
        {
            document.Add(new LineSeparator(new SolidLine()).SetMargins(10, 0, 15, 0));
        }

        public static void ExportEventSummaries(string path, PartyEvent e)
        {
            // To force French strings (my Windows isn't set up in French, you see)
            CultureInfo frFR = new CultureInfo("fr-FR");

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
                PdfDocument pdfDocument = new PdfDocument(new PdfWriter(stream));

                List<UserSpendingRecord> spendings = Database.QuerySpendings(e, p);
                List<UserParticipationRecord> participation = Database.QueryParticipation(e, p);

                using (Document document = new Document(pdfDocument))
                {
                    RenderHeader(document);


                    // Event information
                    Paragraph paragraph = new Paragraph();
                    paragraph.SetFont(MakeFont(AppFont.HelveticaNeue_Light));
                    {
                        string title = String.Format("Récapitulatif de l'évènement « {0} » pour {1} {2}\n",
                            e.Name, p.FirstName, p.LastName, p.NbParts, p.NbParts == 1 ? "" : "s");
                        var text = new Text(title);
                        text.SetFont(MakeFont(AppFont.HelveticaNeue_Medium));
                        paragraph.Add(text);
                    }
                    {
                        string shares = String.Format("Invité comptabilisé pour {0} part{1}\n",
                            p.NbParts, p.NbParts == 1 ? "" : "s");
                        paragraph.Add(shares) ;
                    }
                    {
                        string range = "Évènement du " + e.StartDate.ToString("D", frFR);
                        if (e.StartDate != e.EndDate)
                            range += " au " + e.EndDate.ToString("D", frFR);
                        paragraph.Add(range + "\n");
                    }
                    {
                        paragraph.Add(new Text("Description : « "));
                        var text = new Text(e.Description);
                        text.SetItalic();
                        paragraph.Add(text);
                        paragraph.Add(new Text(" »\n"));
                    }
                    document.Add(paragraph);


                    RenderLineSeparator(document);


                    // Spending information
                    paragraph = new Paragraph();
                    paragraph.SetFont(MakeFont(AppFont.HelveticaNeue_Light));
                    {
                        string title = String.Format("Dépenses effectuées :\n");
                        if (spendings.Count == 0)
                            title = "Aucune dépense effectuée.\n";

                        var text = new Text(title);
                        text.SetFont(MakeFont(AppFont.HelveticaNeue_Medium));
                        paragraph.Add(text);
                    }
                    document.Add(paragraph);
                    if (spendings.Count != 0)
                    {
                        var table = new Table(UnitValue.CreatePercentArray(new float[] { 3, 5, 2 }));

                        string[] headers = { "Date", "Dépense", "Montant" };
                        foreach (string header in headers)
                        {
                            var h = new Paragraph(header);
                            h.SetFont(MakeFont(AppFont.HelveticaNeue_Medium));
                            h.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                            table.AddHeaderCell(h);
                        }

                        foreach (UserSpendingRecord record in spendings)
                        {
                            table.AddCell(record.Date.ToString("D", frFR));
                            table.AddCell(record.Description);
                            table.AddCell(record.Amount.ToString("C", frFR));
                        }

                        document.Add(table);
                    }


                    RenderLineSeparator(document);


                    // Participation information
                    paragraph = new Paragraph();
                    paragraph.SetFont(MakeFont(AppFont.HelveticaNeue_Light));
                    {
                        string title = String.Format("Dépenses avec participation :\n");
                        if (participation.Count == 0)
                            title = "Aucune participation à une dépense.\n";

                        var text = new Text(title);
                        text.SetFont(MakeFont(AppFont.HelveticaNeue_Medium));
                        paragraph.Add(text);
                    }
                    document.Add(paragraph);
                    if (participation.Count != 0)
                    {
                        var table = new Table(UnitValue.CreatePercentArray(new float[] { 3, 5, 2 }));

                        string[] headers = { "Date", "Dépense", "Montant" };
                        foreach (string header in headers)
                        {
                            var h = new Paragraph(header);
                            h.SetFont(MakeFont(AppFont.HelveticaNeue_Medium));
                            h.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                            table.AddHeaderCell(h);
                        }

                        foreach (UserParticipationRecord record in participation)
                        {
                            table.AddCell(record.Expense.Date.ToString("D", frFR));
                            table.AddCell(record.Expense.Description);
                            table.AddCell(record.Amount.ToString("C", frFR));
                        }

                        document.Add(table);
                    }


                    RenderLineSeparator(document);


                    // Dues (sending)
                    paragraph = new Paragraph();
                    paragraph.SetFont(MakeFont(AppFont.HelveticaNeue_Light));
                    {
                        string title = String.Format("Dûs à payer :\n");
                        if (duesToGive.Count == 0)
                            title = "Aucun dû à payer.\n";

                        var text = new Text(title);
                        text.SetFont(MakeFont(AppFont.HelveticaNeue_Medium));
                        paragraph.Add(text);
                    }
                    document.Add(paragraph);
                    if (duesToGive.Count != 0)
                    {
                        var table = new Table(UnitValue.CreatePercentArray(new float[] { 5, 2 }));

                        string[] headers = { "Destinataire", "Montant" };
                        foreach (string header in headers)
                        {
                            var h = new Paragraph(header);
                            h.SetFont(MakeFont(AppFont.HelveticaNeue_Medium));
                            h.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                            table.AddHeaderCell(h);
                        }

                        foreach (PartyEvent.Due due in duesToGive)
                        {
                            table.AddCell(due.To.FirstName + " " + due.To.LastName);
                            table.AddCell(due.Amount.ToString("C", frFR));
                        }

                        document.Add(table);
                    }


                    RenderLineSeparator(document);


                    // Dues (receiving)
                    paragraph = new Paragraph();
                    paragraph.SetFont(MakeFont(AppFont.HelveticaNeue_Light));
                    {
                        string title = String.Format("Dûs à recevoir :\n");
                        if (duesToReceive.Count == 0)
                            title = "Aucun dû à recevoir.\n";

                        var text = new Text(title);
                        text.SetFont(MakeFont(AppFont.HelveticaNeue_Medium));
                        paragraph.Add(text);
                    }
                    document.Add(paragraph);
                    if (duesToReceive.Count != 0)
                    {
                        var table = new Table(UnitValue.CreatePercentArray(new float[] { 5, 2 }));

                        string[] headers = { "Émetteur", "Montant" };
                        foreach (string header in headers)
                        {
                            var h = new Paragraph(header);
                            h.SetFont(MakeFont(AppFont.HelveticaNeue_Medium));
                            h.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                            table.AddHeaderCell(h);
                        }

                        foreach (PartyEvent.Due due in duesToReceive)
                        {
                            table.AddCell(due.From.FirstName + " " + due.From.LastName);
                            table.AddCell(due.Amount.ToString("C", frFR));
                        }

                        document.Add(table);
                    }
                }
            }
        }
    }
}
