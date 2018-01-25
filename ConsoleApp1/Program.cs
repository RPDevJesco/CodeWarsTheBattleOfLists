using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        //Challenge: To create a randomized list that does not repeat.

        static void Main(string[] args)
        {
            List<int> main = new List<int>() { 1, 1, 1, 1, 1, 1, 2, 5, 7, 7, 7, 7, 3, 9, 13, 15, 17, 19, 21 };
            List<int> secondary = new List<int>();

            ShuffledResultClass shuff = new ShuffledResultClass();
            shuff.ShuffledResults(main, secondary);

            for (int i = 0; i < secondary.Count; i++)
                Console.WriteLine(secondary[i]);
            Console.ReadLine();
        }
    }
}
