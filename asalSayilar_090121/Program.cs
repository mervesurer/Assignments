using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asalSayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int sayi = 2; sayi <= 10000; sayi++)
            {
                bool asalMi = true; 

                for (int bolen = 2; bolen <= sayi / 2; bolen++)
                {
                    if (sayi % bolen == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }

                if (asalMi)
                {
                    Console.WriteLine($"{sayi} asaldır!!");
                }
            }

            Console.ReadLine();
        }
    }
}
