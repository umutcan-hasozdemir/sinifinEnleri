using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinifinEnleri

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c, EnBuyuk = -1500, EnKucuk = +1500, yer = 0;
            double ortalama = 0;
            double toplamNot = 0;
            String[] A = { "Burak", "Fatma", "Yaver", "Mali", "Umut", "Can", "Haci" };
            int[] B = { 46, 58, 99, 12, 99, 87, 61 };
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] >= EnBuyuk)
                {
                    EnBuyuk = B[c];
                }
            }
            Console.WriteLine("En yüksek Not = " + EnBuyuk);
            Console.WriteLine("En yüksek not alan kişiler:");
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] == EnBuyuk)
                {
                    Console.WriteLine(A[c]);
                }
            }
            for (c = 0; c < B.Length; c++)
            {
                if (B[c] <= EnKucuk)
                {
                    EnKucuk = B[c];
                }
            }

            Console.WriteLine("en düşük not=" + EnKucuk);
            Console.WriteLine("en düşük notu alan kişi : ");

            for (c = 0; c < B.Length; c++)
            {
                if (B[c] == EnKucuk)
                {
                    Console.WriteLine(A[c]);
                }
            }

            for (c = 0; c <= B.Length - 1; c++)
            {
                toplamNot += +B[c];
            }
            ortalama = toplamNot / B.Length;
            Console.WriteLine("ORTALAMA: " + ortalama);
            Console.ReadLine();

        }
    }
}
