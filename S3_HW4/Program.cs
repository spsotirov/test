int steps = 0;



while (steps<10000)
{
    Console.WriteLine("Enter steps.");
    string input = Console.ReadLine();
    int stepsOut = 0;
    int.TryParse(input, out stepsOut);
    steps = steps + stepsOut;
    if (input == "Going Home")
    {
        Console.WriteLine("Enter steps to home.");
        input = Console.ReadLine();
        stepsOut = 0;
        int.TryParse(input, out stepsOut);
        int remaining = 10000 - (steps + stepsOut);
        Console.WriteLine($"{remaining} steps to go");
        return;

    }
    
    if (steps >= 10000)
    {
        Console.WriteLine("Goal reached! Good job!");
        return;
    }


   
}