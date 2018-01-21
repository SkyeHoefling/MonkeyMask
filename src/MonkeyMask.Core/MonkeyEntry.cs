﻿using System.Linq;
using System.Text.RegularExpressions;

namespace MonkeyMask.Core
{
    public static class MonkeyEntry
    {
        public static string Mask(string input, string format, int maxLength = 0)
        {
            string output = null;

            if (maxLength > 0 && input.Length < maxLength)
            {
                output = input;
            }
            else if (input.Length > format.Length)
            {
                output = input.Substring(0, format.Length);
            }
            else
            {
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