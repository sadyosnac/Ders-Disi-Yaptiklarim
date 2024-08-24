namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            while (sayi < 10)
            {
                Console.WriteLine("sayi = " + sayi);

                sayi++;
            }


            Console.WriteLine("---------------------------------");

            Console.WriteLine();

            int sayi_2 = 10;
            while (sayi_2 > 0)
            {
                Console.WriteLine("sayi_2 = {0}",sayi_2);
                sayi_2--;
            }
        }
    }
}