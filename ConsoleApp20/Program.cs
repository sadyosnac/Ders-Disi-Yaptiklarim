using System;

namespace ConsoleApp20
{
    public class MathOperations
    {
        // Üst alma metodunu tanımlıyoruz
        public double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }
    }

    class Program
    {
        static void Main()
        {
            MathOperations mathOps = new MathOperations();

            // Kullanıcıdan taban ve üs değerlerini alıyoruz
            Console.Write("Taban değerini girin: ");
            double baseNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Üs değerini girin: ");
            double exponent = Convert.ToDouble(Console.ReadLine());

            // Üst alma işlemini yapıyoruz
            double result = mathOps.Power(baseNumber, exponent);

            // Sonucu ekrana yazdırıyoruz
            Console.WriteLine($"{baseNumber} üzeri {exponent} = {result}");
        }
    }
}
