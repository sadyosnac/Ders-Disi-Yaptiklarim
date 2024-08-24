namespace ConsoleApp24
{
    internal class Program
    {
        static void Main()
        {
            string text = "string";

            // Karakterleri ekleme
            for (int i = 1; i <= text.Length; i++)
            {
                Console.WriteLine(text.Substring(0, i));
            }

            // Karakterleri silme
            for (int i = text.Length - 1; i > 0; i--)
            {
                Console.WriteLine(text.Substring(0, i));
            }
        }
    }
}
