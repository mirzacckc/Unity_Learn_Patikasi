using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
           int month =DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 3:
                    Console.WriteLine("Mart Ayındasınız!");
                    break;
                case 9:
                    Console.WriteLine("Eylül Ayındasınız!");
                    break;
                case 10:
                    Console.WriteLine("Ekim Ayındasınız!");
                    break;
                case 11:
                    Console.WriteLine("Kasım Ayındasınız!");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girişi!!");
                break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış Ayında bulunuyorsunuz!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar Ayında bulunuyorsunuz!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Ayında bulunuyorsunuz!");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Ayında bulunuyorsunuz!");
                    break;
                default: // Sırası önemli değil herhangi bir case ifadesinden sonrada yazılabilir sırayla çalışıyor gibi düşünülmemeli.
                break;
            }
        }
    }
}
