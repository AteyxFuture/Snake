using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_std
{
    class Program
    {
        static char food = 'X';
        static char player = 'O';
        static ConsoleKeyInfo Keyinfo;
        static int[] xsize = new int[] { 8, 7, 6, 5, 4, 3, 2 };
        static int[] ysize = new int[] { 3, 3, 3, 3, 3, 3, 3 };
        static int foodx;
        static int foody;
        static int lenght = 70;
        static int height = 24;
        static int GameOver;
        static int Growth;


        static void Main(string[] args)
        {
            Console.WriteLine(xsize.Count());
            Console.ReadLine();
            while (true)
            {
                Generator(0);
                moveright();
            }
        }
        public static void moveright()
        {
            while (true)
            {
                check(0);
                CheckSnake(0);
                if (GameOver == 1)
                {
                    EndGame();
                }
                WriteFood();
                for (int i = 0; i < xsize.Count(); i++)
                {
                    Console.SetCursorPosition(xsize[i], ysize[i]);
                    Console.Write(player);
                }
                Grow();
                if (Growth == 1)
                {
                    Generator(0);
                    Growth = 0;
                }
                //vykreslení hada (DOPRAVA)

                System.Threading.Thread.Sleep(100);
                Console.Clear();

                posun(0);
                xsize[0] = xsize[1] + 1;
                //posunutí arrayú (DOPRAVA)

                if (Console.KeyAvailable)
                {
                    Keyinfo = Console.ReadKey();
                    switch (Keyinfo.Key)
                    {
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
                check(0);
                CheckSnake(0);
                if (GameOver == 1)
                {
                    EndGame();
                }
                WriteFood();
                for (int i = 0; i < xsize.Count(); i++)
                {
                    Console.SetCursorPosition(xsize[i], ysize[i]);
                    Console.Write(player);
                }
                Grow();
                if (Growth == 1)
                {
                    Generator(0);
                    Growth = 0;
                }
                //vykreslení hada (DOLEVA)

                System.Threading.Thread.Sleep(100);
                Console.Clear();

                posun(0);
                xsize[0] = xsize[1] - 1;
                //posunutí arrayú (DOLEVA)

                if (Console.KeyAvailable)
                {
                    Keyinfo = Console.ReadKey();
                    switch (Keyinfo.Key)
                    {
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
                check(0);
                CheckSnake(0);
                if (GameOver == 1)
                {
                    EndGame();
                }
                WriteFood();
                for (int i = 0; i < xsize.Count(); i++)
                {
                    Console.SetCursorPosition(xsize[i], ysize[i]);
                    Console.Write(player);
                }
                Grow();
                if (Growth == 1)
                {
                    Generator(0);
                    Growth = 0;
                }
                //vykreslení hada (NAHORU)

                System.Threading.Thread.Sleep(100);
                Console.Clear();

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
                    }
                }
            }
        }
        public static void movedown()
        {
            while (true)
            {
                check(0);
                CheckSnake(0);
                if (GameOver == 1)
                {
                    EndGame();
                }
                WriteFood();
                for (int i = 0; i < xsize.Count(); i++)
                {
                    Console.SetCursorPosition(xsize[i], ysize[i]);
                    Console.Write(player);
                }
                Grow();
                if (Growth == 1)
                {
                    Generator(0);
                    Growth = 0;
                }
                //vykreslení hada (DOLU)

                System.Threading.Thread.Sleep(100);
                Console.Clear();

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
        public static int Generator(int a)
        {
            do
            {
                Random rnd = new Random();
                foodx = rnd.Next(1, Console.WindowWidth - 2);
                foody = rnd.Next(1, Console.WindowHeight - 1);
            } while (xsize.Contains(foodx) && ysize.Contains(foody));
            Console.SetCursorPosition(foodx, foody);
            Console.Write(food);
            return 0;
        }
        public static void WriteFood()
        {
            Console.SetCursorPosition(foodx, foody);
            Console.Write(food);
        }
        public static int check(int a)
        {
            if (xsize[0] == -1 || ysize[0] == -1 || xsize[0] == Console.WindowWidth || ysize[0] == Console.WindowHeight)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.Write("Game Over");
                Console.ReadLine();
                GameOver = 1;
            }
            return 0;
        }
        public static int CheckSnake(int a)
        {
            for (int i = 1; i < xsize.Length; ++i)
            {
                if (xsize[0] == xsize[i] && ysize[0] == ysize[i])
                {
                    Console.Write("Game Over");
                    Console.ReadLine();
                    GameOver = 1;
                    break;
                }
            }
            return 0;
        }
        public static void Grow()
        {
            if (xsize[0] == foodx && ysize[0] == foody)
            {
                Array.Resize(ref xsize, xsize.Length + 1);
                Array.Resize(ref ysize, ysize.Length + 1);
                xsize[xsize.Length - 1] = xsize[xsize.Length - 2] + 1;
                ysize[ysize.Length - 1] = ysize[ysize.Length - 2] + 1;
                Growth=1;
            }
        }
        public static void EndGame()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("GAME ENDED");
            Environment.Exit(0);
        }
    }
}