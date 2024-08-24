namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input data for a: ");

            int[] a = { 123,456,789,0,1};
            a[1] = 654;

            Console.WriteLine(a[1]);

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {i}");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n\nShow data or array: ");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}