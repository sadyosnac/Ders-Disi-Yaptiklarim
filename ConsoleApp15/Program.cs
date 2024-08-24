namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Başlangıç tahmini
            double x0 = 1.5;
            double tolerance = 0.00001;
            int maxIterations = 10;
            double x1 = 0;

            for (int i = 0; i < maxIterations; i++)
            {
                // f(x) = x^2 - 2
                double fx = x0 * x0 - 2;

                // f'(x) = 2x
                double fxDerivative = 2 * x0;

                // Newton-Raphson formülü
                x1 = x0 - (fx / fxDerivative);

                Console.WriteLine("İterasyon {0}: x = {1}", i + 1, x1);

                // Hedef doğruluk seviyesine ulaşılmışsa döngüyü durdur
                if (Math.Abs(x1 - x0) < tolerance)
                    break;

                // Yeni x0 olarak x1'i ata
                x0 = x1;
            }

            Console.WriteLine("Yaklaşık kök: {0}", x1);
        }
    }
}
