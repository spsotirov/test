namespace S5_HW6
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the First Number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number:");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"Original First Number value: {firstNumber}");
            Console.WriteLine($"Original Second Number value: {secondNumber}");
            SwapNumbers(ref firstNumber, ref secondNumber);
            Console.WriteLine("After processing: " );
            Console.WriteLine($"Updated First Number value: {firstNumber}");
            Console.WriteLine($"Updated Second Number value: {secondNumber}");

        }

        static void SwapNumbers(ref int firstNumber, ref int secondNumber)
        {
            int temp1 = firstNumber;
            int temp2 = secondNumber;
            firstNumber = temp2;
            secondNumber = temp1;
        }
    }
}


