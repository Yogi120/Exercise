namespace PosNegZer
{
    internal class Program
    {
        static string PositiveNegativeZero(double num)
        {
            if (num > 0.0)
            {
                return "Positive";
            }
            else if (num < 0.0)
            {
                return "Negative";
            }

            return "Zero";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PositiveNegativeZero(9.18));
            Console.WriteLine(PositiveNegativeZero(0));
            Console.WriteLine(PositiveNegativeZero(-56.45));
        }
    }
}