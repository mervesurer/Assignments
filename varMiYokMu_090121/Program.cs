using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varMiYokMu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "İstanbul", "İzmir", "Trabzon", "Erzurum", "Isparta", "Kırşehir", "Iğdır", "Ardahan", 
                                "Giresun", "Gaziantep" };
            int len = sehirler.Length;

            Console.Write("Bir şehir giriniz: ");
            string girilenSehir = Console.ReadLine();

            int index; 
            bool varMi = false;

            for(index = 0; index < len; index++)
            {
                Console.Write(sehirler[index]);
                
                if(sehirler[index] == girilenSehir)
                {
                    varMi = true;
                    break; 
                }

                if (index != len - 1)
                {
                    Console.Write(" - ");
                }
            } 
            Console.WriteLine();

            if(varMi)
            {
                Console.WriteLine($"{girilenSehir} listede var ve index numarası: {index}");
            }
            else
            {
                Console.WriteLine($"{girilenSehir} listede yok!");
            }

            Console.ReadLine();
        }
    }
}
