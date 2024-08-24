namespace ConsoleApp25
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Bir metin girin: ");
            string text = Console.ReadLine();

            Console.Write("Gecikme süresi (milisaniye): ");
            int delay = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;

            // Karakterleri ekleme
            for (int i = 1; i <= text.Length; i++)
            {
                Console.WriteLine(text.Substring(0, i));
                Thread.Sleep(delay);
            }

            // Karakterleri silme
            for (int i = text.Length - 1; i > 0; i--)
            {
                Console.WriteLine(text.Substring(0, i));
                Thread.Sleep(delay);
            }

            Console.ResetColor();  // Rengi sıfırlama
        }
    }
}
