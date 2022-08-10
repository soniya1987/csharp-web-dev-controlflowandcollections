using System;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Sum of Even Numbers is : " + SumOfEvenNumbers(array));

            Console.WriteLine("Input user sentence : ");
            string userSentence = Console.ReadLine();
            Print5LetterWord(userSentence);
        }

        static int SumOfEvenNumbers(int[] list)
        {
            int sum = 0;
            foreach (int item in list)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }

        static void Print5LetterWord(string sentence)
        {
            string[] words = sentence.Split(" ");
            foreach (string item in words)
            {
                if (item.Length == 5)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
