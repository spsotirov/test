
using System.Resources;

Dictionary<string, int> items = new Dictionary<string, int>();

string type;
int qty = 0;
Console.WriteLine("Enter Item:");
string input = Console.ReadLine();

while ( input.ToLower() != "stop")
{
        
    type = input;
    Console.WriteLine("Enter Quanttity:");
    qty = int.Parse(Console.ReadLine());

    if (qty<1||qty>2000000000)
        {
        Console.WriteLine("Invailid Input:");
        continue;
        }
   
    if (items.ContainsKey(input))
    {
        items[input] += qty;
    }

    else
    {
        items.Add(input, qty);
    }
    Console.WriteLine("Enter Item:");
    input = Console.ReadLine();


}

foreach (var item in items)
{
    Console.WriteLine($"{item.Key} -> {item.Value}");
}