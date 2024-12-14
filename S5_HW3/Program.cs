using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace QATraining5_3

{
    class FibonacciSerries
    {

        public static string FibonacciGen(int startInt,int nextInt, int lengthInt)
        {
            List<int> numbersInSerie = new List<int>();
            numbersInSerie.Add(startInt);
            numbersInSerie.Add(nextInt);
            for (int i = 2; i < lengthInt; i++)
            {
                int addNumber = numbersInSerie[i - 2] + numbersInSerie[i - 1];
                numbersInSerie.Add(addNumber);
            }
            string printtString = string.Concat(numbersInSerie[0], ", ", numbersInSerie[1]);
            for (int i = 2; i < lengthInt; i++)
            {



                printtString = string.Concat(printtString, ", ", numbersInSerie[i]);



            }
            return printtString;
        }

        public static void Main()

        {
            
            Console.Write("Enter the Start of series.");
            int startInt =  int.Parse(Console.ReadLine());

            Console.Write("Enter the Next number.");
            int nextInt = int.Parse(Console.ReadLine());

            Console.Write("Enter the Length of series.");
            int lengthInt = int.Parse(Console.ReadLine());
            if (lengthInt < 2)
            {
                Console.Write("Invalid Input.");
                return;
            }



            
            string stringOutput = FibonacciGen (startInt, nextInt, lengthInt);
            
            Console.WriteLine($"[{stringOutput}]");
            
        }

    }
}


