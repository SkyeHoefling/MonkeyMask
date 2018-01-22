using System.Linq;
using System.Text.RegularExpressions;

namespace MonkeyMask.Core
{
    public static class MonkeyEntry
    {
        public static string Mask(string input, string format, int maxLength = 0)
        {
            string output = null;

            if(input == null || input == string.Empty)
            {
                return string.Empty;
            }
            else if (format == null || format == string.Empty)
            {
                return input;
            }
            else if (input.Length > format.Length)
            {
                output = input.Substring(0, format.Length);
            }            
            else
            {
                var digits = Regex.Matches(format, "#").Count;
                if (Regex.IsMatch(input, "^[0-9]+$") && input.Length > digits)
                {
                    input = input.Substring(0, digits);
                }

                input = Regex.Replace(input.Replace("-", string.Empty), "[^0-9]", string.Empty);
                if (string.IsNullOrEmpty(input) || input[input.Length - 1] == '-') return input;

                var length = input.Length;

                var indexOfSeperators = Regex.Matches(format, "-")
                    .Cast<Match>()
                    .Select(x => x.Index)
                    .ToArray();

                for (int i = 0; i < indexOfSeperators.Length; i++)
                {
                    if (indexOfSeperators[i] <= length)
                    {
                        length++;
                    }
                }

                var adjustedFormat = format.Substring(0, length);
                output = string.Format("{0:" + adjustedFormat + "}", double.Parse(input));
            }

            return output;
        }
    }
}
