using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolidromSorusu
{
    class Program
    {

        class Hesaplama
        {

            public bool AsalKontrol(int sayi)
            {
                for (int i = 2; i<sayi; i++)
                {

                    if (sayi % i == 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            public bool Palindrom(int sayi)
            {
                int IslemSayi, b, toplam = 0;

                IslemSayi = sayi;
                while (IslemSayi > 0)
                {
                    b = IslemSayi % 10;
                    toplam = (toplam * 10) + b;
                    IslemSayi = IslemSayi / 10;
                }

                if (sayi == toplam)
                    return true;
                else
                    return false;
            }

        }

        


        static void Main(string[] args)
        {
            Hesaplama Sayi = new Hesaplama();

            for (int i = 0; i <= 200; i++)
            {
               if(Sayi.Palindrom(i) == true && Sayi.AsalKontrol(i) ==true)
                {

                    Console.WriteLine(i.ToString());
                }
                
            }
         
     

        }
    }
}
