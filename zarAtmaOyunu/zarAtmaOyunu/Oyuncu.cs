using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarAtmaOyunu
{
    class Oyuncu
    {
        // Oyuncunun adı olur
        public string Ad { get; set; }

        // Oyuncunun attığı zarın değeri olur
        public Zar OyuncununZarı { get; set; }
        public Bahis OyuncununBahsi { get; set; }

        public Oyuncu(string isim)
        {
            Ad = isim;
            OyuncununZarı = new Zar();
            OyuncununBahsi = new Bahis();
        }

        public void BahisOyna(int bahis)
        {
            OyuncununBahsi.BahsiBelirle(bahis);
        }

        public void Oyna()
        {
            OyuncununZarı.zarAt();
        }
    }
}
