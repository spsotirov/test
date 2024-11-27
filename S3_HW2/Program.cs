using System.ComponentModel.Design;

int budget = 0;
int men = 0;
string season;
int price = 0;
double discountCoef = 1;
double evenCoef = 1;
double finalPrice = 0;

Console.WriteLine("Enter the budget in range 1-8000:");
string budgetInp = Console.ReadLine();



budget = int.Parse(budgetInp);
if (budget < 1)
{
    Console.WriteLine("Invalid input, calculating with Budget=1.");
    budget = 1;
}
else if (budget > 8000)
{
    Console.WriteLine("Invalid input, calculating with Budget=8000.");
    budget = 8000;
}


Console.WriteLine("Enter number of people 4-18:");
string menInp = Console.ReadLine();
men = int.Parse(menInp);
if (men %2 == 0)
{
    evenCoef = 0.95;
}
if (men < 4)
{
    Console.WriteLine("Invalid input, calculating for group of 4, excluding 5% discount.");
    men = 4;
    evenCoef = 1;
}
else if (men > 18)
{
    Console.WriteLine("Invalid input, calculating for group of 18, ex.");
    men = 18;
    evenCoef = 1;
}


Console.WriteLine("Enter season Spring, Summer, Autumn or Winter:");
string seasonInp = Console.ReadLine();
if (seasonInp == "Spring")
{
    price = 3000;
}
else if (seasonInp == "Summer" || seasonInp == "Autumn")
{
    price = 4200;
}
else if (seasonInp == "Winter")
{
    price = 2600;
}
else 
{
    Console.WriteLine("Invalid input, calculating with top price 4200 and no discount.");
    price=4200;
}
if (seasonInp == "Autumn")
    {
        evenCoef = 1;
    }

        if (men <7)
{
    discountCoef = 0.9;
}
else if (men > 6 && men < 12)
{ 
    discountCoef = 0.85;
}
else if (men > 11)
{ 
    discountCoef = 0.75;
}
finalPrice = price * evenCoef * discountCoef;

if (finalPrice <= budget)
{
    Console.WriteLine("Within budget.");
}
else
{
    Console.WriteLine("Over budget.");
}

Console.WriteLine(budget);
Console.WriteLine(men);
Console.WriteLine(price);
Console.WriteLine(finalPrice);