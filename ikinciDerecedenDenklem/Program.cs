namespace DenkleminKokleriniBulma
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double delta;
            double x1, x2;
            double z;

            Console.Write("Denklemin 1.katsayısını giriniz: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Denklemin 2.katsayısını giriniz: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Denklemin 3.katsayısını giriniz: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = b * b - 4 * a * c;

            Console.WriteLine("Denklemin Deltası: " + delta);

            if (delta < 0)
            {
                Console.WriteLine("Delta küçüktür 0'dan.");
                Console.WriteLine("KOK YOKTUR");
            }
            else if (delta > 0)
            {
                Console.WriteLine("Delta büyüktür 0'dan");
                Console.WriteLine("Deltanın Mutlak değeri alınacak");

                delta = Math.Abs(delta);

                Console.WriteLine("Deltanın Mutlak değerinin alınmış hali: " + delta);

                Console.WriteLine();

                Console.WriteLine("Deltanın karekoku alınacak");

                z = Math.Sqrt(delta) / (2 * a);

                Console.WriteLine("Deltanın karekoku alınmış hali: " + z);


                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("Birinci Kok = (x1) = {0}", x1);
                Console.WriteLine("İkinci Kok = (x2) = {0}", x2);

            }
            else if (delta == 0)
            {
                z = -b / 2 * a;
                Console.WriteLine("Denklemin bir kökü vardır: " + z);
            }
            else
            {
                Console.WriteLine("HATA!!!");
            }
        }
    }
}