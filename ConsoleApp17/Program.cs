using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp17
{
    internal class Program
    {
        // Hataları ve geçersiz girişleri saklamak için bir liste oluşturuyoruz
        static List<string> logs = new List<string>();

        static void Main()
        {
            try
            {
                // Kullanıcıdan geçerli bir döngü sayısı al
                int iterations = GetIterationCount();

                // Döngüyü belirtilen sayı kadar çalıştır
                for (int i = 0; i < iterations; i++)
                {
                    // Kullanıcıdan geçerli bir x0 değeri al
                    double x0 = GetX0Value();

                    // Fonksiyonu hesapla ve sonucu al
                    double fx = CalculateFunction(x0);

                    // Sonucu ekrana yazdır
                    Console.WriteLine("f(" + x0 + ") = " + fx);
                }
            }
            catch (Exception ex)
            {
                // Hata loglama ve listeye ekleme
                LogError(ex);
                Console.WriteLine("Beklenmeyen bir hata oluştu. Hata loglandı.");
            }
            finally
            {
                // Programın sonunda logları ekrana yazdır
                PrintLogs();
            }
        }

        // Hataları loglayan ve listeye ekleyen metod
        static void LogError(Exception ex)
        {
            string logMessage = $"[{DateTime.Now}] Hata: {ex.Message}{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}";
            logs.Add(logMessage);

            // Aynı zamanda logu dosyaya da yazıyoruz
            string logFilePath = "error_log.txt";
            File.AppendAllText(logFilePath, logMessage);
        }

        // Geçersiz girişleri loglayan metod
        static void LogInvalidInput(string input)
        {
            string logMessage = $"[{DateTime.Now}] Geçersiz giriş: '{input}'{Environment.NewLine}";
            logs.Add(logMessage);

            // Aynı zamanda logu dosyaya da yazıyoruz
            string logFilePath = "error_log.txt";
            File.AppendAllText(logFilePath, logMessage);
        }

        // Logları ekrana yazdıran metod
        static void PrintLogs()
        {
            Console.WriteLine("\n-- Loglar --");
            if (logs.Count == 0)
            {
                Console.WriteLine("Hata kaydı bulunmamaktadır.");
            }
            else
            {
                foreach (var log in logs)
                {
                    Console.WriteLine(log);
                }
            }
        }

        // Döngü sayısını kullanıcıdan alıp döndüren metod
        static int GetIterationCount()
        {
            int iterations = 0;

            do
            {
                Console.Write("Kaç defa döngü çalışsın (en fazla 10): ");
                string iterationInput = Console.ReadLine();

                if (int.TryParse(iterationInput, out iterations))
                {
                    if (iterations > 10)
                    {
                        Console.WriteLine("Lütfen 10'dan büyük bir sayı girmeyin.");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen sadece rakam girin.");
                }

            } while (iterations < 1 || iterations > 10);

            return iterations;
        }

        // Kullanıcıdan x0 değerini alıp döndüren metod
        static double GetX0Value()
        {
            string input;
            double x0 = 0; // x0 değişkenine başlangıç değeri atanıyor
            int remainingAttempts = 3; // Kullanıcının 3 hakkı var

            while (remainingAttempts > 0)
            {
                Console.Write("Lütfen x0 değerini girin: ");
                input = Console.ReadLine();

                // Kullanıcının girdiği değerin double tipine dönüştürülüp dönüştürülemediğini kontrol et
                if (double.TryParse(input, out x0))
                {
                    break; // Geçerli bir sayı girildi, döngüden çık
                }
                else
                {
                    remainingAttempts--; // Hatalı giriş, hakkı azalt
                    LogInvalidInput(input); // Geçersiz girişi logla

                    if (remainingAttempts > 0)
                    {
                        Console.WriteLine($"Lütfen sadece geçerli bir sayı girin. Kalan hakkınız: {remainingAttempts}");

                        // Çıkış yapmak isteyip istemediğini kontrol eden metod
                        if (CheckIfExit())
                        {
                            PrintLogs(); // Çıkış yapmadan önce logları yazdır
                            Environment.Exit(0); // Programdan çık
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hakkınız kalmadı. Programdan çıkılıyor...");
                        PrintLogs(); // Çıkış yapmadan önce logları yazdır
                        Environment.Exit(0); // Haklar bitti, programdan çık
                    }
                }
            }

            return x0;
        }

        // f(x) = x^2 - 2 fonksiyonunu hesaplayan metod
        static double CalculateFunction(double x)
        {
            return x * x - 2;
        }

        // Çıkış yapmak isteyip istemediğini kontrol eden metod
        static bool CheckIfExit()
        {
            Console.Write("Çıkış yapmak istiyor musunuz? (evet/hayır): ");
            string exitResponse = Console.ReadLine().Trim().ToLower();

            if (exitResponse == "evet")
            {
                Console.WriteLine("Programdan çıkılıyor...");
                return true;
            }

            return false;
        }
    }
}
