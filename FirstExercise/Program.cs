namespace FirstExercise
{
    using System;
        internal class Program
    {
                        static void Main()
        {
            Random random = new Random();
           Console.WriteLine("Enter the Number of Elemrents in the Array");//запит кількостыі елементів в масиві
           int N= Console.Read();
           int[] A = new int[N];
           for (int i = 0; i < N; i++)
           { A[i] = random.Next(-200,200);
           }
            Console.WriteLine (A[1]);
            Console.WriteLine(A[2]);
            int k=0;
            for (int i = 0; i < N; i++)
            {
                if (A[i]>=-100 && A[i]<=100)
                { 
                    k = k + 1;
               }
            }
           Console.WriteLine($"Number of elements,{k}");
        }
    }
}
