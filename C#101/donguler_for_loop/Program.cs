using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Lütfen sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)
            {
               if(i%2 == 1)
                Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içerisinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2 == 1)
                    tekToplam += i;  //tekToplam = tekToplam + 1;
                else
                    ciftToplam += i;
            }
            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);

            //break,continue
            Console.WriteLine("**** Break ****");
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }

            Console.WriteLine("**** Continue ****");
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
