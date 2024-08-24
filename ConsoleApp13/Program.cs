namespace ConsoleApp13
{
    internal class Program
    {
        static void MerhabaDe(string isim)
        {
            Console.WriteLine($"Merhaba, {isim}");
        }

        static void KullanicilardanIsimAlVeMerhabaDe(int kullaniciSayisi)
        {
            for (int i = 0; i < kullaniciSayisi; i++)
            {
                Console.Write("Lütfen isminizi girin: ");
                string isim = Console.ReadLine();
                MerhabaDe(isim);
            }
        }

        static void Main(string[] args)
        {
            KullanicilardanIsimAlVeMerhabaDe(3);
        }
    }
}
