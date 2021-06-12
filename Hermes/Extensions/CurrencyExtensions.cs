using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hermes.Extensions
{
    static class CurrencyExtensions
    {
        private static CultureInfo frFR = new CultureInfo("fr-FR");

        public static string ToEuros(this double v)
        {
            return v.ToString("C", frFR);
        }

        public static string ToEuros(this float v)
        {
            return v.ToString("C", frFR);
        }

        public static string ToEuros(this decimal v)
        {
            return v.ToString("C", frFR);
        }
    }
}
