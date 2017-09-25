using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20170807_6Con_SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             bilgisayarın tuttuğu 1-100 arasındaki sayıyı, klavyeden girerek tahmin edeceğimiz bir uygulama yazınız. kaç seferde bulduğunu söyleyiniz.
             */

            // bilgisayarın kendisi rastgele bir sayı üretecekse Random sınıfı kullanılabilir.
            Random r = new Random();
            int tutulan = r.Next(1, 100);
            int tahmin = 0, sayac = 0;
            Console.WriteLine("Aklımdan bir sayı tuttum.. Haydi tahmin et ! ");
            Console.WriteLine("---------------------------------------------");
            Console.Write("Tahminim : ");
            do
            {
                if (int.TryParse(Console.ReadLine(),out tahmin) == true)
                {
                    sayac++;
                    if (tahmin > tutulan)
                    {
                        Console.WriteLine("AŞAĞI");
                        Console.Write("Tahminim : ");
                    }
                    else if(tahmin < tutulan)
                    {
                        Console.WriteLine("YUKARI");
                        Console.Write("Tahminim : ");
                    }
                }
                else
                {
                    Console.WriteLine("GİRDİĞİN ŞEY SAYI OLSUN !");
                    Console.Write("Tahminim : ");
                }

            } while (tahmin != tutulan);

            Console.Write("Tebrikler {0} sayısını {1}. denemede buldun",tutulan,sayac);
          
            Console.Read();

        }
    }
}
