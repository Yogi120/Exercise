namespace Cube
{
    class CubeOfNumber
    {
        public static double TheCubeOf(double num)
        {
            return num * num * num;
        }

        public static void Main()
        {
            Console.WriteLine(TheCubeOf(5));
        }
    }
}