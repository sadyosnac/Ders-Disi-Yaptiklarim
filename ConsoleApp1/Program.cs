namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // -------------------------------------
            //
            // ConsoleApp yazanlar C# Fundamentals'in içine atılacak
            // 
            // -------------------------------------


            int n;
            Console.Write("Input n: ");

            n = int.Parse(Console.ReadLine());

            int birler = n % 10;

            Console.WriteLine("Birler = " + birler);

            // 12345 / 10 => 1234 % 10 => 4

            int Onlar = n / 10 % 10;

            Console.WriteLine("Onlar = " + Onlar);

            // 12345 / 100 => 123 % 10 => 3

            int Yuzler = n / 100 % 10;

            Console.WriteLine("Yuzler = " + Yuzler);

            int Binler = n / 1000 % 10;

            Console.WriteLine("Binler = " + Binler);

            int OnBinler = n / 10000 % 10;

            Console.WriteLine("OnBinler = " + OnBinler);
        }
    }
}