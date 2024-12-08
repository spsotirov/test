

Console.WriteLine("Enter N S X string: ");

string[] input = Console.ReadLine().Split().ToArray();
int N = int.Parse(input[0]);
int S = int.Parse(input[1]);
int X = int.Parse(input[2]);
if (N == 0|| N<=S || S<0)
{
    Console.WriteLine("Invalid Input ");
    return;
}

Console.WriteLine("Enter the explored string: ");
int[] inpNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
if (inpNumbers.Length != N )
{
    Console.WriteLine("Invalid Input ");
    return;
}

Stack<int> stack = new Stack<int>();


for (int i = 0; i < N; i++)
{
    stack.Push(inpNumbers[i]);
}

for (int i = 0; i < S; i++)
{
    stack.Pop();
}


if (stack.Contains(X))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(stack.Min());
}