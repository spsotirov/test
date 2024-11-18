using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace QATraining2_1

{
    class StrSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number A and press Enter:");

            string numberA = Console.ReadLine();
            int.TryParse(numberA, out int numberAint);


            Console.WriteLine("Please enter number B and press Enter:");
            
            string numberB = Console.ReadLine();
            int.TryParse(numberB, out int numberBint);

            int numberC =numberAint+numberBint;
            
            Console.WriteLine("The sum is: " + numberC);
        }
    }
}


