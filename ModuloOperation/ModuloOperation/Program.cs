namespace ModuloOperation
{
    internal class Program
    {
        public static int ModuloOperations(int a, int b, int c)
        {
            return a % b % c;
        }

        public static void Main()
        {
            Console.WriteLine(ModuloOperations(8, 5, 2));

        }
    }
}