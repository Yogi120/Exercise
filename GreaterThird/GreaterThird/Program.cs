namespace GreaterThird
{
    internal class Program
    {
        static bool GreaterNum(int[] arr)
        {
            return arr[0] + arr[1] > arr[2] || arr[0] * arr[1] > arr[2];
        }
        static void Main()
        {
            Console.WriteLine(GreaterNum(new int[] { 2, 5, 3 }));
            Console.WriteLine(GreaterNum(new int[] { 10, 5, 60 }));

        }
    }
}