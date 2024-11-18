using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace QATraining2_5

{
    class AgeValidator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");

            string inputAge = Console.ReadLine();
            int.TryParse(inputAge, out int age);
            if(age>0)
            Console.WriteLine("The age is: " + age);
            else Console.WriteLine("The age is invalid.");
        }
    }
}


