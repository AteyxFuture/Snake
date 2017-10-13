using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_std
{
    class Program
    {
        static char player = 'X';
        static ConsoleKeyInfo Keyinfo;
        static int[] xsize = new int[] { 8, 7, 6, 5, 4, 3, 2 };
        static int[] ysize = new int[] { 3, 3, 3, 3, 3, 3, 3 };


        static void Main(string[] args)
        {          
            Console.WriteLine(xsize.Count());
            Console.ReadLine();
            while (true)
            {
                moveright();
            }
        }
        public static void moveright()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                for (int i = 0; i < xsize.Count(); i++)
                {
                    Console.SetCursorPosition(xsize[i], ysize[i]);
                    Console.Write(player);
                }
                //vykreslení hada (DOPRAVA)
                posun(0);
                xsize[0] = xsize[1] + 1;
                //posunutí arrayú (DOPRAVA)
                if (Console.KeyAvailable)
                {
                    Keyinfo = Console.ReadKey();
                    switch (Keyinfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            moveleft();
                            break;
                        case ConsoleKey.UpArrow:
                            moveup();
                            break;
                        case ConsoleKey.DownArrow:
                            movedown();
                            break;
                    }
                }
            }
        }
        public static void moveleft()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                for (int i = 0; i < xsize.Count(); i++)
                {
                    Console.SetCursorPosition(xsize[i], ysize[i]);
                    Console.Write(player);
                }
                //vykreslení hada (DOLEVA)

                posun(0);
                xsize[0] = xsize[1] - 1;
                //posunutí arrayú (DOLEVA)

                if (Console.KeyAvailable)
                {
                    Keyinfo = Console.ReadKey();
                    switch (Keyinfo.Key)
                    {
                        case ConsoleKey.RightArrow:
                            moveright();
                            break;
                        case ConsoleKey.UpArrow:
                            moveup();
                            break;
                        case ConsoleKey.DownArrow:
                            movedown();
                            break;
                    }
                }
            }
        }
        public static void moveup()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                for (int i = 0; i < xsize.Count(); i++)
                {
                    Console.SetCursorPosition(xsize[i], ysize[i]);
                    Console.Write(player);
                }
                //vykreslení hada (NAHORU)

                posun(0);
                ysize[0] = ysize[1] - 1;
                //posunutí arrayú (NAHORU)

                if (Console.KeyAvailable)
                {
                    Keyinfo = Console.ReadKey();
                    switch (Keyinfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            moveleft();
                            break;
                        case ConsoleKey.RightArrow:
                            moveright();
                            break;
                        case ConsoleKey.DownArrow:
                            movedown();
                            break;
                    }
                }
            }
        }
        public static void movedown()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                for (int i = 0; i < xsize.Count(); i++)
                {
                    Console.SetCursorPosition(xsize[i], ysize[i]);
                    Console.Write(player);
                }
                //vykreslení hada (DOLU)

                posun(0);
                ysize[0] = ysize[1] + 1;
                //posunutí arrayú (DOLU)

                if (Console.KeyAvailable)
                {
                    Keyinfo = Console.ReadKey();
                    switch (Keyinfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            moveleft();
                            break;
                        case ConsoleKey.UpArrow:
                            moveup();
                            break;
                        case ConsoleKey.RightArrow:
                            moveright();
                            break;
                    }
                }
            }
        }
        public static int posun(int a)
        {
            for (int i = xsize.Count() - 1; i > 0; i--)
            {
                xsize[i] = xsize[i - 1];
                ysize[i] = ysize[i - 1];
            }
            return 0;
        }
    }
}
