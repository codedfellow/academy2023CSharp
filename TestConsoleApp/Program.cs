namespace TestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal amountDecimal = 5000000m;
            IFormatProvider usFormatProvider =
                new System.Globalization.CultureInfo("en-US");

            string decimalAmount = amountDecimal.ToString("#,##0.00", usFormatProvider);
            Console.WriteLine($"Decimal Amount {decimalAmount}");
        }
    }
}