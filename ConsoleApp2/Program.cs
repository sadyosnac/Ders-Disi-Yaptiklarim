namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int aylar;

            Console.Write("Input a month:");

            int.TryParse(Console.ReadLine(), out aylar);

            switch (aylar)
            {
                case 1:case 2:case 3:
                    Console.WriteLine("Quarter I");
                    break;
                case 4: case 5: case 6:
                    Console.WriteLine("Quarter II");
                    break;
                    case 7: case 8:case 9:
                    Console.WriteLine("Quarter III");
                    break;
                case 10: case 11: case 12:
                    Console.WriteLine("Quarter IV");
                    break;
            }
        }
    }
}