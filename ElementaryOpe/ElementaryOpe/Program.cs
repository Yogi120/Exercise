using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ElementaryOpe
{
    internal class Program
    {
        public static string Arithmetic(double a, double b)
        {
            double Add = a + b;
            double Sub = a - b;
            double Mult = a * b;
            double division;

            if (b != 0)
            {
                division = a / b;
            }

            else
            {
                division = 0;
            }

            return string.Format($"a + b = {Add}, a - b = {Sub}, a * b = {Mult}, a / b = {division}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Arithmetic(3, 8));
        }
    }
}