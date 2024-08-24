using System;
using System.IO;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Logger sınıfını kullanarak loglama yapıyoruz
            Logger logger = new Logger("log.txt");

            logger.Log("Program başlatıldı.");
            logger.Log("Loglama işlemleri yapılıyor.");
            logger.Log("Program sonlandırıldı.");

            Console.WriteLine("Loglama tamamlandı.");

            // Log dosyasını oku ve ekrana yazdır
            string logContent = File.ReadAllText("log.txt");
            Console.WriteLine("Log İçeriği:");
            Console.WriteLine(logContent);
        }
    }

    public class Logger
    {
        private string logFilePath;
        private int logCount;

        public Logger(string filePath)
        {
            logFilePath = filePath;
            logCount = 0;

            // Eğer log dosyası yoksa oluştur
            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Dispose();
            }
        }

        public void Log(string message)
        {
            logCount++;
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{logCount} -->\t{DateTime.Now}: {message}");
            }
        }
    }
}
