namespace MonkeyMask.Core.Extensions
{
    public static class StringExtensions
    {
        public static string EntryMask(this string input, string format, int maxLength = 0)
        {
            return MonkeyEntry.Mask(input, format, maxLength);
        }
    }
}
