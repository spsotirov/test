namespace S5_HW8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Second Number:");
            int secondNumber = int.Parse(Console.ReadLine());
            if (secondNumber == 0)
            {
                Console.WriteLine("Invalid input:");
                return;
            }
            DivideInput(firstNumber, secondNumber, out int quotient, out int remainder);
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
        }

        static void DivideInput(int firstNumber, int secondNumber, out int quotient, out int remainder)
        {
            quotient = firstNumber / secondNumber;
            remainder = firstNumber % secondNumber;
        }
    }
}
