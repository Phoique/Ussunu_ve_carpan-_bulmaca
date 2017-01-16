using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ussunu_ve_carpanı_bulmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcı bir değer girecek ve biz bu değerin üssünü ve tabanını bulacağız.
            /* X^ = Y
               X = taban
               ^ = üs
               Y = Kullanıcının sayısı
             */
            byte x, u;
            double us;
            Console.Write("Üssünü ve çarpanı bulunacak sayıyı giriniz: ");
            int ks = Convert.ToInt32(Console.ReadLine());
            for (x = 1; x < 10; x++)
            {
                for (u = 2; u < 10; u++)
                {
                    us = Math.Pow(x,u);
                    if (us == ks)
                    {
                        Console.Write("Sayınızın üssünü ve çarpanını bulduk, \nSayınız: {0} \nÇarpanı: {1} \nÜssü: {2}" ,ks,x,u);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
            }
            Console.WriteLine("Sayınızın çarpanını ve üssünü bulamadık.");
            Console.ReadLine();
        }
    }
}
