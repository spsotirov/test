
string outputlist = "";
int seriesCount = 1;
int maxLength = 1;
Console.WriteLine("Enter the string of digits, separated by a space:");



string valuesConsInput = Console.ReadLine();
string[] itemsSplited = valuesConsInput.Split();
int[] digits = new int[itemsSplited.Length];


for (int i = 0; i < itemsSplited.Length; i++)
{
    digits[i] = int.Parse(itemsSplited[i]);

}
string currentString = string.Concat(digits[0], " ");
for (int i = 1; i < digits.Length; i++)
{
   if (digits[i] == digits[i-1])
    {
        seriesCount++;
        currentString = string.Concat(currentString, digits[i]," ");
       
        if (seriesCount > maxLength)
        {
            maxLength = seriesCount;
            outputlist = string.Concat("Output result: ", currentString);

        }
    }
   else
    {
        

        seriesCount = 1;
        currentString = string.Concat( digits[i], " ");

    }

}
Console.WriteLine(outputlist);
Console.WriteLine(maxLength);
