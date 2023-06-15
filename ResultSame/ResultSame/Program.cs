namespace ResultSame
{
    internal class Program
    {
        static bool Boolean(double a, double b)
        {
            return a == b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Boolean(3 * 3, 18 / 3));
            Console.WriteLine(Boolean(3 * 3, 18 / 2));
        }
    }
}