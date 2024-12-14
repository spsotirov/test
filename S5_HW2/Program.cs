using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace QATraining5_2

{
    class ReversedString
    {

        public static string RevertInput(string inputString)
        {
            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void Main()

        {
            
            Console.Write("Enter the string.");
            string inputString = Console.ReadLine();
            if (inputString.Length == 0)
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            else
            {
                string stringOutput = RevertInput(inputString);
                
                Console.WriteLine(stringOutput);
            }
        }

    }
}


