using System;

class Program 
{
  static void Prikaz()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            char[] prviRed = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P' };
            char[] drugiRed = { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L' };
            char[] treciRed = { 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };
            char hor = '\u2500', ver = '\u2502';
            char gLevi = '\u250C', gDesni = '\u2510';
            char dLevi = '\u2514', dDesni = '\u2518';
            char gornji = '\u252C', donji = '\u2534';

            //prvi red
            Console.SetCursorPosition(10, 5);
            Console.Write("" + gLevi + hor);
            for (int i = 0; i < 9; i++)
            {
                Console.Write("" + hor + hor + gornji + hor);
            }
            Console.Write("" + hor + hor + gDesni);

            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("" + ver + " " + prviRed[i] + " ");
            }
            Console.Write(ver);

            Console.SetCursorPosition(10, 7);
            Console.Write("" + dLevi + hor);
            for (int i = 0; i < 9; i++)
            {
                Console.Write("" + hor + hor + donji + hor);
            }
            Console.Write("" + hor + hor + dDesni);


            //drugi red

            Console.SetCursorPosition(12, 8);
            Console.Write("" + gLevi + hor);
            for (int i = 0; i < 8; i++)
            {
                Console.Write("" + hor + hor + gornji + hor);
            }
            Console.Write("" + hor + hor + gDesni);

            Console.SetCursorPosition(12, 9);
            for (int i = 0; i < 9; i++)
            {
                Console.Write("" + ver + " " + drugiRed[i] + " ");
            }
            Console.Write(ver);

            Console.SetCursorPosition(12, 10);
            Console.Write("" + dLevi + hor);
            for (int i = 0; i < 8; i++)
            {
                Console.Write("" + hor + hor + donji + hor);
            }
            Console.Write("" + hor + hor + dDesni);

            //treci red

            Console.SetCursorPosition(16, 11);
            Console.Write("" + gLevi + hor);
            for (int i = 0; i < 6; i++)
            {
                Console.Write("" + hor + hor + gornji + hor);
            }
            Console.Write("" + hor + hor + gDesni);


            Console.SetCursorPosition(16, 12);
            for (int i = 0; i < 7; i++)
            {
                Console.Write("" + ver + " " + treciRed[i] + " ");
            }
            Console.Write(ver);

            Console.SetCursorPosition(16, 13);
            Console.Write("" + dLevi + hor);
            for (int i = 0; i < 6; i++)
            {
                Console.Write("" + hor + hor + donji + hor);
            }
            Console.Write("" + hor + hor + dDesni);

        }
  public static void Main (string[] args) 
  {
    Prikaz();
  }
}