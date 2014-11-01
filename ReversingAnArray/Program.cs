using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingAnArray
{
    class Program
    {
        /// <summary>
        /// The main method. Generates a list of numbers, reverses the 
        /// order, and prints the reversed array.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            Reverse(numbers);
            PrintNumbers(numbers);

            Console.ReadKey();

        }
        /// <summary>
        /// Generates an array of 10 numbers.
        /// </summary>
        /// <returns></returns>
        static int[] GenerateNumbers()
        {
            int[] numbers = new int[10];

            for (int index = 0; index < 10; index++)
            {
                // We add 1 here, because the index starts
                // at 0, but we want to start with 1, we add
                // 1 here.
                numbers[index] = index + 1;
            }

            return numbers;
        }

        /// <summary>
        /// Generates a list of numbers of any size required.
        /// </summary>
        /// <param name="amount">The amount to generate.</param>
        /// <returns></returns>
        static int[] GenerateNumbers(int amount)
        {
            int[] numbers = new int[amount];

            for (int index = 0; index < amount; index++)
            {
                numbers[index] = index + 1;
            }

            return numbers;
        }

        /// <summary>
        /// Prints any array of numbers in order.
        /// </summary>
        /// <param name="numbers"></param>
        static void PrintNumbers(int[] numbers)
        {
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write(numbers[index] + " ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Reverses the contents of an array that is passed in.
        /// </summary>
        /// <param name="numbers"></param>
        static void Reverse(int[] numbers)
        {
            // Initialize one index at the start of the array, and another
            // at the end of the array. The index of the last item in the
            // array is the length of the array - 1.
            int firstIndex = 0;
            int secondIndex = numbers.Length - 1;

            while (firstIndex < secondIndex)
            {
                // To swap two numbers, we need to copy one value out
                // to a safe place so that it doesn't get overwritten.
                int temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temp;

                // Move on to the next pair.
                firstIndex++;
                secondIndex--;
            }
        }
    }
}
