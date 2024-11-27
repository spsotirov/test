int nParsed = 0;
int iParsed = 0;
int position1 = 1;
int position2 = 1;
int position3 = 1;
int position4 = 1;
int position5 = 2;
string passList = "Created passwords List: ";


Console.WriteLine("Enter digit n");
string nInput = Console.ReadLine();
nParsed = int.Parse (nInput);
if (nParsed<1)
    { nParsed = 1; }
if (nParsed>9)
    { nParsed = 9; }
Console.WriteLine("Enter digit i");
string iInput = Console.ReadLine();
iParsed= int.Parse (iInput);
if (iParsed < 1)
{ iParsed = 1; }
if (iParsed > 9)
{ iParsed = 9; }

while (position1<=nParsed)
{
    string pass;


    while (position2<=nParsed)
    {
        
        while (position3<=iParsed)
        {
            char letter3 = 'a';
                        
            switch (position3)
            { 
              case 1 : letter3 = 'a';
                    break;
              case 2 : letter3 = 'b';
                    break;
              case 3 : letter3 = 'c';
                    break;
              case 4 : letter3 = 'd';
                    break;
              case 5 : letter3 = 'e';
                    break;
              case 6: letter3 = 'f';
                    break;
              case 7: letter3 = 'g';
                    break;
              case 8: letter3 = 'h';
                    break;
              case 9: letter3 = 'i';
                    break;
            }
                 while (position4 <= iParsed)
                {
                char letter4 = 'a';
                switch (position4)
                {
                    case 1:
                        letter4 = 'a';
                        break;
                    case 2:
                        letter4 = 'b';
                        break;
                    case 3:
                        letter4 = 'c';
                        break;
                    case 4:
                        letter4 = 'd';
                        break;
                    case 5:
                        letter4 = 'e';
                        break;
                    case 6:
                        letter4 = 'f';
                        break;
                    case 7:
                        letter4 = 'g';
                        break;
                    case 8:
                        letter4 = 'h';
                        break;
                    case 9:
                        letter4 = 'i';
                        break;
                }
                while (position5 <= nParsed)
                {
                    if (position5 > position1 && position5 > position2)
                    {
                        pass = string.Concat(position1, position2, letter3, letter4, position5, ' ');
                        passList = string.Concat(passList, pass);
                    }                     
                    
                    position5 = position5 + 1;
                }

                position5 = 1;
                position4 = position4 + 1;


            }

            position4 = 1;
            position3 = position3 + 1;
            
            
        }

        position3 = 1;
        position2 = position2+1;
    }


    position2 = 1;
    position1 = position1 + 1;
    


}
Console.WriteLine(passList);
