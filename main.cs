using System;
using System.Threading;

class Program
{
    static char hor = '\u2500'; static char ver = '\u2502';
    static char gLevi = '\u250C'; static char gDesni = '\u2510';
    static char dLevi = '\u2514'; static char dDesni = '\u2518';
    static char levi = '\u251C'; static char desni = '\u2524';

    static char[] prviRed = { 'Q', 'W', 'E', 'R', 'T', 'Z', 'U', 'I', 'O' };
    static char[] drugiRed = { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K' };
    static char[] treciRed = { 'P', 'Y', 'X', 'C', 'V', 'B', 'N', 'M', 'L' };

    static char[] abeceda = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
    static int X = 2, Y = 0;

    static int[,] rotori =
    {{ 4, 10, 12, 5, 11, 6, 3, 16, 21, 25, 13, 19, 14, 22, 24, 7, 23, 20, 18, 15, 0, 8, 1, 17, 2, 9, /*zasek*/16},
        { 0, 9, 3, 10, 18, 8, 17, 20, 23, 1, 11, 7, 22, 19, 12, 2, 16, 6, 25, 13, 15, 24, 5, 21, 14, 4, /*zasek*/4},
        { 1, 3, 5, 7, 9, 11, 2, 15, 17, 19, 23, 21, 25, 13, 24, 4, 8, 22, 6, 0, 10, 12, 20, 18, 16, 14, /*zasek*/21},
        { 4, 18, 14, 21, 15, 25, 9, 0, 24, 16, 20, 8, 17, 7, 23, 11, 13, 5, 19, 6, 10, 3, 2, 12, 22, 1, /*zasek*/9},
        { 21, 25, 1, 17, 6, 8, 19, 24, 20, 15, 18, 3, 13, 7, 11, 23, 0, 22, 12, 9, 16, 14, 5, 4, 2, 10, /*zasek*/25}};
    static int[] prviReflektor = { 'Y', 'R', 'U', 'H', 'Q', 'S', 'L', 'D', 'P', 'X', 'N', 'G', 'O', 'K', 'M', 'I', 'E', 'B', 'F', 'Z', 'C', 'W', 'V', 'J', 'A', 'T' };
    static char[] drugiReflektor = { 'F', 'V', 'P', 'J', 'I', 'A', 'O', 'Y', 'E', 'D', 'R', 'Z', 'X', 'W', 'G', 'C', 'T', 'K', 'U', 'Q', 'S', 'B', 'N', 'M', 'H', 'L' };

    static int rotor1 = 0;
    static int rotor2 = 0;
    static int rotor3 = 0;

    static int[] pozicijeRotora = {1,2,3};
    static void crtajKvadratSaBrojem(int xPozicija, int yPozicija, int broj)
    {
        Console.SetCursorPosition(xPozicija, yPozicija);
        Console.Write("" + gLevi + hor + hor + hor + "" + gDesni);

        Console.SetCursorPosition(xPozicija, yPozicija + 1);
        Console.Write("" + ver + " " + broj + " " + ver);

        Console.SetCursorPosition(xPozicija, yPozicija + 2);
        Console.Write("" + dLevi + hor + hor + hor + dDesni + "  ");
    }
  //REFLEKTOR
    static void PodesiReflektor(bool jesteGore, ref int reflektor)
    {
        if (jesteGore) reflektor++;
        else reflektor--;
        if (reflektor == 3) reflektor = 1;
        else if (reflektor == 0) reflektor = 2;
        Console.Write(reflektor);
    }
    static void PodesavanjeReflektora()
    {
        int reflektor = 1;
        Console.SetCursorPosition(14, 9);
        ConsoleKeyInfo strelica;
        do
        {
            strelica = Console.ReadKey();
            if (strelica.Key == ConsoleKey.UpArrow)
            {
                PodesiReflektor(true, ref reflektor);
            }
            else if (strelica.Key == ConsoleKey.DownArrow)
            {
                PodesiReflektor(false, ref reflektor);
            }
            Console.SetCursorPosition(14, 9);
        } while (strelica.Key != ConsoleKey.Enter);
    }
    static void CrtanjeReflektora(int yPozicija)
    {
        crtajKvadratSaBrojem(12, yPozicija, 1);
    }
  //PODESAVANJA REDOSLEDNIH POZICIJA ROTORA
    static void PodesiPoziciju(bool jesteGore, int xPozicija, ref int pozicijaRotora)
    {
        if (jesteGore) pozicijaRotora++;
        else pozicijaRotora--;
        if (pozicijaRotora == 6) pozicijaRotora = 1;
        else if (pozicijaRotora == 0) pozicijaRotora = 5;
        Console.Write(pozicijaRotora);
    }
    static int[,] PodesavanjePozicija()
    {
        int x = X * 8 + 22;
        int y = 3;

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
                    PodesiPoziciju(true, x, ref pozicijeRotora[2]);
                }
                else if (x == 30)
                {
                    PodesiPoziciju(true, x, ref pozicijeRotora[1]);
                }
                else
                {
                    PodesiPoziciju(true, x, ref pozicijeRotora[0]);
                }
            }
            else if (strelica.Key == ConsoleKey.DownArrow)
            {
                if (x == 22)
                {
                    PodesiPoziciju(false, x, ref pozicijeRotora[2]);
                }
                else if (x == 30)
                {
                    PodesiPoziciju(false, x, ref pozicijeRotora[1]);
                }
                else
                {
                    PodesiPoziciju(false, x, ref pozicijeRotora[0]);
                }
            }
            x = X * 8 + 22;
            Console.SetCursorPosition(x, y);
        } while (strelica.Key != ConsoleKey.Enter);
      return UpotrebljeniRotori(pozicijeRotora);
    }
    static void PozicijeRotora(int yPozicija)
    {
        //biranje prvog rotora
        crtajKvadratSaBrojem(36, yPozicija, pozicijeRotora[0]);

        //biranje drugog rotora
        crtajKvadratSaBrojem(28, yPozicija, pozicijeRotora[1]);

        //biranje treceg rotora
        crtajKvadratSaBrojem(20, yPozicija, pozicijeRotora[2]);

    }
  //BIRANJE POCETNIH VREDNOSTI ZA ROTORE
    static void CrtajRotor(int xPozicija, int yPozicija, int rotor)
    {
        Console.SetCursorPosition(xPozicija, yPozicija);
        Console.Write("" + gLevi + hor + hor + hor + gDesni);

        Console.SetCursorPosition(xPozicija, yPozicija + 1);
        Console.Write("" + ver + " " + abeceda[rotor + 1] + " " + ver);

        Console.SetCursorPosition(xPozicija, yPozicija + 2);
        Console.Write("" + levi + hor + hor + hor + desni);

        Console.SetCursorPosition(xPozicija, yPozicija + 3);
        Console.Write("" + ver + "   " + ver);

        Console.SetCursorPosition(xPozicija, yPozicija + 4);
        Console.Write("" + ver + " " + abeceda[rotor] + " " + ver);

        Console.SetCursorPosition(xPozicija, yPozicija + 5);
        Console.Write("" + ver + "   " + ver);

        Console.SetCursorPosition(xPozicija, yPozicija + 6);
        Console.Write("" + levi + hor + hor + hor + desni);

        Console.SetCursorPosition(xPozicija, yPozicija + 7);
        Console.Write("" + ver + " " + abeceda[25] + " " + ver);

        Console.SetCursorPosition(xPozicija, yPozicija + 8);
        Console.Write("" + dLevi + hor + hor + hor + dDesni);
    }
    static void CrtanjeRotora(int yPozicija)
    {
        //prvi rotor
        CrtajRotor(36, yPozicija, rotor1);

        //drugi rotor
        CrtajRotor(28, yPozicija, rotor2);

        //treci rotor
        CrtajRotor(20, yPozicija, rotor3);

    }
    static void PodesiRotor(bool jesteGore, int xPozicija, ref int rotor)
    {
        if (jesteGore) rotor--;
        else rotor++;
        if (rotor == -26) rotor = 0;
        Console.Write(abeceda[(rotor + 26) % 26]);
        Console.SetCursorPosition(xPozicija, 6);
        Console.Write(abeceda[(rotor + 27) % 26]);
        Console.SetCursorPosition(xPozicija, 12);
        Console.Write(abeceda[(rotor + 25) % 26]);
    }
    static void PodesavanjeRotora()
    {
        int x = X * 8 + 22;
        int y = 9;

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
                    PodesiRotor(true, x, ref rotor3);
                }
                else if (x == 30)
                {
                    PodesiRotor(true, x, ref rotor2);
                }
                else
                {
                    PodesiRotor(true, x, ref rotor1);
                }
            }
            else if (strelica.Key == ConsoleKey.DownArrow)
            {
                if (x == 22)
                {
                    PodesiRotor(false, x, ref rotor3);
                }
                else if (x == 30)
                {
                    PodesiRotor(false, x, ref rotor2);
                }
                else
                {
                    PodesiRotor(false, x, ref rotor1);
                }
            }
            x = X * 8 + 22;
            Console.SetCursorPosition(x, y);
        } while (strelica.Key != ConsoleKey.Enter);     
    }
  //SVETLECA TASTATURA
    static void Tastatura(int yPosition)
    {
        char hor = '\u2500', ver = '\u2502';
        char gLevi = '\u250C', gDesni = '\u2510';
        char dLevi = '\u2514', dDesni = '\u2518';
        char gornji = '\u252C', donji = '\u2534';

        //prvi red

        Console.SetCursorPosition(10, yPosition);
        Console.Write("" + gLevi + hor);
        for (int i = 0; i < 8; i++)
        {
            Console.Write("" + hor + hor + gornji + hor);
        }
        Console.Write("" + hor + hor + gDesni);

        Console.SetCursorPosition(10, yPosition + 1);
        for (int i = 0; i < 9; i++)
        {
            Console.Write("" + ver + " " + prviRed[i] + " ");
        }
        Console.Write(ver);

        Console.SetCursorPosition(10, yPosition + 2);
        Console.Write("" + dLevi + hor);
        for (int i = 0; i < 8; i++)
        {
            Console.Write("" + hor + hor + donji + hor);
        }
        Console.Write("" + hor + hor + dDesni);

        //drugi red

        Console.SetCursorPosition(12, yPosition + 3);
        Console.Write("" + gLevi + hor);
        for (int i = 0; i < 7; i++)
        {
            Console.Write("" + hor + hor + gornji + hor);
        }
        Console.Write("" + hor + hor + gDesni);

        Console.SetCursorPosition(12, yPosition + 4);
        for (int i = 0; i < 8; i++)
        {
            Console.Write("" + ver + " " + drugiRed[i] + " ");
        }
        Console.Write(ver);

        Console.SetCursorPosition(12, yPosition + 5);
        Console.Write("" + dLevi + hor);
        for (int i = 0; i < 7; i++)
        {
            Console.Write("" + hor + hor + donji + hor);
        }
        Console.Write("" + hor + hor + dDesni);

        //treci red

        Console.SetCursorPosition(10, yPosition + 6);
        Console.Write("" + gLevi + hor);
        for (int i = 0; i < 8; i++)
        {
            Console.Write("" + hor + hor + gornji + hor);
        }
        Console.Write("" + hor + hor + gDesni);

        Console.SetCursorPosition(10, yPosition + 7);
        for (int i = 0; i < 9; i++)
        {
            Console.Write("" + ver + " " + treciRed[i] + " ");
        }
        Console.Write(ver);

        Console.SetCursorPosition(10, yPosition + 8);
        Console.Write("" + dLevi + hor);
        for (int i = 0; i < 8; i++)
        {
            Console.Write("" + hor + hor + donji + hor);
        }
        Console.Write("" + hor + hor + dDesni);
    }static void Svetla(int yPosition, int broj)
        {
            char slovo = abeceda[broj];
            for (int i = 0; i < 9; i++)
            {
                if (slovo == prviRed[i])
                {
                    Console.SetCursorPosition(11 + (i * 4), yPosition + 1);
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" " + slovo + " ");
                    Thread.Sleep(100);
                    Console.SetCursorPosition(11 + (i * 4), yPosition + 1);
                    Console.BackgroundColor = default;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + slovo + " ");
                }
                else if (i < 8 && slovo == drugiRed[i])
                {
                    Console.SetCursorPosition(13 + (i * 4), yPosition + 4);
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" " + slovo + " ");
                    Thread.Sleep(100);
                    Console.SetCursorPosition(13 + (i * 4), yPosition + 4);
                    Console.BackgroundColor = default;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + slovo + " ");
                }
                else if (slovo == treciRed[i])
                {
                    Console.SetCursorPosition(11 + (i * 4), yPosition + 7);
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(" " + slovo + " ");
                    Thread.Sleep(100);
                    Console.SetCursorPosition(11 + (i * 4), yPosition + 7);
                    Console.BackgroundColor = default;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + slovo + " ");
                }
            }
        }
    static void Plugboard(int yPosition)
    {
        char krug = '\u2B24';
        //prvi red

        for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
        {
            Console.SetCursorPosition(20 + j, yPosition);
            Console.Write("" + prviRed[i]);
        }

        for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
        {
            Console.SetCursorPosition(20 + j, yPosition + 1);
            Console.Write("" + krug);
        }

        //drugi red

        for (int i = 0, j = 0; i < 8 && j < 16; i++, j += 2)
        {
            Console.SetCursorPosition(21 + j, yPosition + 2);
            Console.Write("" + drugiRed[i]);
        }

        for (int i = 0, j = 0; i < 8 && j < 16; i++, j += 2)
        {
            Console.SetCursorPosition(21 + j, yPosition + 3);
            Console.Write("" + krug);
        }

        //treci red

        for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
        {
            Console.SetCursorPosition(20 + j, yPosition + 4);
            Console.Write("" + treciRed[i]);
        }

        for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
        {
            Console.SetCursorPosition(20 + j, yPosition + 5);
            Console.Write("" + krug);
        }
    }
    static char[] PodesavanjePlugboard()
    {
        ConsoleColor[] nizboja = { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.DarkBlue, ConsoleColor.Cyan, ConsoleColor.DarkGreen, ConsoleColor.Magenta, ConsoleColor.DarkRed, ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow, ConsoleColor.DarkCyan, ConsoleColor.DarkGray };

        char[] plugboard = abeceda;
        char slovo;
        ConsoleKeyInfo taster;

        int brBoje = 0;
        int brojac = 1;

        char[] slova = abeceda;
        int[] xAbeceda = { 21, 30, 26, 25, 24, 27, 29, 31, 34, 33, 35, 36, 34, 32, 36, 20, 20, 26, 23, 28, 32, 28, 22, 24, 22, 30 };
        int[] yAbeceda = { 28, 30, 30, 28, 26, 28, 28, 28, 26, 28, 28, 30, 30, 30, 26, 30, 26, 26, 28, 26, 26, 30, 26, 30, 30, 26 };
        int index = 0;
        string pom = new string(slova);
        Console.SetCursorPosition(0, 32);
      char prethodni;
        do
        {
            Console.SetCursorPosition(0, 32);
            //moram proveru da napisem
            taster = Console.ReadKey();
            slovo = Convert.ToChar(taster.KeyChar);
            slovo = Char.ToUpper(slovo);
            index = pom.IndexOf(slovo);
            Console.SetCursorPosition(xAbeceda[index], yAbeceda[index]);
            Console.ForegroundColor = nizboja[brBoje];
            Console.Write('\u2B24');
            prethodni = slovo;
            if(brojac%2 ==0 )
            {
              slova[pom.IndexOf(prethodni)] = slovo;
              slova[pom.IndexOf(slovo)] = prethodni;
            }
          
            Console.ForegroundColor = ConsoleColor.Black;
            
            if (brojac % 2 == 0)
            {
              brBoje++;
              
            }   

            brojac++;
            //zavrsi se program kad dodje do kraja niza boja
            /* 1. slova svetle kada se unese slovo ZAVRSENO
                1.1 provera ispravnosti unosa i pretvaranje u velika slova
                1.2 kada se pritisne opet slovo koje vec ima boju iskljuce se oba
              2. ako je neka promenljiva = 2 menjaju mesta slovo i prethodno slovo
                2.1 kada se pritisne opet slovo koje vec ima boju zamene mesta na pocetna*/

        } while (brojac <= 26);
        return plugboard;
    }
    static char UnosSlova()
    {

        char slovo;
        ConsoleKeyInfo slovo1;
        slovo1 = Console.ReadKey();
        if (slovo1.Key == ConsoleKey.Enter)
        {
            return '.';
            // kada unese enter je kraj Unosa
        }
        slovo = Convert.ToChar(slovo1.KeyChar);
        if (slovo < 'A' || slovo > 'Z')
        {
            slovo = '-';
            // kada se bude unelo neispravno slovo vratice se '-' koji ce pri obradi biti zaobidjen
        }
        return slovo;
    }
    static int[,] UpotrebljeniRotori(int[] rotor)
    {
      int[,] trenutniRotori = new int[3,27];
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 27; j++)
                trenutniRotori[i, j] = rotori[rotor[i], j];
        return trenutniRotori;
    }
    static void Ispis(char slovo)
    {
        //mare
    }
    static void Main(string[] args)
    {
        PozicijeRotora(2);
        CrtanjeReflektora(8);
        CrtanjeRotora(5);
        Tastatura(15);
        Svetla(15, 5);
        Plugboard(25);
        PodesavanjeReflektora();
        PodesavanjePozicija();
        PodesavanjeRotora();
        PodesavanjePlugboard();
    }
}