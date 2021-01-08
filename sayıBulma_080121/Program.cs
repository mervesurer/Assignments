using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiBulmaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgeleSayiUretici = new Random();
            string cevap = "Evet";
            while (cevap.Equals("Evet") || cevap.Equals("evet"))
            {
                int sayi = rastgeleSayiUretici.Next(1, 100);
                bool sayiBulunduMu = false;

                while (!sayiBulunduMu)
                {
                    Console.Write("Bir sayı tahmin ediniz: ");
                    int tahmin = Convert.ToInt32(Console.ReadLine());
                    if (sayi > tahmin)
                    {
                        Console.WriteLine("Yukarı!");
                    }
                    else if (sayi < tahmin)
                    {
                        Console.WriteLine("Aşağı!");
                    }
                    else
                    {
                        Console.WriteLine("Bingo! Buldunuz !!");
                        sayiBulunduMu = true;
                    }
                }

                Console.Write("Tekrar oynamak ister misiniz?(Evet/Hayır): ");

                while (true)
                {
                    cevap = Console.ReadLine();
                    if (cevap.Equals("Evet") || cevap.Equals("evet") || cevap.Equals("Hayır") || cevap.Equals("hayır"))
                    {
                        break;
                    }

                    Console.WriteLine("Geçersiz değer girdiniz! Tekrar giriniz! (Evet/Hayır)");
                }

            }
            Console.WriteLine("Oyunu bitirdiniz!!");
            Console.ReadLine();
        }

    }
}
