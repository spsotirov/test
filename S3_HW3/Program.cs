using System.ComponentModel;

int tabs = 0;
int salary = 0;
int sites = 0;

while (tabs < 1)
{
    Console.WriteLine("Enter number of open tabs");
    string tabsInp = Console.ReadLine();
    int.TryParse(tabsInp, out tabs);
    if (tabs<1 || tabs >10)
    {
        Console.WriteLine("Invalid input");
        tabs = 0;
    }
}

while (salary < 1)
{
    Console.WriteLine("Enter Salary");
    string salaryInp = Console.ReadLine();
    int.TryParse(salaryInp, out salary);
    if (salary < 700 || salary > 1500)
    {
        Console.WriteLine("Invalid input");
        salary = 0;
    }
}

Console.WriteLine("Tabs " + tabs);
Console.WriteLine("Salary " + salary);

while (sites < tabs)
{
    Console.WriteLine("Tab Site?");
    string siteInp = Console.ReadLine();
    if (siteInp == "Facebook")
    {
        salary = salary - 150;
    }
    else if (siteInp == "Instagram")
    {
        salary = salary - 100;
    }
    else if(siteInp == "Reddit")
    {
        salary = salary - 500;
    }
    sites = ++sites;
}
if (salary <= 0)
{
    Console.WriteLine("You have lost your salary!");
}
else Console.WriteLine("Reamining salary " + salary + " BGN");