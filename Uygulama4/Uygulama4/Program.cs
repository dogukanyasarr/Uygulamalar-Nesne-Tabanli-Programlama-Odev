using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ikinci dereceden kökler bulan program kodu");
            Console.WriteLine("n\nüç tane sayı giriniz:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double d = b * b - (4 * a * c);
            double x1, x2, x;

            if (d > 0)
            {
                x1 = (-b - (Math.Sqrt(d)) / 2 * a);
                x2 = (-b + (Math.Sqrt(d)) / 2 * a);

                Console.WriteLine("denklemin iki ayrı kökü vardır.");
                Console.WriteLine("x1 kökü: " + x1);
                Console.WriteLine("x2 kökü: " + x2);

            }

            else if (d == 0)
            {
                x = -b / 2 * a;
                Console.WriteLine("denklemin bir kökü vardır.");
                Console.WriteLine("x kökü: " + x);


            }
            else
            {
                Console.WriteLine("denklemin kökü yoktur.");
            }

            Console.ReadKey();
        }
    }
}
