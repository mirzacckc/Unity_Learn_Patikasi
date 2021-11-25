using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi :" + sayi);
                 
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata: "+ ex.Message.ToString());

            }
            // finally // Hata alsın veya almasın çalıştırmak istenilen kod bloğu buranın içerisine yazılır.
            // {
            //     Console.Write("Yapılan işlemler tamamlandı.");  // finally zorunlu değil isteğe göre
            //     
            // }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-30000000000");                 
            }
            catch (ArgumentNullException ex)
            {
               Console.WriteLine("Boş değer girdiniz.");
               Console.WriteLine  (ex);           
            }
            catch (FormatException ex)
            {
               Console.WriteLine("Veri tipi uygun degildir.");
               Console.WriteLine  (ex);           
            }
            catch (OverflowException ex) // veri tipinin alabileceği değerler dışında bir değer girilirse verilen hata tipidir.
            {
               Console.WriteLine("Alabileceği değerin altında veya üstünde bir değer girdiniz.");
               Console.WriteLine  (ex);           
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlanmıştır.");
            }
        }
    }
}
