using System;

namespace ConsoleApp1
{
    public class TheShuffleClass
    {
        static readonly Random random = new Random();

        public static void Shuffle<T>(T[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                int r = random.Next(n - i);
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }
    }
}
