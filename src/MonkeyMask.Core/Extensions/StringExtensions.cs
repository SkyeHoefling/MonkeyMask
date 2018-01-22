namespace MonkeyMask.Core.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Mask the input based on the provided format.
        /// </summary>
        /// <remarks>
        /// ONLY SUPPORTS NUMERIC INPUTS AND FORMATS
        /// Intended to be used with keyboard entry.
        /// </remarks>
        /// <example>
        /// // partial mask
        /// var input = "123-4";
        /// var format = "###-####";
        /// MonkeyEntry.Mask(input, format);
        ///
        /// // full mask
        /// var input = "123-4567";
        /// var format = "###-####";
        /// MonkeyEntry.Mask(input, format);
        ///
        /// // full mask and limit a max length
        /// var input = "123-4567";
        /// var format = "###-####";
        /// MonkeyEntry.Mask(input, format, 7);
        /// </example>
        /// <param name="input">Unmasked string</param>
        /// <param name="format">Formatting pattern</param>
        /// <param name="maxLength">Max length of output</param>
        /// <returns>Masked input</returns>
        public static string EntryMask(this string input, string format, int maxLength = 0)
        {
            return MonkeyEntry.Mask(input, format, maxLength);
        }
    }
}
