using System;

namespace MatematikIslemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen ilk sayıyı girin:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı girin:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkarma");
            Console.WriteLine("3. Çarpma");
            Console.WriteLine("4. Bölme");

            int secim = Convert.ToInt32(Console.ReadLine());
            double sonuc = 0;

            switch (secim)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                    break;
                case 4:
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine("Sonuç: " + sonuc);
                    }
                    else
                    {
                        Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz.");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
    }
}
