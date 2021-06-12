using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Extensions
{
    static class DateTimeExtensions
    {
        private static CultureInfo frFR = new CultureInfo("fr-FR");

        public static string ToFrenchLongDateString(this DateTime dateTime)
        {
            return dateTime.ToString("D", frFR);
        }
    }
}
