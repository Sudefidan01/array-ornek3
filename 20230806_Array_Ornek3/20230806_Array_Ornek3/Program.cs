using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230806_Array_Ornek3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ornek 3
            //Kullanıcıdan 5 adet sayı talep edelim
            //Talep edilen sayıların 3 'e tam bölünebilenlerini ekrana yazdıralım

            int[] sayilar = new int[5];


            //1.Yöntem
            Console.Write("1.Sayıyı Giriniz : ");
            sayilar[0] = int.Parse(Console.ReadLine());

            Console.Write("2.Sayıyı Giriniz : ");
            sayilar[1] = int.Parse(Console.ReadLine());

            Console.Write("3.Sayıyı Giriniz : ");
            sayilar[2] = int.Parse(Console.ReadLine());

            Console.Write("4.Sayıyı Giriniz : ");
            sayilar[3] = int.Parse(Console.ReadLine());

            Console.Write("5.Sayıyı Giriniz : ");
            sayilar[4] = int.Parse(Console.ReadLine());

            if (sayilar[0] % 3 == 0)
            {
                Console.WriteLine("1.Sayı 3'e Tam Bölünüyor : " + sayilar[0]);
            }

            if (sayilar[1] % 3 == 0)
            {
                Console.WriteLine("2.Sayı 3'e Tam Bölünüyor : " + sayilar[1]);
            }
            if (sayilar[2] % 3 == 0)
            {
                Console.WriteLine("3.Sayı 3'e Tam Bölünüyor : " + sayilar[2]);
            }
            if (sayilar[3] % 3 == 0)
            {
                Console.WriteLine("4.Sayı 3'e Tam Bölünüyor : " + sayilar[3]);
            }
            if (sayilar[4] % 3 == 0)
            {
                Console.WriteLine("5.Sayı 3'e Tam Bölünüyor : " + sayilar[4]);
            }

            //2.Yöntem

            //for (int i = 0; i <sayilar.Length; i++)
            //{
            //    Console.Write((i+1)+".Sayıyı Giriniz : ");
            //    sayilar[i] = int.Parse(Console.ReadLine());
            //}

            //2-1. Yöntem
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] % 3 == 0)
            //    {
            //        Console.WriteLine((i+1)+" .Sayı 3'e Tam Bölünüyor : " + sayilar[i]);
            //    }
            //}


            //2-2 Yöntem
            //foreach (var dizidekiSayilar in sayilar)
            //{
            //    if (dizidekiSayilar %3 ==0)
            //    {
            //        Console.WriteLine("3'e bölünen sayı : "+dizidekiSayilar);
            //    }
            //}

            Console.ReadKey();
        }
    }
}
