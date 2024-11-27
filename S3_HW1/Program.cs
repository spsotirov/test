

int rows=0;
int lines = 0;
int seats = 0;
int records=0;
int ticketsP = 0;
int ticketsN = 0;
int ticketsD = 0;
int free = 0;
double revenue = 0;

Console.WriteLine("Please enter the number of Rows in the Hall and press Enter:");
while (rows<1)
{
    string rowsInp = Console.ReadLine();
    int.TryParse(rowsInp, out rows);
    if (rows<1)
    {
        Console.WriteLine("Invalid input, try again.");
    }   
    
}


Console.WriteLine("Please enter the number of Lines per Row and press Enter:");
while (lines < 1) 
{
    string linesInp = Console.ReadLine();
    int.TryParse(linesInp, out lines);
    if (lines < 1) 
    {
        Console.WriteLine("Invalid input, try again.");
    }
}

seats = lines * rows;
Console.WriteLine("Total seats in the Hall: " + seats);


while (records<seats)
{
    Console.WriteLine("Please enter Tickets Type and press Enter:");
    string typeInp = Console.ReadLine();

    if (typeInp == "Premiere")
    {
        int inpTicketsP = 0;
        Console.WriteLine("Please enter the number of sold tickets and press Enter:");
        while (inpTicketsP < 1)
        {
            string ticketsPstr = Console.ReadLine();
            int.TryParse(ticketsPstr, out inpTicketsP);
            if ((inpTicketsP < 1) || (inpTicketsP + records > seats))
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                ticketsP = ticketsP + inpTicketsP;
                records = records + inpTicketsP;
                free = seats - records;
                Console.WriteLine("Total seats: " + seats + ", sold: " + records + ", free: " + free);
            }
        }

    }
    else if (typeInp == "Normal")
    {
        int inpTicketsN = 0;
        Console.WriteLine("Please enter the number of sold tickets and press Enter:");
        while (inpTicketsN < 1)
        {
            string ticketsPstr = Console.ReadLine();
            int.TryParse(ticketsPstr, out inpTicketsN);
            if ((inpTicketsN < 1) || (inpTicketsN + records > seats))
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                ticketsN = ticketsN + inpTicketsN;
                records = records + inpTicketsN;
                free = seats - records;
                Console.WriteLine("Total seats: " + seats + ", sold: " + records + ", free: " + free);
            }
        }

    }
    else if (typeInp == "Discount")
    {
        int inpTicketsD = 0;
        Console.WriteLine("Please enter the number of sold tickets and press Enter:");
        while (inpTicketsD < 1)
        {
            string ticketsPstr = Console.ReadLine();
            int.TryParse(ticketsPstr, out inpTicketsD);
            if ((inpTicketsD < 1) || (inpTicketsD + records > seats))
            {
                Console.WriteLine("Invalid input.");
            }
            else
            {
                
                ticketsD = ticketsD + inpTicketsD;
                records = records + inpTicketsD;
                free = seats - records;
                Console.WriteLine("Total seats: " + seats + ", sold: " + records + ", free: " + free);

            }
        }

    }
    else { Console.WriteLine("Invalid Ticket type, use Premiere, Normal or Discount."); }
    

}
free = seats - records;
revenue = (12 * ticketsP) + (7.5 * ticketsN) + (5 * ticketsD);

Console.WriteLine("Sold Premiere: " + ticketsP);
Console.WriteLine("Sold Normal: " + ticketsN);
Console.WriteLine("Sold Discount: " + ticketsD);
Console.WriteLine($"All tickets sold. Total Revenue: {revenue:0.##} BGN");
