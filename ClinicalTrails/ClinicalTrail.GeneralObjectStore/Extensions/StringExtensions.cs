using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClinicalTrail.GeneralObjectStore.Extensions
{
    public static class StringExtensions
    {
        public static string Left(this string s, int count)
        {
            return s.Substring(0, count);
        }

        public static string Right(this string s, int count)
        {
            return s.Substring(s.Length - count, count);
        }

        public static string Mid(this string s, int index, int count)
        {
            return s.Substring(index, count);
        }

        /// <summary>
        /// This string extension will try to parse the given string to an int. Would the parsing fail, then the default value will be used
        /// </summary>
        /// <param name="str">input string</param>
        /// <param name="defaultValue">default value if the parsing would fail</param>
        /// <returns>the parsed integer</returns>
        public static int TryParseToInt(this string str, int defaultValue)
        {
            int tryInt;
            return int.TryParse(str, out tryInt) ? tryInt : defaultValue;
        }

        public static bool IsInteger(this string s)
        {
            Regex regularExpression = new Regex("^-[0-9]+$|^[0-9]+$");
            return regularExpression.Match(s).Success;
        }

        public static DateTime? TryParseToDateTime(this string s, string dateformat, DateTime? defaultValue)
        {
            DateTime tryDt;

            if (string.IsNullOrEmpty(s))
                return defaultValue;

            DateTime? result = DateTime.TryParseExact(s, dateformat, CultureInfo.InvariantCulture, DateTimeStyles.None, out tryDt) ? tryDt : defaultValue;
            return result;
        }

        public static decimal TryParseToDecimal(this string str, decimal defaultValue)
        {
            if (string.IsNullOrEmpty(str))
                return defaultValue;

            decimal trydecimal;
            return decimal.TryParse(str, out trydecimal) ? trydecimal : defaultValue;
        }

        public static decimal? TryParseToDecimal(this string str, decimal? defaultValue)
        {
            // values from SAP are stored with decimal point
            str = str.Replace('.', ',');

            if (string.IsNullOrEmpty(str))
                return defaultValue;

            decimal trydecimal;
            return decimal.TryParse(str, out trydecimal) ? trydecimal : defaultValue;
        }

    }
}
