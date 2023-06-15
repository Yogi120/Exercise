namespace Neighbour
{
    internal class Program
    {
        public static bool NeighbourLet(string word)
        {
            return word[0] == word[1] - 1 || word[0] == word[1] + 1 || word[2] == word[1] - 1 || word[2] == word[1] + 1;
        }

        public static void Main()
        {
            Console.WriteLine(NeighbourLet("DCA"));
            Console.WriteLine(NeighbourLet("PRT"));
        }
    }
}