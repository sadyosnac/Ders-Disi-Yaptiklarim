namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("i = {0}\t",i);
            }

            Console.Write("\n\n");

            for (int a = 0; a <= 10; a++)
            {
                Console.Write(a + "\t");
            }

            Console.Write("\n\n");


            for (int b = 10; b >= 1; b--)
            {
                Console.Write("b = {0}\t", b);
            }

            Console.WriteLine("\n");


        }
    }
}