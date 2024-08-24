namespace ConsoleApp26
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Bir metin girin: ");
            string text = Console.ReadLine();

            Console.Write("Gecikme süresi (milisaniye): ");
            int delay = int.Parse(Console.ReadLine());

            Console.Write("Metni ters yönde mi göstermek istersiniz? (y/n): ");
            bool reverse = Console.ReadLine().ToLower() == "y";

            Console.ForegroundColor = ConsoleColor.Yellow;

            if (reverse)
            {
                // Karakterleri silme
                for (int i = text.Length - 1; i > 0; i--)
                {
                    Console.WriteLine(text.Substring(0, i));
                    Thread.Sleep(delay);
                }

                // Karakterleri ekleme
                for (int i = 1; i <= text.Length; i++)
                {
                    Console.WriteLine(text.Substring(0, i));
                    Thread.Sleep(delay);
                }
            }
            else
            {
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
            }

            Console.ResetColor();  // Rengi sıfırlama
        }
    }
}
