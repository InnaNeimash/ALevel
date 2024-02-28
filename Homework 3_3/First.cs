namespace Homework_3_1
{
    public class First
    {
        public delegate void Showdelegate(bool value);
        public static void Show(bool value)
        {
            Console.WriteLine($"Method value  {value}");
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
