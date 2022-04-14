using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 20, 30, 40, 50, 60 };

            int output = 0;
            for (int i = 0; i < array.Length; i++)
            {
                output += array[i];
                Console.WriteLine(output);
            }

        }
    }
}
