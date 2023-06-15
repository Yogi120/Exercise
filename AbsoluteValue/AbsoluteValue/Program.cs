namespace AbsoluteValue
{
    class Program
    {
        static double Absolute(double a)
        {
            if (a >= 0)
            {
                a = a; 
            }
            else
            {
                a = a * -1;
            }

            return a;
        }
        static void Main()
        {
            Console.WriteLine(Absolute(10));
        }
    }
}