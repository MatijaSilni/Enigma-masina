using System;

class Program
{
    static char[] prviRed = { 'Q', 'W', 'E', 'R', 'T', 'Z', 'U', 'I', 'O' };
    static char[] drugiRed = { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K' };
    static char[] treciRed = { 'P', 'Y', 'X', 'C', 'V', 'B', 'N', 'M', 'L' };
    static int[] abeceda = { 00, 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25};
    static int X = 0, Y = 0;
    static int[] prviRotor = { 01, 12, 04, 06, 21, 08, 19, 25, 15, 20, 17, 00, 10, 16, 03, 24, 14, 07, 13, 22, 11, 18, 23, 02, 09, 25};
    static int[] drugiRotor = { 03, 02, 01, 04, 12, 23, 25, 00, 11, 22, 05, 19, 14, 09, 20, 13, 24, 21, 18, 08, 16, 06, 07, 17, 10, 15};
    static int[] treciRotor = { 15, 22, 16, 01, 18, 25, 24, 12, 20, 08, 19, 23, 21, 05, 06, 07, 03, 02, 14, 17, 13, 10, 04, 09, 11, 00};
    static int[] reflektot = { 11, 14, 18, 25, 07, 10, 19, 04, 13, 15, 05, 00, 23, 08, 01, 09, 24, 20, 02, 06, 17, 01, 09, 12, 16, 03};
    static void CrtanjeRotora()
    {
      char hor = '\u2500', ver = '\u2502';
      char gLevi = '\u250C', gDesni = '\u2510';
      char dLevi = '\u2514', dDesni = '\u2518';
      char levi = '\u251C', desni = '\u2524';

    //prvi rotor
    Console.SetCursorPosition(20, 5);
        Console.Write("" + gLevi + hor + hor + hor + gDesni);

        Console.SetCursorPosition(20, 6);
        Console.Write("" + ver + " " + abeceda[1] + " " + ver + "   ");

        Console.SetCursorPosition(20, 7);
        Console.Write("" + levi + hor + hor + hor + desni + "   ");

        Console.SetCursorPosition(20, 8);
        Console.Write("" + ver + "   " + ver + "   ");

        Console.SetCursorPosition(20, 9);
        Console.Write("" + ver + " " + abeceda[0] + " " + ver + "   ");

        Console.SetCursorPosition(20, 10);
        Console.Write("" + ver + "   " + ver + "   ");

        Console.SetCursorPosition(20, 11);
        Console.Write("" + levi + hor + hor + hor + desni + "   ");

        Console.SetCursorPosition(20, 12);
        Console.Write("" + ver + " " + abeceda[25] + " " + ver + "   ");

        Console.SetCursorPosition(20, 13);
        Console.Write("" + dLevi + hor + hor + hor + dDesni + "   ");

        //drugi rotor
        Console.SetCursorPosition(26, 5);
        Console.Write("" + gLevi + hor + hor + hor + gDesni);

        Console.SetCursorPosition(26, 6);
        Console.Write("" + ver + " " + abeceda[1] + " " + ver + "   ");

        Console.SetCursorPosition(26, 7);
        Console.Write("" + levi + hor + hor + hor + desni + "   ");

        Console.SetCursorPosition(26, 8);
        Console.Write("" + ver + "   " + ver + "   ");

        Console.SetCursorPosition(26, 9);
        Console.Write("" + ver + " " + abeceda[0] + " " + ver + "   ");

        Console.SetCursorPosition(26, 10);
        Console.Write("" + ver + "   " + ver + "   ");

        Console.SetCursorPosition(26, 11);
        Console.Write("" + levi + hor + hor + hor + desni + "   ");

        Console.SetCursorPosition(26, 12);
        Console.Write("" + ver + " " + abeceda[25] + " " + ver + "   ");

        Console.SetCursorPosition(26, 13);
        Console.Write("" + dLevi + hor + hor + hor + dDesni + "   ");

        //treci rotor
        Console.SetCursorPosition(32, 5);
        Console.Write("" + gLevi + hor + hor + hor + gDesni);

        Console.SetCursorPosition(32, 6);
        Console.Write("" + ver + " " + abeceda[1] + " " + ver + "   ");
        Console.SetCursorPosition(32, 7);
        Console.Write("" + levi + hor + hor + hor + desni + "   ");

        Console.SetCursorPosition(32, 8);
        Console.Write("" + ver + "   " + ver + "   ");

        Console.SetCursorPosition(32, 9);
        Console.Write("" + ver + " " + abeceda[0] + " " + ver + "   ");

        Console.SetCursorPosition(32, 10);
        Console.Write("" + ver + "   " + ver + "   ");

        Console.SetCursorPosition(32, 11);
        Console.Write("" + levi + hor + hor + hor + desni + "   ");

        Console.SetCursorPosition(32, 12);
        Console.Write("" + ver + " " + abeceda[25] + " " + ver + "   ");

        Console.SetCursorPosition(32, 13);
        Console.Write("" + dLevi + hor + hor + hor + dDesni + "   ");
    }
static void Tastatura()
{
    // Console.BackgroundColor = ConsoleColor.White;
    //Console.ForegroundColor = ConsoleColor.Black;
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
    //Console.BackgroundColor = ConsoleColor.White;
    //Console.ForegroundColor = ConsoleColor.Black;
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
    int x = X * 2 + 20;
    int y = Y * 2 + 26;
    Console.SetCursorPosition(x, y);
    ConsoleKeyInfo strelica;
    do
    {
        strelica = Console.ReadKey();
        if (strelica.Key == ConsoleKey.RightArrow)
        {
            if (x != 36)
                X++;
        }
        else if (strelica.Key == ConsoleKey.LeftArrow)
        {
            if (x != 20)
                X--;
        }
        else if (strelica.Key == ConsoleKey.UpArrow)
        {
            if (y != 26)
                Y--;
        }
        else if (strelica.Key == ConsoleKey.DownArrow)
        {
            if (y == 26)
            {
                Y++;
                x = X * 2 + 21;
                if (x == 36)
                    x = X * 2 + 19;
            }
            else if (y == 28)
            {
                Y++;
                x = X * 2 + 20;
            }
        }
        y = Y * 2 + 26;
        Console.SetCursorPosition(x, y);
    } while (strelica.Key != ConsoleKey.Enter);
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
    PodesavanjePlugboard();
    char slovo;
    while (true)
    {
        slovo = UnosSlova();
    }

}
}
