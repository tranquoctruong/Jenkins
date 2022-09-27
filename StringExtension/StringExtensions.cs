namespace StringExtension
{
    public static class StringExtensions
    {
        public static int ToNum(this string value)
        {
            return int.Parse(value);
        }
    }
}