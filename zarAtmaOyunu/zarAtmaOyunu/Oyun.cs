using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarAtmaOyunu
{
    class Oyun
    {
        public Oyuncu BirinciOyuncu { get; set; }
        public Oyuncu IkinciOyuncu { get; set; }
        public Bahis OyunBahsi { get; set; }

        public Oyun()
        {
            OyunBahsi = new Bahis();
        }

        public void IlkOyuncuZarAt()
        {
            BirinciOyuncu.Oyna();
        }

        public void IkinciOyuncuZarAt()
        {
            IkinciOyuncu.Oyna();
        }

        public void IlkOyuncuBahisOyna(int bahis)
        {
            BirinciOyuncu.BahisOyna(bahis);
        }

        public void IkinciOyuncuBahisOyna(int bahis)
        {
            IkinciOyuncu.BahisOyna(bahis);
        }

        public void BahisBelirle()
        {
            if (BirinciOyuncu.OyuncununBahsi.Deger <= IkinciOyuncu.OyuncununBahsi.Deger)
                OyunBahsi.Deger = BirinciOyuncu.OyuncununBahsi.Deger;
            else
                OyunBahsi.Deger = IkinciOyuncu.OyuncununBahsi.Deger;
        }

        private Oyuncu Karsilastir()
        {
            if (BirinciOyuncu.OyuncununZarı.Deger > IkinciOyuncu.OyuncununZarı.Deger)
                return BirinciOyuncu;
            else if (BirinciOyuncu.OyuncununZarı.Deger < IkinciOyuncu.OyuncununZarı.Deger)
                return IkinciOyuncu;
            else
                return null;
        }

        public Oyuncu Oyna()
        {

            Oyuncu kazanan = Karsilastir();

            if (kazanan == BirinciOyuncu)
            {
                BirinciOyuncu.OyuncununBahsi.Deger += OyunBahsi.Deger;
                IkinciOyuncu.OyuncununBahsi.Deger -= OyunBahsi.Deger;
                return BirinciOyuncu;
            }
            else if (kazanan == IkinciOyuncu)
            {
                BirinciOyuncu.OyuncununBahsi.Deger -= OyunBahsi.Deger;
                IkinciOyuncu.OyuncununBahsi.Deger += OyunBahsi.Deger;
                return IkinciOyuncu;
            }
            else
                return null;
        }
    }
}
