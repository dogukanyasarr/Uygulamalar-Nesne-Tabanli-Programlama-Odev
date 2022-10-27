using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("girilen iki sayının birbirine tam bölünüp bölünmediğini gösteren program kodu");

            bas:
            Console.Write("birinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("ikinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            if (sayi2 == 0)
            {
                Console.WriteLine("bölen değer sıfır olamaz başka bir sayı giriniz");
                goto bas;
            }
            else
            {
                double bolum = (sayi1 / sayi2);

                Console.WriteLine("iki sayının bölümü: " + bolum);
            }

            Console.ReadKey();
        }
    }
}
