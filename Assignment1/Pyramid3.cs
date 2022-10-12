using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Pyramid3
    {
        static void Main()
        {
            int n = 5;

            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();
        }
    }
}

