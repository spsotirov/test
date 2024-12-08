Console.WriteLine("Enter the string: ");

string inputString = Console.ReadLine();

Dictionary<char, int> charAppears = new Dictionary<char, int>();

foreach (char i in inputString)
{
    if (i == ' ')
    {
        continue;
    }

    else if (charAppears.ContainsKey(i))
        {
        ++charAppears[i];
        }
    
    else
        {
        
        charAppears.Add(i, 1);
        }
    
}

foreach (var character in charAppears)
{
    Console.WriteLine($"{character.Key} -> {character.Value}");
}