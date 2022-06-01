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
    static int X = 2;
    static int[] plugboard = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
    static bool[] Ukljuceno = new bool[26];
    static int[] bojaAbc = PopuniNizBrojem(26, -1);
    static int[,] rotori =
    {{ 4, 10, 12, 5, 11, 6, 3, 16, 21, 25, 13, 19, 14, 22, 24, 7, 23, 20, 18, 15, 0, 8, 1, 17, 2, 9, /*zasek*/16},
        { 0, 9, 3, 10, 18, 8, 17, 20, 23, 1, 11, 7, 22, 19, 12, 2, 16, 6, 25, 13, 15, 24, 5, 21, 14, 4, /*zasek*/4},
        { 1, 3, 5, 7, 9, 11, 2, 15, 17, 19, 23, 21, 25, 13, 24, 4, 8, 22, 6, 0, 10, 12, 20, 18, 16, 14, /*zasek*/21},
        { 4, 18, 14, 21, 15, 25, 9, 0, 24, 16, 20, 8, 17, 7, 23, 11, 13, 5, 19, 6, 10, 3, 2, 12, 22, 1, /*zasek*/9},
        { 21, 25, 1, 17, 6, 8, 19, 24, 20, 15, 18, 3, 13, 7, 11, 23, 0, 22, 12, 9, 16, 14, 5, 4, 2, 10, /*zasek*/25}};
    static int[,] reflektori = { { 24, 17, 20, 7, 16, 18, 11, 3, 15, 23, 13, 6, 14, 10, 12, 8, 4, 1, 5, 25, 2, 22, 21, 9, 0, 19}
                                    ,{5, 21, 15, 9, 8, 0, 14, 24, 4, 3, 17, 25, 23, 22, 6, 2, 19, 10, 20, 16, 18, 1, 13, 12, 7, 11}};
    static int reflektor = 1;
    static int[] pomeraj = { 0, 0, 0, 0, 0 };
    static int[] pozicijeRotora = { 1, 2, 3 };
    static void Informacije(int yPozicija)
    {
        Console.SetCursorPosition(23, yPozicija);
        Console.WriteLine("ENIGMA MASINA M3");
    }
    static void crtajKvadratSaBrojem(int xPozicija, int yPozicija, int broj)
    {
        Console.SetCursorPosition(xPozicija, yPozicija);
        Console.Write("" + gLevi + hor + hor + hor + "" + gDesni);

        Console.SetCursorPosition(xPozicija, yPozicija + 1);
        Console.Write("" + ver + " " + broj + " " + ver);

        Console.SetCursorPosition(xPozicija, yPozicija + 2);
        Console.Write("" + dLevi + hor + hor + hor + dDesni);
    }
    private static int[] PopuniNizBrojem(int duzina, int cifra)
    {
        int[] a = new int[duzina];
        for (int i = 0; i < 26; i++)
            a[i] = cifra;
        return a;
    }
    //REFLEKTOR
    static void PodesiReflektor(bool jesteGore)
    {
        if (jesteGore) reflektor++;
        else reflektor--;
        if (reflektor == 3) reflektor = 1;
        else if (reflektor == 0) reflektor = 2;
        Console.Write(reflektor);
    }
    static ConsoleKey PodesavanjeReflektora(int[,] postavke)
    {
        Console.SetCursorPosition(14, 12);
        ConsoleKeyInfo strelica;
        do
        {
            strelica = Console.ReadKey();
            if (strelica.Key == ConsoleKey.Escape)
            {
                return ConsoleKey.Escape;
            }
            if (strelica.Key == ConsoleKey.UpArrow)
            {
                PodesiReflektor(true);
            }
            else if (strelica.Key == ConsoleKey.DownArrow)
            {
                PodesiReflektor(false);
            }
            Console.SetCursorPosition(14, 12);
        } while (strelica.Key != ConsoleKey.Enter);
        PodesavanjePostavki(postavke, 1);
        return ConsoleKey.Enter;
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
    static ConsoleKey PodesavanjePozicija(int[,] postavke)
    {
        int x = X * 8 + 22;
        int y = 6;

        Console.SetCursorPosition(x, y);
        ConsoleKeyInfo strelica;
        do
        {
            strelica = Console.ReadKey();
            if (strelica.Key == ConsoleKey.Escape)
            {
                return ConsoleKey.Escape;
            }
            else if (strelica.Key == ConsoleKey.RightArrow)
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
        PodesavanjePostavki(postavke, 0);
        return ConsoleKey.Enter;
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
        CrtajRotor(36, yPozicija, pomeraj[1]);

        //drugi rotor
        CrtajRotor(28, yPozicija, pomeraj[2]);

        //treci rotor
        CrtajRotor(20, yPozicija, pomeraj[3]);

    }
    static void PodesiRotor(bool jesteGore, int xPozicija, ref int rotor)
    {
        if (jesteGore) rotor--;
        else rotor++;
        if (rotor == -26) rotor = 0;
        Console.Write(abeceda[(rotor + 26) % 26]);
        Console.SetCursorPosition(xPozicija, 9);
        Console.Write(abeceda[(rotor + 27) % 26]);
        Console.SetCursorPosition(xPozicija, 15);
        Console.Write(abeceda[(rotor + 25) % 26]);
    }
    static ConsoleKey PodesavanjeRotora()
    {
        int x = X * 8 + 22;
        int y = 12;

        Console.SetCursorPosition(x, y);
        ConsoleKeyInfo strelica;
        do
        {
            strelica = Console.ReadKey();
            if (strelica.Key == ConsoleKey.Escape)
            {
                return ConsoleKey.Escape;
            }
            else  if (strelica.Key == ConsoleKey.RightArrow)
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
                    PodesiRotor(true, x, ref pomeraj[3]);
                }
                else if (x == 30)
                {
                    PodesiRotor(true, x, ref pomeraj[2]);
                }
                else
                {
                    PodesiRotor(true, x, ref pomeraj[1]);
                }
            }
            else if (strelica.Key == ConsoleKey.DownArrow)
            {
                if (x == 22)
                {
                    PodesiRotor(false, x, ref pomeraj[3]);
                }
                else if (x == 30)
                {
                    PodesiRotor(false, x, ref pomeraj[2]);
                }
                else
                {
                    PodesiRotor(false, x, ref pomeraj[1]);
                }
            }
            x = X * 8 + 22;
            Console.SetCursorPosition(x, y);
        } while (strelica.Key != ConsoleKey.Enter);
        return ConsoleKey.Enter;
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
    }
    static void Svetla(int yPosition, char slovo)
    {
        slovo = char.ToUpper(slovo);
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
                Console.BackgroundColor = ConsoleColor.Black;
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
                Console.BackgroundColor = ConsoleColor.Black;
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
                Console.BackgroundColor = ConsoleColor.Black;
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

    //PODESAVANJE PLUGBOARDA  
    static ConsoleKey PodesavanjePlugboard(int[,] postavke)
    {
        ConsoleColor[] nizBoja = { ConsoleColor.Red, ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Green, ConsoleColor.DarkBlue, ConsoleColor.DarkBlue, ConsoleColor.Cyan, ConsoleColor.Cyan, ConsoleColor.DarkGreen, ConsoleColor.DarkGreen, ConsoleColor.Magenta, ConsoleColor.Magenta, ConsoleColor.DarkRed, ConsoleColor.DarkRed, ConsoleColor.DarkMagenta, ConsoleColor.DarkMagenta, ConsoleColor.DarkYellow, ConsoleColor.DarkYellow, ConsoleColor.DarkCyan, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGray };
        int[] xAbeceda = { 21, 30, 26, 25, 24, 27, 29, 31, 34, 33, 35, 36, 34, 32, 36, 20, 20, 26, 23, 28, 32, 28, 22, 24, 22, 30 };
        int[] yAbeceda = { 33, 35, 35, 33, 31, 33, 33, 33, 31, 33, 33, 35, 35, 35, 31, 35, 31, 31, 33, 31, 31, 35, 31, 35, 35, 31 };
        char slovo;
        ConsoleKeyInfo taster;
        do
        {
            Console.SetCursorPosition(0, 28);
            Console.ForegroundColor = ConsoleColor.Black;
            taster = Console.ReadKey();

            if (taster.Key == ConsoleKey.Escape)
            {
                return ConsoleKey.Escape;
            }
            if ((taster.KeyChar < 'A' || taster.KeyChar > 'Z') && (taster.KeyChar < 'a' || taster.KeyChar > 'z') || taster.Key == ConsoleKey.Enter )
            {
                continue;
            }
            slovo = Char.ToUpper(Convert.ToChar(taster.KeyChar));
            if (bojaAbc[slovo - 'A'] == -1)//SLUCAJ KADA JE KRUZIC ISPOD SLOVA NEOBOJEN
            {
                for (int i = 0; i < 26; i++)//TRAZI SE PRVA BOJA KOJOM BI SE KRUZIC MOGAO OBOJATI
                    if (!Ukljuceno[i])
                    {
                        bojaAbc[slovo - 'A'] = i;
                        Ukljuceno[i] = true;
                        Console.SetCursorPosition(xAbeceda[slovo - 'A'], yAbeceda[slovo - 'A']);
                        Console.ForegroundColor = nizBoja[i];
                        Console.Write('\u2B24');
                        if (i % 2 == 1)//UKOLIKO JE OVO DRUGI PUT DA SE KORISTI ISTA BOJA ZAMENJUJU SE VREDNOSTI
                        {
                            for (int j = 0; j < 26; j++)
                                if (bojaAbc[j] == i - 1)
                                {
                                    int pom = plugboard[slovo - 'A'];
                                    plugboard[slovo - 'A'] = plugboard[j];
                                    plugboard[j] = pom;
                                    break;
                                }
                        }
                        else if (Ukljuceno[i + 1])
                        {
                            for (int j = 0; j < 26; j++)
                                if (bojaAbc[j] == i + 1)
                                {
                                    int pom = plugboard[slovo - 'A'];
                                    plugboard[slovo - 'A'] = plugboard[j];
                                    plugboard[j] = pom;
                                    break;
                                }
                        }
                        break;
                    }
            }
            else if (bojaAbc[slovo - 'A'] != -1)
            {
                if (bojaAbc[slovo - 'A'] % 2 == 0)
                {
                    if (Ukljuceno[bojaAbc[slovo - 'A']] && Ukljuceno[bojaAbc[slovo - 'A'] + 1])
                    {
                        for (int j = 0; j < 26; j++)
                            if (bojaAbc[j] == bojaAbc[slovo - 'A'] + 1)
                            {
                                int pom = plugboard[slovo - 'A'];
                                plugboard[slovo - 'A'] = plugboard[j];
                                plugboard[j] = pom;
                                break;
                            }
                    }
                }
                else
                {
                    if (Ukljuceno[bojaAbc[slovo - 'A']] && Ukljuceno[bojaAbc[slovo - 'A'] - 1])
                    {
                        for (int j = 0; j < 26; j++)
                            if (bojaAbc[j] == bojaAbc[slovo - 'A'] - 1)
                            {
                                int pom = plugboard[slovo - 'A'];
                                plugboard[slovo - 'A'] = plugboard[j];
                                plugboard[j] = pom;
                                break;
                            }
                    }
                }
                Ukljuceno[bojaAbc[slovo - 'A']] = false;
                bojaAbc[slovo - 'A'] = -1;
                Console.SetCursorPosition(xAbeceda[slovo - 'A'], yAbeceda[slovo - 'A']);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write('\u2B24');
            }
        } while (taster.Key != ConsoleKey.Enter);
        Console.ForegroundColor = ConsoleColor.White;
        PodesavanjePostavki(postavke, 2);
        return ConsoleKey.Enter;
    }
    
    static int xUnos = 0, yUnos = 41;
    static char UnosSlova()
    {
        
        //razmaci  
        if (xUnos == 5 || xUnos == 11)
            xUnos++;
        //kraj reda  
        if (xUnos == 17)
        {
            yUnos++;
            xUnos = 0;
        }
        Console.SetCursorPosition(xUnos, yUnos);
        char slovo;
        ConsoleKeyInfo taster;
        taster = Console.ReadKey();
        if (taster.Key == ConsoleKey.Escape)
            return '/';
        //vratice se / sto oznacava kraj programa
        if (taster.KeyChar < 'A' || taster.KeyChar > 'Z' && taster.KeyChar < 'a' || taster.KeyChar > 'z')
        {
            if (taster.Key == ConsoleKey.Enter)
                // ako korisnik unese enter metoda ce vratiti '.' sto oznacava kraj unosa
                return '.';
            // ako korisnik unese nesto sto nije slovo metoda ce vratiti '-' sto ce se zanemariti pri sifrovanju i ispisu
            else
                return '-';
        }

        slovo = Convert.ToChar(taster.KeyChar);
        slovo = Char.ToUpper(slovo);
        xUnos++;
        return slovo;
    }
    static int[,] PodesavanjePostavki(int[,] postavke, int mod)
    {
        int[,] _trenutniRotori = new int[3, 27];
        if (mod == 0)//mod nula: namestanje rotora
            for (int i = 1; i < 4; i++)
                for (int j = 0; j < 27; j++)
                    postavke[i, j] = rotori[pozicijeRotora[i - 1] - 1, j];
        else if (mod == 1)//mod jedan: namestanje reflektora
            for (int i = 0; i < 26; i++)
                postavke[4, i] = reflektori[reflektor - 1, i];
        else //mod dva: namestanje plugboarda
            for (int i = 0; i < 26; i++)
                postavke[0, i] = plugboard[i];
        return _trenutniRotori;
    }
    static char Sifrovanje(int Slovo, int[,] Postavke)
    {
        bool pom = false;
        for (int i = 0; i >= 0; i += pom ? -1 : 1)
        {
            Slovo = Postavke[i, (Slovo + pomeraj[i]) % 26];
            if (i == Postavke.GetLength(0) - 1) pom = true;
        }
        return Convert.ToChar(Slovo + 'A');
    }
    static int xIspis = 30, yIspis = 41;
    static void Ispis(char slovo)
    {

        // razmaci
        if (xIspis == 35 || xIspis == 41)
        {
            xIspis++;
        }
        //kraj reda
        if (xIspis == 47)
        {
            yIspis++;
            xIspis = 30;
        }
        Console.SetCursorPosition(xIspis, yIspis);
        if (slovo == '-')
            Console.Write("");
        else
        {
            Console.Write(slovo);
            xIspis++;
        }
    }
    static void Main(string[] args)
    {

        int[,] postavke = new int[5, 27];
        Informacije(2);
        CrtanjeReflektora(11);
        CrtanjeRotora(8);
        PozicijeRotora(5);
        Tastatura(18);
        Plugboard(30);
        ConsoleKey taster;
        do
        {

            taster = PodesavanjeReflektora(postavke);
            if (taster == ConsoleKey.Escape)
                break;
            taster = PodesavanjePozicija(postavke);
            if (taster == ConsoleKey.Escape)
                break;
            taster = PodesavanjeRotora();
            if (taster == ConsoleKey.Escape)
                break;
            taster = PodesavanjePlugboard(postavke);
            if (taster == ConsoleKey.Escape)
                break;
            char slovo;
            Console.SetCursorPosition(0, 40);
            Console.Write("UNOS: ");
            Console.SetCursorPosition(30, 40);
            Console.Write("ISPIS: ");
            do
            {
                slovo = UnosSlova();
                if (slovo == '/')
                    goto kraj;
                if (slovo != '.')
                {
                    slovo = Sifrovanje(slovo, postavke);// slovo treba da se sifruje OVDE pa da se stavi u ispis i svetla
                    pomeraj[1] = ++pomeraj[1] % 26;
                    if (pomeraj[1] == postavke[2, 26])
                    {
                        pomeraj[2] = ++pomeraj[2] % 26;
                        if (pomeraj[3] == postavke[3, 26])
                            pomeraj[3] = ++pomeraj[3] % 26;
                    }
                    Svetla(18, slovo);
                    Ispis(slovo);
                }
            } while (slovo != '.');
        } while (true);
        kraj:;
    }
}