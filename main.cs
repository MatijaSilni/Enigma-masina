using System;

    class Program
    {
        static char hor = '\u2500'; static char ver = '\u2502';
        static char gLevi = '\u250C'; static char gDesni = '\u2510';
        static char dLevi = '\u2514'; static char dDesni = '\u2518';
        static char levi = '\u251C'; static char desni = '\u2524';

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

        static int rotor1 = 0;
        static int rotor2 = 0;
        static int rotor3 = 0;

        static int pozicijaRotora1 = 1;
        static int pozicijaRotora2 = 2;
        static int pozicijaRotora3 = 3;
        static void crtajKvadratSaBrojem( int xPozicija, int yPozicija, int broj )
	    	{
            Console.SetCursorPosition( xPozicija, yPozicija );
            Console.Write( "" + gLevi +  hor + hor  + hor  + "" + gDesni );

            Console.SetCursorPosition( xPozicija, yPozicija +1 );
            Console.Write( "" + ver + " " + broj + " " + ver  );

            Console.SetCursorPosition( xPozicija, yPozicija +2 );
            Console.Write( "" + dLevi + hor + hor + hor + dDesni + "  " );
        }
      static void PodesiReflektor( bool jesteGore, ref int reflektor )
        {
            if( jesteGore ) reflektor++;
            else reflektor--;
            if( reflektor == 3 ) reflektor = 1;
            else if( reflektor == 0 ) reflektor = 2;
            Console.Write( reflektor );
        }
        static void PodesavanjeReflektora()
		{
            int reflektor = 1;
            Console.SetCursorPosition( 14, 9 );
            ConsoleKeyInfo strelica;
            do
			{
                strelica = Console.ReadKey();
                if( strelica.Key == ConsoleKey.UpArrow )
                {
                    PodesiReflektor( true, ref reflektor );
                }
                else if( strelica.Key == ConsoleKey.DownArrow )
                {
                    PodesiReflektor( false, ref reflektor );
                }
                Console.SetCursorPosition( 14, 9 );
            } while( strelica.Key != ConsoleKey.Enter );
		}
        static void CrtanjeReflektora(int yPozicija)
		{
            crtajKvadratSaBrojem( 12, yPozicija, 1 );
		}
        static void PodesiPoziciju( bool jesteGore, int xPozicija, ref int pozicijaRotora)
		{
            if( jesteGore ) pozicijaRotora++;
            else pozicijaRotora--;
            if( pozicijaRotora == 6 ) pozicijaRotora = 1;
            else if( pozicijaRotora == 0 ) pozicijaRotora = 5;
            Console.Write( pozicijaRotora );
        }
        static void PodesavanjePozicija()
		{
            int x = X * 8 + 22;
            int y = 3;

            Console.SetCursorPosition( x, y );
            ConsoleKeyInfo strelica;
            do
            {
                strelica = Console.ReadKey();
                if( strelica.Key == ConsoleKey.RightArrow )
                {
                    if( x != 38 )
                    {
                        X++;
                    }
                }
                else if( strelica.Key == ConsoleKey.LeftArrow )
                {
                    if( x != 22 )
                        X--;
                }
                else if( strelica.Key == ConsoleKey.UpArrow )
                {
                    if( x == 22 )
                    {
                        PodesiPoziciju( true, x, ref pozicijaRotora3 );
                    }
                    else if( x == 30 )
                    {
                        PodesiPoziciju( true, x, ref pozicijaRotora2 );
                    }
                    else
                    {
                        PodesiPoziciju( true, x, ref pozicijaRotora1 );
                    }
                }
                else if( strelica.Key == ConsoleKey.DownArrow )
                {
                    if( x == 22 )
                    {
                        PodesiPoziciju( false, x, ref pozicijaRotora3 );
                    }
                    else if( x == 30 )
                    {
                        PodesiPoziciju( false, x, ref pozicijaRotora2 );
                    }
                    else
                    {
                        PodesiPoziciju( false, x, ref pozicijaRotora1 );
                    }
                }
                x = X * 8 + 22;
                Console.SetCursorPosition( x, y );
            } while( strelica.Key != ConsoleKey.Enter );
        }
        static void PozicijeRotora( int yPozicija )

	    {
            int[] rotori = { 1, 2, 3, 4, 5 };
            //biranje prvog rotora
            crtajKvadratSaBrojem( 36, yPozicija, rotori[ 0 ] );

            //biranje drugog rotora
            crtajKvadratSaBrojem( 28, yPozicija, rotori[ 1 ] );
            
            //biranje treceg rotora
            crtajKvadratSaBrojem( 20, yPozicija, rotori[ 2 ] );
            
        }
        static void CrtajRotor( int xPozicija,  int yPozicija, int rotor )
        {
            Console.SetCursorPosition( xPozicija, yPozicija );
            Console.Write( "" + gLevi + hor + hor + hor + gDesni );

            Console.SetCursorPosition( xPozicija, yPozicija +1 );
            Console.Write( "" + ver + " " + abeceda[ rotor + 1 ] + " " + ver  );

            Console.SetCursorPosition( xPozicija, yPozicija +2 );
            Console.Write( "" + levi + hor + hor + hor + desni  );

            Console.SetCursorPosition( xPozicija, yPozicija +3 );
            Console.Write( "" + ver + "   " + ver );

            Console.SetCursorPosition( xPozicija, yPozicija +4 );
            Console.Write( "" + ver + " " + abeceda[ rotor ] + " " + ver  );

            Console.SetCursorPosition( xPozicija, yPozicija +5 );
            Console.Write( "" + ver + "   " + ver  );

            Console.SetCursorPosition( xPozicija, yPozicija +6 );
            Console.Write( "" + levi + hor + hor + hor + desni );

            Console.SetCursorPosition( xPozicija, yPozicija +7 );
            Console.Write( "" + ver + " " + abeceda[ 25 ] + " " + ver );

            Console.SetCursorPosition( xPozicija, yPozicija+8 );
            Console.Write( "" + dLevi + hor + hor + hor + dDesni );
        }
        static void CrtanjeRotora ( int yPosition)
        {
            //prvi rotor
            CrtajRotor( 36, yPosition, rotor1 );
        
            //drugi rotor
            CrtajRotor( 28, yPosition, rotor2 );

            //treci rotor
            CrtajRotor( 20, yPosition, rotor3 );
                 
        }
        static void PodesiRotor(bool jesteGore, int xPozicija, ref int rotor)
		{
            if( jesteGore ) rotor--;
            else rotor++;
            if( rotor == -26 ) rotor = 0;
            Console.Write( abeceda[( rotor + 26 ) % 26 ]);
            Console.SetCursorPosition( xPozicija, 6 );
            Console.Write( abeceda[ ( rotor + 27 ) % 26 ] );
            Console.SetCursorPosition( xPozicija, 12 );
            Console.Write( abeceda[ ( rotor + 25 ) % 26 ] );
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
                        PodesiRotor( true, x , ref rotor3);
                    }
                    else if (x == 30)
                    {
                        PodesiRotor( true, x, ref rotor2 );
                    }
                    else
                    {
                        PodesiRotor( true, x, ref rotor1 );
                    }
                }
                else if(strelica.Key == ConsoleKey.DownArrow)
                {
                    if (x == 22)
                    {
                        PodesiRotor( false, x , ref rotor3);
                    }
                    else if (x == 30)
                    {
                       PodesiRotor( false, x , ref rotor2);
                    }
                    else
                    {
                        PodesiRotor( false, x , ref rotor1);
                    }
                }
                x = X * 8 + 22;
                Console.SetCursorPosition(x, y);
            } while (strelica.Key != ConsoleKey.Enter);
  }
