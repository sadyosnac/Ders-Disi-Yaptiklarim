namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2.0;  // Başlangıç aralığının sol ucu (x1)
            double b = 4.0;  // Başlangıç aralığının sağ ucu (x2)
            double epsilon = 1e-6; // Tolerans seviyesi (hassasiyet)
            double c = 0.0;  // Hesaplanan x3 değeri
            int iteration = 1; // İterasyon sayacı
            int maxIterations = 10; // Maksimum iterasyon sayısı (10 adımda duracak)

            Func<double, double> f = x => Math.Pow(x, 3) - 5 * x - 3;  // Kökünü bulmak istediğimiz fonksiyon

            Console.WriteLine("İterasyon\t x1\t\t x2\t\t x3\t\t f(x1)\t\t f(x2)\t\t f(x3)");
            Console.WriteLine("--------------------------------------------------------------------------");

            while (iteration <= maxIterations)
            {
                c = (a * f(b) - b * f(a)) / (f(b) - f(a));  // x3'ün hesaplanması

                // Mevcut iterasyon bilgilerini yazdır
                Console.WriteLine($"{iteration}\t\t {a:F5}\t {b:F5}\t {c:F5}\t {f(a):F5}\t {f(b):F5}\t {f(c):F5}");

                if (f(a) * f(c) < 0)
                {
                    b = c;
                }
                else if (f(a) * f(c) > 0)
                {
                    a = c;
                }

                if (Math.Abs(c - (a + b) / 2.0) < epsilon)
                {
                    Console.WriteLine("--------------------------------------------------------------------------");
                    Console.WriteLine($"Çözüm bulundu: x3 = {c:F5}");
                    break;
                }

                iteration++;
            }

            if (iteration > maxIterations)
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("Maksimum iterasyon sayısına ulaşıldı.");
            }
        }
    }
}
