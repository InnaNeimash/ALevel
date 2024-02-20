using Homework_3_1;
using System;

namespace Homework_3_3
{
    internal class Program
    {
        static void ShowResult(bool value)
        {
            Console.WriteLine("Result: " + value);
        }
        static void Main(string[] args)
        {
            First.Showdelegate showdelegate = ShowResult;
            Second.ResultDelegate resultDelegate = Second.Calc(showdelegate, 10, 40);
            bool result = resultDelegate(10);
            Console.WriteLine("Final result: " + result);
        }
    }
} 
