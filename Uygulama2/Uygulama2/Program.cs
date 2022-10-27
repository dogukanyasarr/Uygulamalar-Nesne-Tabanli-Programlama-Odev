using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            int y = 13;
            int z = 42;

            if(23 == 55 && 76 > 45 && 5 < 12)
            {
                Console.WriteLine("çalıştı");
                //çalıştmadı
            }
            if (23 >= 23 && z == y && z < x)
            {
                Console.WriteLine("çalıştı 2");
                //çalışmadı
            }
            if (x > y && z == y && z < x)
            {
                Console.WriteLine("çalıştı 3");
                //çalışmadı
            }
            if (z > x && y < x)
            {
                Console.WriteLine("çalıştı 4");
                //çalıştı
            }
            Console.ReadKey();
        }
    }
}
