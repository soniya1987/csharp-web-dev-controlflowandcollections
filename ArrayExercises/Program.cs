using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
            int[] array = { 1, 1, 2, 3, 5, 8 };
            Console.WriteLine("Array values are :");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Odd numbers in the array are the following :");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    Console.WriteLine(array[i]);
                }
                continue;
            }
        }
    }
}
