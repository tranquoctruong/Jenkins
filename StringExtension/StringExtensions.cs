namespace StringExtension
{
    public static class StringExtensions
    {
        public static int ToNumber(this string value)
        {
            int number = 0;
            int.TryParse(value, out number);
            return number;
        }
    }
}