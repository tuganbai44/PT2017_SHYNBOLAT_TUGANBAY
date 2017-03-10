using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _3solution
{
    class Program
    {
        public static void svetofor()
        {
            string p1 = " _______ ";
            string p2 = "|  ***  |";
            string p3 = "| ***** |";
            string p4 = "| ***** |";
            string p5 = "|  ***  |";            
            string p6 = " _______ ";

            int i = 0;
            string[] p = {p1, p2, p3, p4, p5, p6 };
            while (true)
            {
                Console.Clear();
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                }
                if (i == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.WriteLine();
                }
                if (i == 2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(p[j]);
                    }
                    Console.WriteLine();
                }

                Thread.Sleep(500);
                i++;
                i %= 3;
            }
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(svetofor);
            t.Start();

        }
    }
}