
Console.WriteLine("Enter the initial passangers by wagons list.");
List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int train = wagons.Count;
Console.WriteLine("Enter wagon capacity.");
int wagonCapacity = int.Parse(Console.ReadLine());

string currentInput;

Console.WriteLine("Enter next.");
while ((currentInput = Console.ReadLine().ToLower()) != "end")
{
    string[] inputSplited = currentInput.Split(' ');

    if (inputSplited[0] == "add")
    {
        int newWagon = int.Parse(inputSplited[1]);

        wagons.Add(newWagon);
        train++;
        Console.WriteLine("Enter next.");
    }
    else
    {
        int peopleToAdd = int.Parse(inputSplited[0]);

        for (int i = 0; i < train; i++)
        {
            if (peopleToAdd > wagonCapacity)
            {
                Console.WriteLine($"Wagon capacity is {wagonCapacity}, use smaller groups.");
                break;

            }
            if (wagons[i] + peopleToAdd <= wagonCapacity)
            {
                wagons[i] += peopleToAdd;
                break;
            }

            if ((wagons[i] + peopleToAdd > wagonCapacity) && i == train - 1)
            {

                Console.WriteLine("Can't add them, add a new wagon.");
            }

        }

        Console.WriteLine("Enter next.");
        
    }
}
    

Console.WriteLine(string.Join(" ", wagons));