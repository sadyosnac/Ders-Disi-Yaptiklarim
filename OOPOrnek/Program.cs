namespace OOPOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Araba benimArabam = new Araba();
            benimArabam.hiz = 0;
            benimArabam.ureticiFirma = "BMW";
            benimArabam.model = "X6";
            benimArabam.uretimYili = 2011;
            benimArabam.km = 1000;

            Console.WriteLine("Üretici Firma..: " + benimArabam.ureticiFirma + " Araba Modeli..:" + benimArabam.model);

            benimArabam.Hizlandir();
            benimArabam.Hizlandir();
            benimArabam.Hizlandir();
            benimArabam.Hizlandir();
            benimArabam.Hizlandir();
            benimArabam.Yavaslat();

            Console.WriteLine("Şuanki Hızınız..: " + benimArabam.hiz);

        }
    }
}
