using System;
using System.IO;
using System.Linq;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Logger sınıfını kullanarak loglama yapıyoruz
            Logger logger = new Logger("log.txt");

            logger.Log("Program başlatıldı.", LogLevel.Info);
            logger.Log("Bu bir uyarı mesajıdır.", LogLevel.Warning);
            logger.Log("Bu bir hata mesajıdır.", LogLevel.Error);
            logger.Log("Program sonlandırıldı.", LogLevel.Info);

            Console.WriteLine("Loglama tamamlandı.");

            // Log dosyasını oku ve ekrana yazdır
            string logContent = File.ReadAllText("log.txt");
            Console.WriteLine("Log İçeriği:");
            Console.WriteLine(logContent);
        }
    }

    public enum LogLevel
    {
        Info,
        Warning,
        Error
    }

    public class Logger
    {
        private string logFilePath;
        private int logCount;

        public Logger(string filePath)
        {
            logFilePath = filePath;

            // Eğer log dosyası yoksa oluştur ve logCount'u sıfırla
            if (!File.Exists(logFilePath))
            {
                File.Create(logFilePath).Dispose();
                logCount = 0;
            }
            else
            {
                // Mevcut log dosyasındaki son numarayı oku ve logCount'a ata
                logCount = GetLastLogNumber();
            }
        }

        private int GetLastLogNumber()
        {
            string lastLine = File.ReadLines(logFilePath).LastOrDefault();
            if (lastLine != null)
            {
                string[] parts = lastLine.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length > 0 && int.TryParse(parts[0], out int lastNumber))
                {
                    return lastNumber;
                }
            }
            return 0;
        }

        public void Log(string message, LogLevel level = LogLevel.Info)
        {
            logCount++;
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{logCount} -->\t{DateTime.Now} [{level}]: {message}");
            }
        }
    }
}
