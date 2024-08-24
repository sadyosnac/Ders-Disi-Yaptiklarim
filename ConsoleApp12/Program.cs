namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input data for a: ");

            int[] a = { 123, 456, 789, 0, 1 };
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


            int Max = a[0];

            foreach (int i in a)
            {
                if (Max < i)
                    Max = i;
            }
            Console.WriteLine($"Max = {Max}");


            Console.WriteLine("\n\n");


            int temp;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sort 'a' asceding ");
            foreach(int i in a)
                Console.WriteLine(i);

        }
    }
}