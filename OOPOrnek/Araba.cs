using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek
{
    class Araba
    {
        public string ureticiFirma;
        public string model;
        public int uretimYili;
        public string renk;
        public int km;
        public int hiz;

        public void Hizlandir()
        {
            hiz = hiz + 10;
            //hiz += 10;
            Console.WriteLine("Hızlanıyorsunuz!! Şuandaki Hızınız..: " + hiz);
        }

        public void Yavaslat()
        {
            hiz = hiz - 10;
            Console.WriteLine("Yavaşlıyorsunuz!! Şuanki Hızınız..: " + hiz);
        }

    }
}
