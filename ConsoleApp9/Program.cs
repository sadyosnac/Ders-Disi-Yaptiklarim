namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[5];

            a1[0] = 12;
            a1[1] = 27;

            Console.Write("Input data for a1[0]: ");
            a1[0] = int.Parse(Console.ReadLine());

            Console.WriteLine($"After inputting, a1[0] = {a1[0]}");


            int[] dizi;
            int size = 5;
            dizi = new int[size];

            Console.WriteLine(dizi[0]);
            Console.WriteLine(dizi[2]);
            Console.WriteLine(dizi[4]);

            Console.WriteLine();

            int[] a3 = new int[5] { 1, 3, 2, 5, 4 };
            Console.WriteLine(a3[4]);
            a3[4] = 12;
            Console.WriteLine(a3[4]);


            Console.WriteLine("\n");

            int[] a4;
            a4 = new int[5] { 12, 34, 56, 78, 89 };
            Console.WriteLine($"{a4[0]} -- {a4[1]} -- {a4[2]} -- {a4[3]} -- {a4[4]} \n\n");

            int[] again = { 123, 456, 789 };
            again[1] = 654;
            Console.WriteLine("Input data for \"again\": ");
            Console.WriteLine(again[1]);


        }
    }
}