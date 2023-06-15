namespace LeapYear
{
    internal class Program
    {
        class IfYearIsLeapYear
        {
            static bool LeapYear(int year)
            {
                return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
            }

            static void Main()
            {
                Console.WriteLine(LeapYear(2020));
                Console.WriteLine(LeapYear(2025));
               
            }
        }
    }
}