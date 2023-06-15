namespace Uppercase
{
    internal class Program
    {
        static bool UppercaseString(string str)
        {
            return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65 && str[0] <= 90 && str[1] <= 90 && str[2] <= 90);
        }
        static void Main()
        {
            Console.WriteLine(UppercaseString("Xyz"));
            Console.WriteLine(UppercaseString("XYZ"));
        }
    }
}