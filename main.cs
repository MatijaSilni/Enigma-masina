using System;

class Program 
{
  static char[] prviRed = { 'Q', 'W', 'E', 'R', 'T', 'Z', 'U', 'I', 'O' };
        static char[] drugiRed = { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K' };
        static char[] treciRed = { 'P', 'Y', 'X', 'C', 'V', 'B', 'N', 'M', 'L' };

        static void Tastatura()
        {
            // Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.Black;
            char hor = '\u2500', ver = '\u2502';
            char gLevi = '\u250C', gDesni = '\u2510';
            char dLevi = '\u2514', dDesni = '\u2518';
            char gornji = '\u252C', donji = '\u2534';

            //prvi red
            Console.SetCursorPosition(10, 5);
            Console.Write("" + gLevi + hor);
            for (int i = 0; i < 8; i++)
            {
                Console.Write("" + hor + hor + gornji + hor);
            }
            Console.Write("" + hor + hor + gDesni);

            Console.SetCursorPosition(10, 6);
            for (int i = 0; i < 9; i++)
            {
                Console.Write("" + ver + " " + prviRed[i] + " ");
            }
            Console.Write(ver);

            Console.SetCursorPosition(10, 7);
            Console.Write("" + dLevi + hor);
            for (int i = 0; i < 8; i++)
            {
                Console.Write("" + hor + hor + donji + hor);
            }
            Console.Write("" + hor + hor + dDesni);


            //drugi red

            Console.SetCursorPosition(12, 8);
            Console.Write("" + gLevi + hor);
            for (int i = 0; i < 7; i++)
            {
                Console.Write("" + hor + hor + gornji + hor);
            }
            Console.Write("" + hor + hor + gDesni);

            Console.SetCursorPosition(12, 9);
            for (int i = 0; i < 8; i++)
            {
                Console.Write("" + ver + " " + drugiRed[i] + " ");
            }
            Console.Write(ver);

            Console.SetCursorPosition(12, 10);
            Console.Write("" + dLevi + hor);
            for (int i = 0; i < 7; i++)
            {
                Console.Write("" + hor + hor + donji + hor);
            }
            Console.Write("" + hor + hor + dDesni);

            //treci red

            Console.SetCursorPosition(10, 11);
            Console.Write("" + gLevi + hor);
            for (int i = 0; i < 8; i++)
            {
                Console.Write("" + hor + hor + gornji + hor);
            }
            Console.Write("" + hor + hor + gDesni);


            Console.SetCursorPosition(10, 12);
            for (int i = 0; i < 9; i++)
            {
                Console.Write("" + ver + " " + treciRed[i] + " ");
            }
            Console.Write(ver);

            Console.SetCursorPosition(10, 13);
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
                Console.SetCursorPosition(21 + j, 20);
                Console.Write("" + prviRed[i]);
            }

            for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
            {
                Console.SetCursorPosition(21 + j, 21);
                Console.Write("" + krug);
            }

            //drugi red

            for (int i = 0, j = 0; i < 8 && j < 16; i++, j += 2)
            {
                Console.SetCursorPosition(22 + j, 22);
                Console.Write("" + drugiRed[i]);
            }

            for (int i = 0, j = 0; i < 8 && j < 16; i++, j += 2)
            {
                Console.SetCursorPosition(22 + j, 23);
                Console.Write("" + krug);
            }

            //treci red

            for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
            {
                Console.SetCursorPosition(21 + j, 24);
                Console.Write("" + treciRed[i]);
            }

            for (int i = 0, j = 0; i < 9 && j < 18; i++, j += 2)
            {
                Console.SetCursorPosition(21 + j, 25);
                Console.Write("" + krug);
            }

            Console.SetCursorPosition(0, 30);
        }
        static void Main(string[] args)
        {
            Tastatura();
            Plugboard();
        }
}