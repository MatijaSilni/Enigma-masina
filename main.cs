using System;

class Program
{
    static char[] prviRed = { 'Q', 'W', 'E', 'R', 'T', 'Z', 'U', 'I', 'O' };
    static char[] drugiRed = { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K' };
    static char[] treciRed = { 'P', 'Y', 'X', 'C', 'V', 'B', 'N', 'M', 'L' };
  
    static char[] abeceda = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
    static int X = 2, Y = 0;
  
    static char[] prviRotor = { 'E', 'K', 'M', 'F', 'L', 'G', 'D', 'Q', 'V', 'Z', 'N', 'T', 'O', 'W', 'Y', 'H', 'X', 'U', 'S', 'P', 'A', 'I', 'B', 'R', 'C', 'J'};
    static int[] drugiRotor = { 'A', 'J', 'D', 'K', 'S', 'I', 'R', 'U', 'X', 'B', 'L', 'H', 'W', 'T', 'M', 'C', 'Q', 'G', 'Z', 'N', 'P', 'Y', 'F', 'V', 'O', 'E'};
    static char[] treciRotor = { 'B', 'D', 'F', 'H', 'J', 'L', 'C', 'P', 'R', 'T', 'X', 'V', 'Z', 'N', 'Y', 'E', 'I', 'W', 'G', 'A', 'K', 'M', 'U', 'S', 'Q', 'O'};
    static char[] cetvrtiRotor = { 'E', 'S', 'O', 'V', 'P', 'Z', 'J', 'A', 'Y', 'Q', 'U', 'I', 'R', 'H', 'X', 'L', 'N', 'F', 'T', 'G', 'K', 'D', 'C', 'M', 'W', 'B'};
    static char[] petiRotor = { 'V', 'Z', 'B', 'R', 'G', 'I', 'T', 'Y', 'U', 'P', 'S', 'D', 'N', 'H', 'L', 'X', 'A', 'W', 'M', 'J', 'Q', 'O', 'F', 'E', 'C', 'K'};
     static int[] prviReflektor = { 'Y', 'R', 'U', 'H', 'Q', 'S', 'L', 'D', 'P', 'X', 'N', 'G', 'O', 'K', 'M', 'I', 'E', 'B', 'F', 'Z', 'C', 'W', 'V', 'J', 'A', 'T' };
        static char[] drugiReflektor = { 'F', 'V', 'P', 'J', 'I', 'A', 'O', 'Y', 'E', 'D', 'R', 'Z', 'X', 'W', 'G', 'C', 'T', 'K', 'U', 'Q', 'S', 'B', 'N', 'M', 'H', 'L' };

    static void CrtanjeRotora()
        {
            char hor = '\u2500', ver = '\u2502';
            char gLevi = '\u250C', gDesni = '\u2510';
            char dLevi = '\u2514', dDesni = '\u2518';
            char levi = '\u251C', desni = '\u2524';
            int rotor1 = 0;
            int rotor2 = 0;
            int rotor3 = 0;
            //prvi rotor
            Console.SetCursorPosition(36, 5);
            Console.Write("" + gLevi + hor + hor + hor + hor + gDesni);

            Console.SetCursorPosition(36, 6);
            Console.Write("" + ver + " " + (rotor1 + 1).ToString("00") + " " + ver + "   ");

            Console.SetCursorPosition(36, 7);
            Console.Write("" + levi + hor + hor + hor + hor + desni + "  ");

            Console.SetCursorPosition(36, 8);
            Console.Write("" + ver + "    " + ver + "  ");

            Console.SetCursorPosition(36, 9);
            Console.Write("" + ver + " " + rotor1.ToString("00") + " " + ver + "   ");

            Console.SetCursorPosition(36, 10);
            Console.Write("" + ver + "    " + ver + "   ");

            Console.SetCursorPosition(36, 11);
            Console.Write("" + levi + hor + hor + hor + hor + desni + "  ");

            Console.SetCursorPosition(36, 12);
            Console.Write("" + ver + " 25" + " " + ver + "   ");

            Console.SetCursorPosition(36, 13);
            Console.Write("" + dLevi + hor + hor + hor + hor + dDesni + "  ");

            //drugi rotor
            Console.SetCursorPosition(28, 5);
            Console.Write("" + gLevi + hor + hor + hor + hor + gDesni);

            Console.SetCursorPosition(28, 6);
            Console.Write("" + ver + " " + (rotor2 + 1).ToString("00") + " " + ver + "  ");

            Console.SetCursorPosition(28, 7);
            Console.Write("" + levi + hor + hor + hor + hor + desni + "  ");

            Console.SetCursorPosition(28, 8);
            Console.Write("" + ver + "    " + ver + "  ");

            Console.SetCursorPosition(28, 9);
            Console.Write("" + ver + " " + rotor2.ToString("00") + " " + ver + "  ");

            Console.SetCursorPosition(28, 10);
            Console.Write("" + ver + "    " + ver + "  ");

            Console.SetCursorPosition(28, 11);
            Console.Write("" + levi + hor + hor + hor + hor + desni + "  ");

            Console.SetCursorPosition(28, 12);
            Console.Write("" + ver + " 25" + " " + ver + "  ");

            Console.SetCursorPosition(28, 13);
            Console.Write("" + dLevi + hor + hor + hor + hor + dDesni + "  ");

            //treci rotor
            Console.SetCursorPosition(20, 5);
            Console.Write("" + gLevi + hor + hor + hor + hor + gDesni);

            Console.SetCursorPosition(20, 6);
            Console.Write("" + ver + " " + (rotor3 + 1).ToString("00") + " " + ver + "  ");

            Console.SetCursorPosition(20, 7);
            Console.Write("" + levi + hor + hor + hor + hor + desni + "  ");

            Console.SetCursorPosition(20, 8);
            Console.Write("" + ver + "    " + ver + "  ");

            Console.SetCursorPosition(20, 9);
            Console.Write("" + ver + " " + rotor3.ToString("00") + " " + ver + "  ");

            Console.SetCursorPosition(20, 10);
            Console.Write("" + ver + "    " + ver + "  ");

            Console.SetCursorPosition(20, 11);
            Console.Write("" + levi + hor + hor + hor + hor + desni + "  ");

            Console.SetCursorPosition(20, 12);
            Console.Write("" + ver + " 25" + " " + ver + "  ");

            Console.SetCursorPosition(20, 13);
            Console.Write("" + dLevi + hor + hor + hor + hor + dDesni + "  ");           
        }
  static void PodesavanjeRotora()
  {
    int x = X * 8 + 22;
    int y = 9;
                int rotor1 = 0;
            int rotor2 = 0;
            int rotor3 = 0;
            
            Console.SetCursorPosition(x, y);
            ConsoleKeyInfo strelica;
            do
            {
                strelica = Console.ReadKey();
                if (strelica.Key == ConsoleKey.RightArrow)
                {
                    if (x != 38)
                    {
                        X++;
                    }
                }
                else if (strelica.Key == ConsoleKey.LeftArrow)
                {
                    if (x != 22)
                        X--;
                }
                else if (strelica.Key == ConsoleKey.UpArrow)
                {
                    if (x == 22)
                    {
                        rotor3--;
                        if (rotor3 == -26) rotor3 = 0;
                        Console.Write(((rotor3 + 26) % 26).ToString("00"));
                        Console.SetCursorPosition(22, 6);
                        Console.Write(((rotor3 + 27) % 26).ToString("00"));
                        Console.SetCursorPosition(22, 12);
                        Console.Write(((rotor3 + 25) % 26).ToString("00"));
                    }
                    else if (x == 30)
                    {
                        rotor2--;
                        if (rotor2 == -26) rotor2 = 0;
                        Console.Write(((rotor2 + 26) % 26).ToString("00"));
                        Console.SetCursorPosition(30, 6);
                        Console.Write(((rotor2 + 27) % 26).ToString("00"));
                        Console.SetCursorPosition(30, 12);
                        Console.Write(((rotor2 + 25) % 26).ToString("00"));
                    }
                    else
                    {
                        rotor1--;
                        if (rotor1 == -26) rotor1 = 0;
                        Console.Write(((rotor1 + 26) % 26).ToString("00"));
                        Console.SetCursorPosition(38, 6);
                        Console.Write(((rotor1 + 27) % 26).ToString("00"));
                        Console.SetCursorPosition(38, 12);
                        Console.Write(((rotor1 + 25) % 26).ToString("00"));
                    }
                }
                else if(strelica.Key == ConsoleKey.DownArrow)
                {
                    if (x == 22)
                    {
                        rotor3++;
                        if (rotor3 == -26) rotor3 = 0;
                        Console.Write(((rotor3 + 26) % 26).ToString("00"));
                        Console.SetCursorPosition(22, 6);
                        Console.Write(((rotor3 + 27) % 26).ToString("00"));
                        Console.SetCursorPosition(22, 12);
                        Console.Write(((rotor3 + 25) % 26).ToString("00"));
                    }
                    else if (x == 30)
                    {
                        rotor2++;
                        if (rotor2 == -26) rotor2 = 0;
                        Console.Write(((rotor2 + 26) % 26).ToString("00"));
                        Console.SetCursorPosition(30, 6);
                        Console.Write(((rotor2 + 27) % 26).ToString("00"));
                        Console.SetCursorPosition(30, 12);
                        Console.Write(((rotor2 + 25) % 26).ToString("00"));
                    }
                    else
                    {
                        rotor1++;
                        if (rotor1 == -26) rotor1 = 0;
                        Console.Write(((rotor1 + 26) % 26).ToString("00"));
                        Console.SetCursorPosition(38, 6);
                        Console.Write(((rotor1 + 27) % 26).ToString("00"));
                        Console.SetCursorPosition(38, 12);
                        Console.Write(((rotor1 + 25) % 26).ToString("00"));
                    }
                }
                x = X * 8 + 22;
                Console.SetCursorPosition(x, y);
            } while (strelica.Key != ConsoleKey.Enter);
  }
static void Tastatura()
{
    char hor = '\u2500', ver = '\u2502';
    char gLevi = '\u250C', gDesni = '\u2510';
    char dLevi = '\u2514', dDesni = '\u2518';
    char gornji = '\u252C', donji = '\u2534';

    //prvi red

    Console.SetCursorPosition(10, 15);
    Console.Write("" + gLevi + hor);
    for (int i = 0; i < 8; i++)
    {
        Console.Write("" + hor + hor + gornji + hor);
    }
    Console.Write("" + hor + hor + gDesni);

    Console.SetCursorPosition(10, 16);
    for (int i = 0; i < 9; i++)
    {
        Console.Write("" + ver + " " + prviRed[i] + " ");
    }
    Console.Write(ver);

    Console.SetCursorPosition(10, 17);
    Console.Write("" + dLevi + hor);
    for (int i = 0; i < 8; i++)
    {
        Console.Write("" + hor + hor + donji + hor);
    }
    Console.Write("" + hor + hor + dDesni);

    //drugi red

    Console.SetCursorPosition(12, 18);
    Console.Write("" + gLevi + hor);
    for (int i = 0; i < 7; i++)
    {
        Console.Write("" + hor + hor + gornji + hor);
    }
    Console.Write("" + hor + hor + gDesni);

    Console.SetCursorPosition(12, 19);
    for (int i = 0; i < 8; i++)
    {
        Console.Write("" + ver + " " + drugiRed[i] + " ");
    }
    Console.Write(ver);

    Console.SetCursorPosition(12, 20);
    Console.Write("" + dLevi + hor);
    for (int i = 0; i < 7; i++)
    {
        Console.Write("" + hor + hor + donji + hor);
    }
    Console.Write("" + hor + hor + dDesni);

    //treci red

    Console.SetCursorPosition(10, 21);
    Console.Write("" + gLevi + hor);
    for (int i = 0; i < 8; i++)
    {
        Console.Write("" + hor + hor + gornji + hor);
    }
    Console.Write("" + hor + hor + gDesni);

    Console.SetCursorPosition(10, 22);
    for (int i = 0; i < 9; i++)
    {
        Console.Write("" + ver + " " + treciRed[i] + " ");
    }
    Console.Write(ver);

    Console.SetCursorPosition(10, 23);
    Console.Write("" + dLevi + hor);
    for (int i = 0; i < 8; i++)
    {
        Console.Write("" + hor + hor + donji + hor);
    }
    Console.Write("" + hor + hor + dDesni);
}
static void Plugboard()
{
    char krug = '\u2B24';
    //prvi red

    for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
    {
        Console.SetCursorPosition(20 + j, 25);
        Console.Write("" + prviRed[i]);
    }

    for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
    {
        Console.SetCursorPosition(20 + j, 26);
        Console.Write("" + krug);
    }

    //drugi red

    for (int i = 0, j = 0; i < 8 && j < 16; i++, j += 2)
    {
        Console.SetCursorPosition(21 + j, 27);
        Console.Write("" + drugiRed[i]);
    }

    for (int i = 0, j = 0; i < 8 && j < 16; i++, j += 2)
    {
        Console.SetCursorPosition(21 + j, 28);
        Console.Write("" + krug);
    }

    //treci red

    for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
    {
        Console.SetCursorPosition(20 + j, 29);
        Console.Write("" + treciRed[i]);
    }

    for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
    {
        Console.SetCursorPosition(20 + j, 30);
        Console.Write("" + krug);
    }
}
static void PodesavanjePlugboard()
{
    ConsoleColor[] nizboja = new ConsoleColor [13];
    char[] slova = new char [26];
}
static char UnosSlova()
{
    Console.WriteLine();
    bool tacnost = false;
    string red;
    char slovo = '-';
    while (!tacnost)
    {
        Console.Write("Unesite slovo: ");
        red = Console.ReadLine();
        if (red.Length == 1)
        {
            slovo = Convert.ToChar(red);
            if (slovo >= 'A' && slovo <= 'Z')
            {
                tacnost = true;
            }
            else
                Console.Write("Greska. ");
        }
        else
            Console.Write("Greska. ");
    }
    return slovo;
}
  static void Main(string[] args)
  {
      CrtanjeRotora();
      Tastatura();
      Plugboard();
      PodesavanjeRotora();
      PodesavanjePlugboard();
      char slovo;
      while (true)
      {
          slovo = UnosSlova();
      }
  }
}
