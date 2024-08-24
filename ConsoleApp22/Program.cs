using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main()
        {
            // İlk örneği çalıştırmak için yorum satırını kaldırın
            // BasicExample();

            // İkinci örneği çalıştırmak için yorum satırını kaldırın
            // MultipleExitConditionsExample();

            // Üçüncü örneği çalıştırmak için yorum satırını kaldırın
            // SumAndAverageExample();
        }

        // 1. Basit Örnek
        static void BasicExample()
        {
            int sayi;
            do
            {
                Console.WriteLine("Bir sayı girin (0 çıkmak için):");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    sayi = -1;
                    Console.WriteLine("Geçerli bir sayı girmediniz. Lütfen tekrar deneyin.");
                }
                else
                {
                    try
                    {
                        sayi = Convert.ToInt32(input);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Girdiğiniz değer bir sayı değil. Lütfen bir sayı girin.");
                        sayi = -1;
                    }
                }

            } while (sayi != 0);

            Console.WriteLine("Döngü sonlandı.");
        }

        // 2. Birden Fazla Çıkış Koşulu Olan Örnek
        static void MultipleExitConditionsExample()
        {
            int sayi;
            do
            {
                Console.WriteLine("Bir sayı girin (0 veya 'exit' yazarak çıkmak için):");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    sayi = -1;
                    Console.WriteLine("Geçerli bir sayı girmediniz. Lütfen tekrar deneyin.");
                }
                else if (input.ToLower() == "exit")
                {
                    break; // Döngüden çık
                }
                else
                {
                    try
                    {
                        sayi = Convert.ToInt32(input);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Girdiğiniz değer bir sayı değil. Lütfen bir sayı girin.");
                        sayi = -1;
                    }
                }

            } while (sayi != 0);

            Console.WriteLine("Döngü sonlandı.");
        }

        // 3. Girilen Sayıların Toplamını ve Ortalamasını Hesaplayan Örnek
        static void SumAndAverageExample()
        {
            int sayi;
            int toplam = 0;
            int sayac = 0;

            do
            {
                Console.WriteLine("Bir sayı girin (0 çıkmak için):");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    sayi = -1;
                    Console.WriteLine("Geçerli bir sayı girmediniz. Lütfen tekrar deneyin.");
                }
                else
                {
                    try
                    {
                        sayi = Convert.ToInt32(input);

                        if (sayi != 0)
                        {
                            toplam += sayi;
                            sayac++;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Girdiğiniz değer bir sayı değil. Lütfen bir sayı girin.");
                        sayi = -1;
                    }
                }

            } while (sayi != 0);

            if (sayac > 0)
            {
                double ortalama = (double)toplam / sayac;
                Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
                Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
            }

            Console.WriteLine("Döngü sonlandı.");
        }
    }
}
