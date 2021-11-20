using System;

namespace console_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Space!");
            Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi Giriniz:");
            string surname = Console.ReadLine();

            Console.WriteLine("Hoşgeldiniz " + name + " " + surname);
        


        }
    }
}
