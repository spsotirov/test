string outputList = "Output result: ";
Console.WriteLine("Enter the first array: ");
string[] firstArrayInput = Console.ReadLine().Split(" ");

Console.WriteLine("Enter the second array: ");
string[] secondArrayInput = Console.ReadLine().Split(" ");

foreach (string item2 in secondArrayInput)
{
    foreach (string item1 in firstArrayInput)
    {
        
        if (item1.Equals(item2))
        {
            outputList = string.Concat(outputList, item1,' ');           
        }
    }
}
Console.WriteLine(outputList);