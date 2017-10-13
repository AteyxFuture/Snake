using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_std
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 2;
            int x = 2;
            char player = 'O';
            ConsoleKeyInfo Keyinfo;
            int[] xsize = new int[] {8,7,6,5,4,3,2 }; 
            int[] ysize = new int[] {3,3,3,3,3,3,3 }; 
            Console.WriteLine(xsize.Count());
            Console.ReadLine();
            while (true)
            {
                Console.Clear();
                for (int i = 0;i < xsize.Count();i++)
                {
                    Console.SetCursorPosition(xsize[i], ysize[i]);
                    Console.Write(player);
                }
                Keyinfo = Console.ReadKey(true);                
                switch (Keyinfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        for (int i = xsize.Count()-1; i > 0; i--)
                        {
                            xsize[i] = xsize[i - 1];
                            ysize[i] = ysize[i - 1];
                        }
                        xsize[0] = xsize[1] + 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        for (int i = xsize.Count()-1; i > 0; i--)
                        {
                            xsize[i] = xsize[i - 1];
                            ysize[i] = ysize[i - 1];
                        }
                        xsize[0] = xsize[1] - 1;
                        break;
                    case ConsoleKey.UpArrow:
                        for (int i = ysize.Count()-1; i > 0; i--)
                        {
                            ysize[i] = ysize[i - 1];
                            xsize[i] = xsize[i - 1];
                        }
                        ysize[0] = ysize[1] - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        for (int i = xsize.Count()-1; i > 0; i--)
                        {
                            ysize[i] = ysize[i - 1];
                            xsize[i] = xsize[i - 1];
                        }
                        ysize[0] = ysize[1] + 1;
                        break;
                }
            }
        }
    }
}
