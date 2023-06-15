namespace AddTwoNum
{
    internal class Program
    {
        static double AddMultiply(double a, double b, double c)
        {
            return (a + b) * c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AddMultiply(2, 3, 7));
        }
    }
}