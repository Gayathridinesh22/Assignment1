﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class mtable
    {
        static void Main()
        {
            int n, i;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + "*" + n + "=" + i * n);
            }
            Console.ReadLine();
        }
    }
}

    

