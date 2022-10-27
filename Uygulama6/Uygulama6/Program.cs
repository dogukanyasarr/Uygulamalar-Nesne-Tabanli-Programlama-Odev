using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("girilen derece değerini radyan değerine çeviren program kodu");
            Console.Write("bir derece değeri giriniz: ");
            double derece = Convert.ToDouble(Console.ReadLine());
            double radyan = (derece / 180);
            Console.WriteLine("radyan değeri: " + radyan + " * pi"); // bu matematiksel işlemin çözümünde pi işlemin yanına yazılıyor. 3.14 değeri ile çarpılmıyor.

            double gradyan = derece * 200 / 180;
            Console.WriteLine("gradyan değeri: " + gradyan);

            Console.ReadKey();
        }
    }
}
