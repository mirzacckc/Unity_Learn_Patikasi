using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time >=7 && time <11 )
                Console.WriteLine("Günaydın");
            else if(time <= 18)
                Console.WriteLine("İyi günler");
            else
                Console.WriteLine("İyi geceler");

            string sonuc = time<=18 ? "İyi Günler" : "İyi Geceler";    // atanan eşitlik sağlanırsa soru işaretinden sonra ilk yazılan sağlamazsa ikinci yazılan gelecek.


            sonuc = time >=7 && time <11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";
            Console.WriteLine(sonuc);

        }
    }
}
