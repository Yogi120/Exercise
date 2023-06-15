namespace Celsius_Fahrenheit
{
    internal class Program
    {
        public static double Converter(double celsius)
        {
            double Fahrenheit =  (celsius * 9 / 5) + 32;

            return Fahrenheit;
        }
        static void Main()
        {
            Console.WriteLine(Converter(5));
        }
    }
}