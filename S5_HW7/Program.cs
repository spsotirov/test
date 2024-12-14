namespace S5_HW7
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a serie of integers separated by spaces:");
            int[] inputArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine("Enter an integer multiplier:");
            int multiplier = int.Parse(Console.ReadLine());
            UpdateArray(ref inputArray, ref multiplier);
            Console.WriteLine("The new values are: " + string.Join(", ", inputArray));
        }

        static void UpdateArray(ref int[] inputArray, ref int multiplier)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                inputArray[i] *= multiplier;
            }
        }
    }
}
