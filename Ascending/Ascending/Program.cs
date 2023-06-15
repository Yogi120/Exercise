namespace Ascending
{
    internal class Program
    {
        static bool AscendingNum(int[] arr)
        {
            return arr[0] <= arr[1] && arr[1] <= arr[2];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AscendingNum(new int[] {2, 6, 4 }));
            Console.WriteLine(AscendingNum(new int[] {2, 4, 8 }));

        }
    }
}