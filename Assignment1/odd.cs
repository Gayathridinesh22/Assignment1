using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class odd
    {
        static void Main()
        {
            int i, n, sum = 0;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The odd numbers are");
            for (i = 1; i <= n; i = i + 2)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }
            Console.WriteLine("Sum of odd numbers is :" + sum);
            Console.ReadLine();
        }
    }
}

