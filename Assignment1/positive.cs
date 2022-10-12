using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class positive
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }
            Console.ReadLine();
        }
    }
}

    

