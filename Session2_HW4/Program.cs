using System;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace QATraining2_4

{
    class CircleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Radius and press Enter:");

            string radius = Console.ReadLine();
            double radiusD= double.Parse(radius);

            double area = Math.PI * radiusD * radiusD;

            Console.WriteLine($"The area is: {area:0.##}");
        }
    }
}


