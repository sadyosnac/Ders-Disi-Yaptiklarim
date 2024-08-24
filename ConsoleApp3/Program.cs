namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            float sayı;

            Console.Write("Lutfen bir sayi giriniz: [1-100] = ");

            sayı = float.Parse(Console.ReadLine());

            while (!(1 <= sayı && sayı <= 100))
            {
                Console.Write("Tekrardan sayı giriniz: ");
                sayı = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sayıyı girdikten sonra: " + sayı );
        }
    }
}