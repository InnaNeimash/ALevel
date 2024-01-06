namespace Homework_1_4
{
  using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Enter the Number of Elemrents in the Array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] evenArray = new int[n];
            int[] oddArray = new int[n];
            char[] date = { 'A', 'b', 'c', 'D', 'E', 'f', 'g', 'H', 'I', 'J', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] changeEvenNumber = new char[n];
            char[] changeOddNumber = new char[n];
            Console.WriteLine("First array");
            for (int i = 0; i < n; i++)
            {
                firstArray[i] = random.Next(1, 26);
                Console.Write(firstArray[i] + " ");
            }

            int j = 0;
            int k = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] % 2 == 0)
                {
                    evenArray[j] = firstArray[i];
                    j++;
                }
                else
                {
                    oddArray[k] = firstArray[i];
                    k++;
                }
            }

            Console.WriteLine("\n Even Array");
            for (int i = 0; i < j; i++)
            {
                Console.Write(evenArray[i] + " ");
            }

            Console.WriteLine("\n Odd Array");
            for (int i = 0; i < k; i++)
            {
                Console.Write(oddArray[i] + " ");
            }

            int m = 0;
            for (int i = 0; i < j; i++)
            {
                changeEvenNumber[m] = date[evenArray[i]];
                m++;
            }

            for (int i = 0; i < k; i++)
            {
                changeOddNumber[m] = date[oddArray[i]];
                m++;
             }

            Console.WriteLine("\n Even changed Array");
            for (int i = 0; i < n; i++)
            {
                Console.Write(changeEvenNumber[i] + " ");
            }

            Console.WriteLine("\n Odd changed Array");
            for (int i = 0; i < n; i++)
            {
                Console.Write(changeOddNumber[i] + " ");
            }

            int l = 0;
            int f = 0;
            for (int i = 0; i < changeEvenNumber.Length; i++)
            {
                if (char.IsUpper(changeEvenNumber[i]))
                {
                    l = l + 1;
                }

                if (char.IsUpper(changeOddNumber[i]))
                {
                    f = f + 1;
                }
            }

            Console.WriteLine($"\n Count Uppercase in changed Array even Number {l} \n Count Uppercase in changed Array odd Number {f}");
            if (l > f)
            {
            Console.WriteLine("The Array with even numbers contains more uppercase letters");
            }
            else
            {
            Console.WriteLine("The Array with odd numbers contains more uppercase letters");
            }
        }
    }
}
