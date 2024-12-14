namespace S5_HW9
{
    internal class Program
    {
        static void Main()
        {
            int parsingOutput = 0;

            Console.WriteLine("Parsing Input?");
            string inputString = Console.ReadLine();
            parsingOutput = ParseInput(inputString);
            Console.WriteLine("Parsing attempt result: " + parsingOutput);
        }

        static int ParseInput(string input)
        {
            int.TryParse(input, out int result);
            return result;
                       
        }
    }
}
