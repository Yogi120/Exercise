using System.Net.Http.Headers;

namespace Divisible2or3
{
    class Program
    {
        static int MulSum(int a, int b)
        {
            return a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0 ? a * b : a + b;
            
        }
        static void Main()
        {
            Console.WriteLine(MulSum(25, 30));
            Console.WriteLine(MulSum(20, 30));
        }
    }
}