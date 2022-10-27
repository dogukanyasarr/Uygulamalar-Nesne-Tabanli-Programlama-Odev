using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama5
{
    class Program
    {
        static void Main(string[] args)
        {


            int gg, aa, yyyy;
            Console.WriteLine("gg.aa.yyyy düzeninde gün, ay ve yılı giriniz: ");
            gg = Convert.ToInt16(Console.ReadLine());
            aa = Convert.ToInt16(Console.ReadLine());
            yyyy = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine(gg + "." + aa + "." + yyyy);
            Console.WriteLine(" ");

            switch (aa)
            {
                case 1:
                    Console.WriteLine("bulunduğumuz ay: ocak");
                    break;
                case 2:
                    Console.WriteLine("bulunduğumuz ay: şubak");
                    break;
                case 3:
                    Console.WriteLine("bulunduğumuz ay: mart");
                    break;
                case 4:
                    Console.WriteLine("bulunduğumuz ay: nisan");
                    break;
                case 5:
                    Console.WriteLine("bulunduğumuz ay: mayıs");
                    break;
                case 6:
                    Console.WriteLine("bulunduğumuz ay: haziran");
                    break;
                case 7:
                    Console.WriteLine("bulunduğumuz ay: temmuz");
                    break;
                case 8:
                    Console.WriteLine("bulunduğumuz ay: ağustos");
                    break;
                case 9:
                    Console.WriteLine("bulunduğumuz ay: eylül");
                    break;
                case 10:
                    Console.WriteLine("bulunduğumuz ay: ekim");
                    break;
                case 11:
                    Console.WriteLine("bulunduğumuz ay: kasım");
                    break;
                case 12:
                    Console.WriteLine("bulunduğumuz ay: aralık");
                    break;
                default:
                    Console.WriteLine("hatalı veri girişi");
                    break;
            }
            Console.ReadKey();

        }
    }
}