static void Tastatura( int yPosition)
{
    char hor = '\u2500', ver = '\u2502';
    char gLevi = '\u250C', gDesni = '\u2510';
    char dLevi = '\u2514', dDesni = '\u2518';
    char gornji = '\u252C', donji = '\u2534';

    //prvi red

    Console.SetCursorPosition(10, yPosition );
    Console.Write("" + gLevi + hor);
    for (int i = 0; i < 8; i++)
    {
        Console.Write("" + hor + hor + gornji + hor);
    }
    Console.Write("" + hor + hor + gDesni);
           
            Console.SetCursorPosition(10, yPosition +1);
    for (int i = 0; i < 9; i++)
    {
        Console.Write("" + ver + " " + prviRed[i] + " ");
    }
    Console.Write(ver);

    Console.SetCursorPosition(10, yPosition+2);
    Console.Write("" + dLevi + hor);
    for (int i = 0; i < 8; i++)
    {
        Console.Write("" + hor + hor + donji + hor);
    }
    Console.Write("" + hor + hor + dDesni);

    //drugi red

    Console.SetCursorPosition(12, yPosition +3);
    Console.Write("" + gLevi + hor);
    for (int i = 0; i < 7; i++)
    {
        Console.Write("" + hor + hor + gornji + hor);
    }
    Console.Write("" + hor + hor + gDesni);

    Console.SetCursorPosition(12, yPosition +4);
    for (int i = 0; i < 8; i++)
    {
        Console.Write("" + ver + " " + drugiRed[i] + " ");
    }
    Console.Write(ver);

    Console.SetCursorPosition(12, yPosition +5);
    Console.Write("" + dLevi + hor);
    for (int i = 0; i < 7; i++)
    {
        Console.Write("" + hor + hor + donji + hor);
    }
    Console.Write("" + hor + hor + dDesni);

    //treci red

    Console.SetCursorPosition(10, yPosition +6);
    Console.Write("" + gLevi + hor);
    for (int i = 0; i < 8; i++)
    {
        Console.Write("" + hor + hor + gornji + hor);
    }
    Console.Write("" + hor + hor + gDesni);

    Console.SetCursorPosition(10, yPosition +7);
    for (int i = 0; i < 9; i++)
    {
        Console.Write("" + ver + " " + treciRed[i] + " ");
    }
    Console.Write(ver);

    Console.SetCursorPosition(10, yPosition +8);
    Console.Write("" + dLevi + hor);
    for (int i = 0; i < 8; i++)
    {
        Console.Write("" + hor + hor + donji + hor);
    }
    Console.Write("" + hor + hor + dDesni);
}
static void Plugboard( int yPosition )
{
    char krug = '\u2B24';
    //prvi red

    for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
    {
        Console.SetCursorPosition(20 + j, yPosition );
        Console.Write("" + prviRed[i]);
    }

    for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
    {
        Console.SetCursorPosition(20 + j, yPosition +1);
        Console.Write("" + krug);
    }

    //drugi red

    for (int i = 0, j = 0; i < 8 && j < 16; i++, j += 2)
    {
        Console.SetCursorPosition(21 + j, yPosition +2);
        Console.Write("" + drugiRed[i]);
    }

    for (int i = 0, j = 0; i < 8 && j < 16; i++, j += 2)
    {
        Console.SetCursorPosition(21 + j, yPosition +3);
        Console.Write("" + krug);
    }

    //treci red

    for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
    {
        Console.SetCursorPosition(20 + j, yPosition +4);
        Console.Write("" + treciRed[i]);
    }

    for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
    {
        Console.SetCursorPosition(20 + j, yPosition +5);
        Console.Write("" + krug);
    }
}
static char[] PodesavanjePlugboard()
{
    ConsoleColor[] nizboja =     {ConsoleColor.Red,ConsoleColor.Yellow,ConsoleColor.Blue,ConsoleColor.Green,ConsoleColor.DarkBlue,ConsoleColor.Cyan,ConsoleColor.DarkGreen,ConsoleColor.Magenta,ConsoleColor.DarkRed,ConsoleColor.DarkMagenta,ConsoleColor.DarkYellow,ConsoleColor.DarkCyan,ConsoleColor.DarkGray};
  
    char[] plugboard = abeceda;
    char slovo;
    ConsoleKeyInfo taster;

    int brBoje = 0;
    int brojac = 1;
  
    char [] slova= abeceda;
    int [] xAbeceda = {21, 30, 26, 25, 24, 27, 29, 31, 34, 33, 35, 36, 34, 32, 36, 20, 20, 26, 23, 28, 32, 28, 22, 24, 22, 30};
  int [] yAbeceda = {28,30,30,28,26,28,28,28,26,28,28,30,30,30,26,30,26,26,28,26,26,30,26,30,30,26};
  int index= 0;
  bool uspesno;
  string pom = new string (slova);
  Console.SetCursorPosition(0,32);
    do
    {
      uspesno = false;
      Console.SetCursorPosition(0,32);
      //moram proveru da napisem
      taster = Console.ReadKey();
      slovo = Convert.ToChar(taster.KeyChar);
      Char.ToUpper(slovo);
      index = pom.IndexOf(slovo);
      Console.SetCursorPosition(xAbeceda[index], yAbeceda[index]);
      
      Console.ForegroundColor = nizboja[brBoje];
      Console.Write('\u2B24');
      Console.ForegroundColor = ConsoleColor.Black;
      if(brojac%2 == 0)
        brBoje++;
     
       brojac++;
      //zavrsi se program kad dodje do kraja niza boja
        /* 1. slova svetle kada se unese slovo ZAVRSENO
              1.1 provera ispravnosti unosa i pretvaranje u velika slova
              1.2 kada se pritisne opet slovo koje vec ima boju iskljuce se oba
            2. ako je neka promenljiva = 2 menjaju mesta slovo i prethodno slovo
              2.1 kada se pritisne opet slovo koje vec ima boju zamene mesta na pocetna*/
      
    }while(brojac<=26);
    return plugboard;
}
static char UnosSlova()
{
  
  char slovo;
  ConsoleKeyInfo slovo1;
  slovo1 = Console.ReadKey();
  if(slovo1.Key == ConsoleKey.Enter)
  {
    return '.';
    // kada unese enter je kraj Unosa
  }
  slovo = Convert.ToChar(slovo1.KeyChar);
  if(slovo <'A'||slovo>'Z')
  {
    slovo = '-';
    // kada se bude unelo neispravno slovo vratice se '-' koji ce pri obradi biti zaobidjen
  }
  return slovo;
  
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
            Plugboard(25);
            PodesavanjeReflektora();
            PodesavanjePozicija();
            PodesavanjeRotora();
            PodesavanjePlugboard();
      
   }
}
