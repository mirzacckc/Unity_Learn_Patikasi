using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sayiDizisi = {24,13,5,87,73,4,12,18};
            
            Console.WriteLine("***** Sırasız Dizi *****");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            Console.WriteLine("***** Sıralı Dizi *****");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("***** Array Clear *****");
            //sayiDizisi elemanlarını kullanarak 2. index ten itibaren 2 tane elemanı 0'lar.
            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Reverse
            Console.WriteLine("***** Array Reverse *****");
            Array.Reverse(sayiDizisi);
            
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //IndexOf
            Console.WriteLine("***** Array IndexOf *****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,24));
            
            //Resize
            Console.WriteLine("***** Array Resize *****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 95;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


        }
    }
}
