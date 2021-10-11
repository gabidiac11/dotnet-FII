using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Helpers.Parser.ParserExtensions
{
    public static class ParserExtensions
    {
        public static decimal ToDecimal(this string value)
        {
            var numericValue = ExtractNumberFrom(value);

            return numericValue != null ? decimal.Parse(numericValue, NumberStyles.Any, new CultureInfo("en-US")) : 0;
        }

        public static decimal? ToDecimalOrDefault(this string value)
        {
            var numericValue = ExtractNumberFrom(value);

            return numericValue != null ? decimal.Parse(numericValue, NumberStyles.Any, new CultureInfo("en-US")) : (decimal?) null;
        }

        private static string ExtractNumberFrom(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            var numericMatch = Regex.Match(value, @"([\d\.]*)").Groups.Values.FirstOrDefault();
            if (numericMatch == null || string.IsNullOrEmpty(numericMatch.Value))
            {
                return null;
            }

            return numericMatch.Value;
        }

        public static object ParseToEnum(this string value, Type type)
        {
            object result;
            var itWorked = Enum.TryParse(type, value, true, out result);

            return itWorked ? result : null;
        }
    }
}
