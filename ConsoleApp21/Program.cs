namespace ConsoleApp21
{
    
    class Program
    {
        static void Main()
        {
            // Log dosyasının yolu
            string logFilePath = "user_input_log.txt";

            // Kullanıcıdan veri alma ve loglama işlemi
            while (true)
            {
                Console.WriteLine("Bir metin girin (Çıkış için 'exit' yazın):");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Program sonlandırıldı.");
                    break;
                }

                LogUserInput(logFilePath, userInput);
                Console.WriteLine("Girdi loglandı.");
            }
        }

        static void LogUserInput(string filePath, string userInput)
        {
            try
            {
                // Log mesajını oluştur
                string logEntry = $"{DateTime.Now}: {userInput}";

                // Log mesajını dosyaya ekle
                File.AppendAllText(filePath, logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loglama sırasında hata oluştu: {ex.Message}");
            }
        }
    }

}
