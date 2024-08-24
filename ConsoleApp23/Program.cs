namespace ConsoleApp23
{
    public class CubicSpline
    {
        private readonly double[] _x;
        private readonly double[] _y;
        private readonly double[] _a;
        private readonly double[] _b;
        private readonly double[] _c;
        private readonly double[] _d;
        private readonly int _n;

        public CubicSpline(double[] x, double[] y)
        {
            Console.WriteLine($"x.Length: {x.Length}");
            Console.WriteLine($"y.Length: {y.Length}");
            if (x.Length != y.Length)
                throw new ArgumentException("x ve y dizileri aynı uzunlukta olmalıdır.");

            _x = x;
            _y = y;
            _n = x.Length - 1;

            _a = new double[_n];
            _b = new double[_n];
            _c = new double[_n + 1];
            _d = new double[_n];

            InitializeCoefficients();
        }

        static void PrintArray(string arrayName, double[] array)
        {
            Console.WriteLine($"{arrayName}:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{arrayName}[{i}] = {array[i]}  ");
            }
            Console.WriteLine();
        }

        private void InitializeCoefficients()
        {
            double[] h = new double[_n];
            double[] alpha = new double[_n];
            double[] l = new double[_n + 1];
            double[] mu = new double[_n];
            double[] z = new double[_n + 1];

            // Dizileri ekrana yazdırma
            PrintArray("h", h);
            PrintArray("alpha", alpha);
            PrintArray("l", l);
            PrintArray("mu", mu);
            PrintArray("z", z);
            Console.WriteLine("-----------------------------------------------");

            for (int i = 0; i < _n; i++)
            {
                h[i] = _x[i + 1] - _x[i];
                Console.WriteLine($"h[i]: {h[i]}");
                Console.WriteLine($"_x[i + 1]: {_x[i + 1]}");
                Console.WriteLine($"_x[i]: {_x[i]}");
                Console.WriteLine($"_x[i + 1] - _x[i]: {_x[i + 1] - _x[i]}");
                Console.WriteLine("");
                if (i > 0)
                    alpha[i] = (3.0 / h[i]) * (_y[i + 1] - _y[i]) - (3.0 / h[i - 1]) * (_y[i] - _y[i - 1]);
            }

            l[0] = 1.0;
            mu[0] = 0.0;
            z[0] = 0.0;

            for (int i = 1; i < _n; i++)
            {
                l[i] = 2.0 * (_x[i + 1] - _x[i - 1]) - h[i - 1] * mu[i - 1];
                mu[i] = h[i] / l[i];
                z[i] = (alpha[i] - h[i - 1] * z[i - 1]) / l[i];
            }

            l[_n] = 1.0;
            z[_n] = 0.0;
            _c[_n] = 0.0;

            for (int j = _n - 1; j >= 0; j--)
            {
                _c[j] = z[j] - mu[j] * _c[j + 1];
                _b[j] = (_y[j + 1] - _y[j]) / h[j] - h[j] * (_c[j + 1] + 2.0 * _c[j]) / 3.0;
                _d[j] = (_c[j + 1] - _c[j]) / (3.0 * h[j]);
                _a[j] = _y[j];
            }
        }

        public double Interpolate(double x)
        {
            int i = FindInterval(x);

            double dx = x - _x[i];
            return _a[i] + _b[i] * dx + _c[i] * dx * dx + _d[i] * dx * dx * dx;
        }

        private int FindInterval(double x)
        {
            if (x < _x[0] || x > _x[_n])
                throw new ArgumentException("x değeri veri aralığının dışında.");

            for (int i = 0; i < _n; i++)
            {
                if (x >= _x[i] && x <= _x[i + 1])
                    return i;
            }

            // Bu noktada, x değeri geçerli aralıkta olmalı.
            throw new ArgumentException("x değeri veri aralığının dışında.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Test verileri
            double[] x = { 0.0, 1.0, 2.0, 3.0, 4.0 };
            double[] y = { 0.0, 1.0, 0.0, 1.0, 0.0 };

            // CubicSpline nesnesini oluştur
            CubicSpline spline = new CubicSpline(x, y);

            // İterpolasyon örneği
            double[] testPoints = { 0.5, 1.5, 2.5, 3.5 };
            foreach (double point in testPoints)
            {
                double result = spline.Interpolate(point);
                Console.WriteLine($"x = {point}, y = {result}");
            }
        }
    }

}
