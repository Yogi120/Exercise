namespace SwapNumber
{
    class Swaping
    {
        static string SwapNumber(double a, double b)
        {
            string Before = $"Before: a = {a}, b = {b}; ";
            double temp;

            temp = b;
            b = a;
            a = temp;

            string After = $"After: a = {a}, b = {b}; ";

            return Before + After;


        }
        static void Main()
        {
            Console.WriteLine(SwapNumber(10, 45));
        }
    }
}