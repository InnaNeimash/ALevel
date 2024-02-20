namespace Homework_3_4
{
    internal class Program
    {
        public static event EventHandler<int> Calculate;
        public static void Main()
        {
            Calculate += (sender, e) => Console.WriteLine("Sum of two numbers: " +e);
            Calculate += CalculationWrapper;
            Calculate?.Invoke(null, Sum(10,30));
        }
        static void CalculationWrapper(object sender, int sum) 
        {
            try 
            {
                DoTryCatchOperation(() => Console.WriteLine("Total sum after calculation: " + sum));
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Error occured: " + ex.Message);
            }
        }
        static void DoTryCatchOperation(Action operation)
        {
            try
            {
                operation();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured in the operation: " + ex.Message);
            }
        }
        static int Sum(int a, int b) 
        {
            return a + b;
        }
    }
}
