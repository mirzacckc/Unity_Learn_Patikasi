using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("** Atama ve İşlemli Atama Operatörleri **");
            //Atama ve İşlemli Atama
            int x = 4;
            int y = 4;
            y = y+2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("** Mantıksal Operatörler **");
            //Mantıksal Operatörler
            // ||(veya) , &&(ve) , !(değil)

            bool isSuccess = true ;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");
           
           
            Console.WriteLine("** İlişkisel Operatörler **");
            //İlişkisel Operatörler
            // <(küçüktür) , >(büyüktür) , <=(küçük eşittir) , >=(büyük eşittir) , ==(eşittir) , !=(eşit değildir)

            int a = 5;
            int b = 6;
            bool sonuc = a<b;
            
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("** Aritmetik Operatörler **");
            //Aritmetik Operatörler
            // * , / , + , -

            int sayi1 = 15;
            int sayi2 = 3;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1-sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = ++sayi1 ;
            Console.WriteLine(sonuc1);

            // % mod alır 
            int sonuc2 = 22%5;
            Console.WriteLine(sonuc2);
                     

        }
    }
}
