using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace QATraining5_1

{
    class MaxInteger
    {

        public static int FindMaxInput(int[] inputNumbers)
        {
            int maxOutput = inputNumbers.Max();
            return maxOutput;
        }

        public static void Main()
        
        {
            int maxFromInput = 0;
            Console.Write("Enter the string of integers, separated by spaces:");
            string inputString = Console.ReadLine();
            if (inputString.Length==0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            else
            {
                int[] inputNumbers = inputString.Split(" ").Select(int.Parse).ToArray();
                maxFromInput = FindMaxInput(inputNumbers);
                if (maxFromInput<0)
                {

                    Console.WriteLine("WARNING: All numbers were negative.");
                }
                Console.WriteLine($"The biggest number is {maxFromInput}.");
            }
        }
        
    }
}


