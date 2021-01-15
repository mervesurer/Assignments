using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zarAtmaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * Bu oyunda iki oyuncu vardır
             * Her oyuncunun bir zarı ve girdiği bahsi vardır
             * Oyuncular zar atar
             * Zarlar karşılaştırılır
             * Büyük olan turu kazanır
             * Bahis miktarı sıfırlanan oyunu kaybeder
             * 
             * Nesneler: 
             * Oyun
             * Oyuncu
             * Zar
             * Bahis
            */
        }

        // Her iki oyuncu için de aynı oyunu oynayacağımız için oyun nesnesini globalde tanımlıyoruz. 
        Oyun zarOyunu = new Oyun();

        private void buttonOyuncu1Ad_Click(object sender, EventArgs e)
        {
            string oyuncuAdı = textBoxOyuncu1Ad.Text;
            zarOyunu.BirinciOyuncu = new Oyuncu(oyuncuAdı);

            labelOyuncu1Ad.Text = textBoxOyuncu1Ad.Text;
        }

        private void buttonOyuncu2Ad_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncu = new Oyuncu(textBoxOyuncu2Ad.Text);

            labelOyuncu2Ad.Text = textBoxOyuncu2Ad.Text;
        }

        private void buttonOyuncu1Bahis_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuBahisOyna(Convert.ToInt32(textBoxOyuncu1Bahis.Text));

            labelOyuncu1Bahis.Text = zarOyunu.BirinciOyuncu.OyuncununBahsi.Deger.ToString();

            labelOyunuKazanan.Text = "Oyunu Kazanan: ";

            buttonOyuncu2Bahis.Enabled = true;
        }

        private void buttonOyuncu2Bahis_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncuBahisOyna(Convert.ToInt32(textBoxOyuncu2Bahis.Text));

            labelOyuncu2Bahis.Text = zarOyunu.IkinciOyuncu.OyuncununBahsi.Deger.ToString();

            zarOyunu.BahisBelirle();

            labelOyununBahsi.Text = zarOyunu.OyunBahsi.Deger.ToString();

            buttonOyunaBasla.Enabled = true;
        }

        private void buttonOyunaBasla_Click(object sender, EventArgs e)
        {
            buttonOyuncu1Zar.Enabled = true;
        }

        private void buttonOyuncu1Zar_Click(object sender, EventArgs e)
        {
            zarOyunu.IlkOyuncuZarAt();
            labelOyuncu1Zar.Text = zarOyunu.BirinciOyuncu.OyuncununZarı.Deger.ToString();

            buttonOyuncu2Zar.Enabled = true;
        }

        private void buttonOyuncu2Zar_Click(object sender, EventArgs e)
        {
            zarOyunu.IkinciOyuncuZarAt();

            labelOyuncu2Zar.Text = zarOyunu.IkinciOyuncu.OyuncununZarı.Deger.ToString();

            Oyuncu kazanan = zarOyunu.Oyna();

            if (kazanan == zarOyunu.BirinciOyuncu)
                labelKazanan.Text = $"Turu kazanan : {zarOyunu.BirinciOyuncu.Ad}";
            else if (kazanan == zarOyunu.IkinciOyuncu)
                labelKazanan.Text = $"Turu kazanan : {zarOyunu.IkinciOyuncu.Ad}";
            else
                labelKazanan.Text = $"Berabere";

            labelOyuncu1Bahis.Text = zarOyunu.BirinciOyuncu.OyuncununBahsi.Deger.ToString();
            labelOyuncu2Bahis.Text = zarOyunu.IkinciOyuncu.OyuncununBahsi.Deger.ToString();

            oyunBittiMi();
        }

        private void oyunBittiMi()
        {
            if (zarOyunu.BirinciOyuncu.OyuncununBahsi.Deger <= 0 || zarOyunu.IkinciOyuncu.OyuncununBahsi.Deger <= 0)
            {
                if (zarOyunu.BirinciOyuncu.OyuncununBahsi.Deger <= 0)
                    labelOyunuKazanan.Text = $"Oyunu kazanan: {zarOyunu.IkinciOyuncu.Ad}!";
                else
                    labelOyunuKazanan.Text = $"Oyunu kazanan: {zarOyunu.BirinciOyuncu.Ad}!";

                zarOyunu.BirinciOyuncu.OyuncununBahsi.Deger = 0;
                zarOyunu.IkinciOyuncu.OyuncununBahsi.Deger = 0;
                buttonOyuncu2Bahis.Enabled = false;
                buttonOyunaBasla.Enabled = false;
                buttonOyuncu1Zar.Enabled = false;
                buttonOyuncu2Zar.Enabled = false;
            }
        }
    }
}
