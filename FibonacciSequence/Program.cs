using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of Fibonacci Numbers you want generated after the first digit (1) and press Enter:");
            Console.WriteLine("Examples:");
            Console.WriteLine("2 results in 1, 1, 2");
            Console.WriteLine("3 results in 1, 1, 2, 3");
            Console.WriteLine("4 results in 1, 1, 2, 3, 5");
            Console.WriteLine("5 results in 1, 1, 2, 3, 5, 8");
            Console.WriteLine("6 results in 1, 1, 2, 3, 5, 8, 13");
            Console.WriteLine("7 results in 1, 1, 2, 3, 5, 8, 13, 21");

            while (true)
            {

                
                var input = Console.ReadLine();


                var convertedToInt = Int32.TryParse(input, out int result);

                while (!convertedToInt)
                {

                    Console.WriteLine("Invalid Input. Enter the number of Fibonacci Numbers you want generated and press Enter:");

                    input = Console.ReadLine();
                }

                var value = GenerateRecursively(result + 1);

                Console.WriteLine(String.Format("Value at that index = {0} \n", value));

                var sum = GenerateFibonacciSequence(result);

                Console.WriteLine(String.Format("Fibonacci Sequence is: \n"));
                
                foreach (int number in sum)
                {
                    Console.Write(number + "  ");
                }

                Console.WriteLine("\n");

                Console.WriteLine(String.Format("Cool huh? Enter another number to try again:"));
            }

        }

        /// <summary>
        /// Genenerates the Fibonacci Sequence up to the position provided 
        /// </summary>
        /// <param name="number">Position in the Fibonacci Sequence. The first digit in the sequence is 1 and correlates to position 0.</param>
        /// <returns></returns>
        public static int[] GenerateFibonacciSequence(int number)
        {
            int index = 2;

            int[] sequence = new int[number + 1];
            sequence[0] = 1;
            sequence[1] = 1;

            var currentSum = 0;

            while (index <= number)
            {
                currentSum = sequence[index-1] + sequence[index-2];
                
                
                sequence[index] = currentSum;
                index++;
            }

            return sequence; 
        }

        /// <summary>
        /// Generates the value of the number that is in the Fibonacci Sequence at the given position provided
        /// </summary>
        /// <param name="number">Position in the Fibonacci Sequence. The first digit in the sequence is 1 and correlates to position 0.</param>
        /// <returns></returns>
        public static int GenerateRecursively(int number)
        {
            if (number == 0)
                return 0;

            if (number == 1)
                return 1;

            return GenerateRecursively(number - 2) + GenerateRecursively(number - 1);

        }
        
    }
}
