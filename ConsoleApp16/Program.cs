namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Başlangıç tahmini
            double x0 = 1.5;

            // Hata toleransı
            double tolerance = 0.00001;

            // Maksimum iterasyon sayısı
            int maxIterations = 10;

            // Sonuç değerini saklamak için değişken
            double x1 = 0;

            for (int i = 0; i < maxIterations; i++)
            {
                // Adım 1: Fonksiyonun ve türevinin hesaplanması
                double fx = x0 * x0 - 2;
                double fxDerivative = 2 * x0;

                // Adım 2: Newton-Raphson formülü ile yeni değerin hesaplanması
                x1 = x0 - (fx / fxDerivative);

                // Adım 3: Sonucu ekrana yazdırma
                Console.WriteLine("İterasyon {0}: x = {1}", i + 1, x1);

                // Adım 4: Hata kontrolü
                if (Math.Abs(x1 - x0) < tolerance)
                    break;

                // Adım 5: Yeni iterasyon için x0'ı güncelleme
                x0 = x1;
            }

            // Sonucu ekrana yazdırma
            Console.WriteLine("Yaklaşık kök: {0}", x1);
        }
    }
}
