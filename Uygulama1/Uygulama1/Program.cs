using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("48 / 6 / 4 = " + (48 / 6 / 4));

            Console.WriteLine("24 / 3 * 2 = " + (24 / 3 * 2));

            Console.WriteLine("(7 + 4) * 2 - 1 + 8 / 2 = " + ((7 + 4) * 2 - 1 + 8 / 2));

            Console.WriteLine("(5 - 1) * 2 - 1 + 7^2 / 2 = " + ((5 - 1) * 2 - 1 + (Math.Pow(7, 2)) / 2));

            Console.ReadKey();
        }
    }
}
