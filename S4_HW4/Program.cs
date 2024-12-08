int finalSum = 0;


Console.WriteLine("Enter First player's cards.");
List<int> deckOne = Console.ReadLine().Split().Select(int.Parse).ToList();

Console.WriteLine("Enter Second player's cards.");
List<int> deckTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

Queue<int> queueOne = new Queue<int>(deckOne);
Queue<int> queueTwo = new Queue<int>(deckTwo);

while (queueOne.Count > 0 && queueTwo.Count > 0)
{
    int nextCardQOne = queueOne.Dequeue();
    int nextCardQTwo = queueTwo.Dequeue();

    if (nextCardQOne > nextCardQTwo)
    {
        queueOne.Enqueue(nextCardQOne);
        queueOne.Enqueue(nextCardQTwo);
    }
    else if (nextCardQOne < nextCardQTwo)
    {
        queueTwo.Enqueue(nextCardQTwo);
        queueTwo.Enqueue(nextCardQOne);
    }
    else
    {
        continue;
    }
}

if (queueOne.Count > 0)
{
    finalSum = queueOne.Sum();
    Console.WriteLine($"First player wins! Sum: {finalSum}");
}
else if (queueTwo.Count > 0)
{
    finalSum = queueTwo.Sum();
    Console.WriteLine($"Second player wins! Sum: {finalSum}");
}
else
{
    Console.WriteLine($"No Winner, end of game.");
    finalSum = queueOne.Sum();
    Console.WriteLine($"First player Sum: {finalSum}");
    finalSum = queueTwo.Sum();
    Console.WriteLine($"Second player Sum: {finalSum}");

}
