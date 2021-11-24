using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Implicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("**** Implicit Conversion **** ");

            byte a = 5;
            sbyte b = 30;
            short c =10;


            int d = a+b+c; // int kapasitesi daha fazla olduğundan böyle bir atama gerçekleştirilebilir.
            Console.WriteLine("d:" + d);

            long h = d; // long kapasitesi int daha fazla olduğundan böyle bir atama gerçekleştirilebilir.
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "Zürafa";
            char g = 'f' ;
            object j = e+g+d;  // object ile tüm veri tiplerini birleştirerek çıktı almak mümkün
            Console.WriteLine("j:" + j);


            //Explicit Conversion (Bilinçli Dönüşüm)
            Console.WriteLine("**** Explicit Conversion **** ");

            int x = 4;
            byte y = (byte)x; // hedef veri tipini yazarak o veri tipine dönüştürerek eşitleyebiliriz
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.4f;
            byte v =(byte)w;
            Console.WriteLine("v:" + v);

            // ** ToString Methodu **
            Console.WriteLine("** ToString Methodu **");
            int xx = 8 ;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz  = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);

            // *** System.Convert *** 
            Console.WriteLine("*** System.Convert *** ");

            string s1 = "10" , s2 = "20";
            int sayi1, sayi2 ;
            int Toplam; 

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + Toplam);

            // ***** Parse *****
            Console.WriteLine("***** Parse ***** ");
            ParseMethod();



        }

        public static void  ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double d1;

            rakam1 = Int32.Parse(metin1);
            d1 = Double.Parse(metin2);


            Console.WriteLine("rakam1:" + rakam1);
            Console.WriteLine("double1:" + d1);



        }
    }

}
