using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Homework_21
{
    class Program
    {
        static int[,] garden = new int[2, 7];
        static void Gardener1()
        {
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 7; i++)
                {
                    garden[j, i] = 1;
                    Thread.Sleep(1);
                }
            }
        }
        static void Gardener2()
        {
            for (int i = 6; i > -1; i--)
            {
                for (int j = 1; j > -1; j--)
                {
                    garden[j, i] = 2;
                    Thread.Sleep(1);
                }
            }
        }
        static void Main(string[] args)
        {
            
            ThreadStart threadstart = new ThreadStart(Gardener2);
            Thread thread = new Thread(threadstart);
            thread.Start();
            Gardener1();
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.Write(garden[j,i]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
