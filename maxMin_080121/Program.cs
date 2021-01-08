using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxMin
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Bu ödevi yaparken ilk dizideki sayıları karşılaştırmak gerekiyor. Kendim bir sayı referans sayısı 
             * verirsem eğer dizideki herhangi bir sayı referans sayımdan büyük veya küçük olabilir. Bundan dolayı 
             * dizinin ilk elemanını en büyük ve en küçük sayı olarak atadım ve sonra diziyi sırayla gezerek 
             * karşılaştırma yaptım. Dizinin ortalamasını bulabilmek için tüm elemanlarının toplamını bulmam 
             * gerekiyordu ilk. İkinci bir döngüye girmemek için bunu da aynı döngü içinde topladım. */

            Console.Write("Kaç adet sayı girmek istersiniz? : ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[len];

            for (int i = 0; i < len; i++)
            {
                Console.Write("Sayı giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxNum = sayilar[0];
            int minNum = sayilar[0];
            int sum = sayilar[0];

            for (int i = 1; i < len; i++)
            {
                sum += sayilar[i];

                if (sayilar[i] > maxNum)
                    maxNum = sayilar[i];

                if (sayilar[i] < minNum)
                    minNum = sayilar[i];
            }

            double ortalama = (double)sum / len; 

            Console.WriteLine($"En büyük sayı : {maxNum}");
            Console.WriteLine($"En küçük sayı : {minNum}");
            Console.WriteLine(sum);
            Console.WriteLine($"Dizinin ortalaması : {ortalama}");

            Console.ReadLine();
        }
    }
}
