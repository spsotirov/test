using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace QATraining2_2

{
    class FormatedName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter First Name and press Enter:");

            string nameFirst = Console.ReadLine();

            Console.WriteLine("Please enter Last Name and press Enter:");

            string nameLast = Console.ReadLine();

            string nameFormated = $"'Formated Name is: {nameLast}, {nameFirst}";

            Console.WriteLine(nameFormated);
        }
    }
}


