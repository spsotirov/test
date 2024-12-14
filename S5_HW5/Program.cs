namespace S5_HW5
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the numbers separated by spaces:");
            int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            SortInput(inputArray);
            Console.WriteLine("Output: " + string.Join(", ", inputArray));

        }

        static void SortInput(int[] inputArray)
        {
            for (int indexBase = 0; indexBase < inputArray.Length - 1; indexBase++)
            {
                for (int indexComparison = indexBase + 1; indexComparison < inputArray.Length; indexComparison++)
                {
                    if (inputArray[indexBase] > inputArray[indexComparison])
                    {
                        int temp = inputArray[indexBase];
                        inputArray[indexBase] = inputArray[indexComparison];
                        inputArray[indexComparison] = temp;
                    }
                }
            }
        }
    }
}


