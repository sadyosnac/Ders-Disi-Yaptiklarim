namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            float sayi;
            do
            {
                Console.Write("Lutfen sayi giriniz: [1-100] = ");
                sayi = float.Parse(Console.ReadLine());
            } while (!(1 <= sayi && sayi <= 100));
            Console.WriteLine("Sayıyı girdikten sonra = {0}", sayi);

            Console.WriteLine("----------------------------------");

            int count = 1;

            do
            {
                Console.WriteLine(count++);
            } while (count <= 10);

            Console.WriteLine("----------------------------------");

            int count_2 = 1;

            do
            {
                Console.WriteLine(10 + 1 - count++);
            } while (count <= 10);
        }
    }
}