namespace EvenNum
{
    internal class Program
    {
        static bool EvenNumber(int num)
        {
            return num % 2 == 0;
        }
        static void Main()
        {
            Console.WriteLine(EvenNumber(7));
        }
    }
}