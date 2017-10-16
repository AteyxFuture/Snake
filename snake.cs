using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_std
{
    class Program
    {
        static char food = '█';
        static char player = '█';
        static ConsoleKeyInfo Keyinfo;
        static int[] xsize = new int[] { 3, 2 };
        static int[] ysize = new int[] { 3, 3 };
        static int foodx;
        static int foody;

        static void Main(string[] args)
        {
            Console.WriteLine("Snake game: press Enter");
            Console.ReadLine();
            Console.CursorVisible = false;
            while (true)
            {
                Generator();
                moveright();
            }
        }
        public static void moveright()
        {
            while (true)
            {
                dostuff(0);
                xsize[0] = xsize[1] + 1;

                if (Console.KeyAvailable)
                {
                    chooseUD();
                }
            }
        }
        public static void moveleft()
        {
            while (true)
            {
                dostuff(0);
                xsize[0] = xsize[1] - 1;

                if (Console.KeyAvailable)
                {
                    chooseUD();
                }
            }
        }
        public static void moveup()
        {
            while (true)
            {
                dostuff(0);
                ysize[0] = ysize[1] - 1;
                if (Console.KeyAvailable)
                {
                    chooseRL();
                }
            }
        }
        public static void movedown()
        {
            while (true)
            {
                dostuff(0);
                ysize[0] = ysize[1] + 1;
                if (Console.KeyAvailable)
                {
                    chooseRL();
                }
            }
        }
        public static void chooseRL()
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
        public static void chooseUD()
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
        public static void Generator()
        {
            do
            {
                Random rnd = new Random();
                foodx = rnd.Next(1, Console.WindowWidth - 2);
                foody = rnd.Next(1, Console.WindowHeight - 1);
            } while (xsize.Contains(foodx) && ysize.Contains(foody));
        }
        public static void EndGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("GAME ENDED Score: " + (xsize.Count()-2));
            Console.ReadKey();
            Environment.Exit(0);
        }
        public static int dostuff(int a)
        {
            if (xsize[0] == -1 || ysize[0] == -1 || xsize[0] == Console.WindowWidth || ysize[0] == Console.WindowHeight)
            {
                EndGame();
            }
            for (int i = 1; i < xsize.Length; ++i)
            {
                if (xsize[0] == xsize[i] && ysize[0] == ysize[i])
                {
                    EndGame();
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(foodx, foody);
            Console.Write(food);
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < xsize.Count(); i++)
            {
                Console.SetCursorPosition(xsize[i], ysize[i]);
                Console.Write(player);
            }
            if (xsize[0] == foodx && ysize[0] == foody)
            {
                Array.Resize(ref xsize, xsize.Length + 1);
                Array.Resize(ref ysize, ysize.Length + 1);
                xsize[xsize.Length - 1] = xsize[xsize.Length - 2] + 1;
                ysize[ysize.Length - 1] = ysize[ysize.Length - 2] + 1;
            }
            if (xsize[0] == foodx && ysize[0] == foody)
            {
                Generator();
            }
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            for (int i = xsize.Count() - 1; i > 0; i--)
            {
                xsize[i] = xsize[i - 1];
                ysize[i] = ysize[i - 1];
            }
            return 0;
        }
    }
}
