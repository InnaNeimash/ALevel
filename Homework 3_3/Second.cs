namespace Homework_3_1
{
    public class Second
    {
        public delegate bool ResultDelegate(int num);

        public static ResultDelegate Calc(First.Showdelegate showdelegate, int a, int b)
        {
            int result = First.Multiply(a, b);

            bool Result(int num)
            {
                int devided = result % num;
                return devided == 0;
            }
            return Result;
        }
        public static bool Result(int num)
        {
            return true;
        }
    }

}
