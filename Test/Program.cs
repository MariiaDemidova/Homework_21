using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] garden = new int[2, 7];
            for (int i = 6; i > -1; i--)
            {
                for (int j = 1; j > -1; j--)
                {
                    garden[j, i] = 2;
                    Console.Write(garden[j, i]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
