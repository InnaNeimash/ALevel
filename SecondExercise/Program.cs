namespace SecondExercise
{
    using System;
    using System.Reflection.Metadata.Ecma335;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    internal class Program
    { //Metod Change elements
        static void Swap(ref int e1, ref int e2 )
        {
            var t = e1;
            e1 = e2;
            e2 = t;
        }
        //bubble sort
        static int[] BubbleSort(int[] B)
        {
           for ( var i = 0; i < 20; i++ ) 
            {
                for ( var j = 0; j < 19; j++ )
                { if (B[j] <= B[j + 1])
                    {  Swap(ref B[j + 1], ref B[j]); }
                }
            }
            return B;
        }
        static void Main()
        {
            Random random = new Random();
            int[] A = new int[20];
            int[] B = new int[20];
            Console.WriteLine("First array");
            for (int i = 0; i < 20; i++)
            {
                A[i] = random.Next(10, 1000);
                Console.WriteLine($"ArrayA{i} {A[i]}");
            }
            int n = 0;
            for (int i = 0; i < 20; i++)
            {
                if (A[i] <= 888)
                {
                    B[n] = A[i];
                }
                else B[n] = random.Next(10, 1000);
                n++;
            }
            Console.WriteLine("Second array");
            for (int i = 0; i < 20; i++)
            {
               Console.WriteLine($"ArrayB{i} {B[i]}");
            }
            Console.WriteLine("Sorted array: {0}", string.Join(", ", BubbleSort(B)));

            Console.ReadLine();
        }
          
        
    }

}