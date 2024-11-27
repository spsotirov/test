int width = 0;
int length = 0;
int piecesTotal = 0;
int piecesOut = 0;
int needed = 0;

while (width < 1)
{
    Console.WriteLine("Enter cake width:");
    string widthInp = Console.ReadLine();
    int.TryParse(widthInp, out width);
    if (width <1)
    { Console.WriteLine("Invalid input."); }
}

while (length < 1)
{
    Console.WriteLine("Enter cake length:");
    string lengthInp = Console.ReadLine();
    int.TryParse(lengthInp, out length);
    if (length < 1)
    { Console.WriteLine("Invalid input."); }
}
piecesTotal = width * length;

while (piecesTotal>piecesOut)
{
    Console.WriteLine("New taken pieces?");
    string takenInput =Console.ReadLine();
    int taken = 0;
    if (takenInput=="STOP")
    {
        int left = piecesTotal - piecesOut;
        Console.WriteLine($"{left} pieces left");
        return;    
    }
    int.TryParse(takenInput, out taken);
    piecesOut = piecesOut + taken;
}
needed = piecesOut - piecesTotal;
Console.WriteLine($"No more cake left! You need {needed} pieces more.");