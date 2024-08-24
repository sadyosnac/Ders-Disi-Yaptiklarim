namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime;

            while (true)
            {
                Console.WriteLine("If you want to quit type \"exit\"");
                Console.Write("Input a string :");
                
                kelime = Console.ReadLine();

                if (kelime.Equals("exit"))
                {
                    break;
                }
                Console.WriteLine($"You inputted the string: {kelime}");
                Console.WriteLine();
            }
        }
    }
}