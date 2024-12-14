namespace S5_HW4
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number to check.");
            int inputNumber = int.Parse(Console.ReadLine());
            bool result = PrimeChecker(inputNumber);
            Console.WriteLine(result);

        }

        static bool PrimeChecker(int inputNumber)
        {
            var prime = true;
            if (inputNumber<2)
                prime = false;
            for (var i = 2; i <= Math.Sqrt(inputNumber); i++)
            {
                if (inputNumber % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            return prime;
        }
    }
}
