using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubAlgoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // normal çözüm
            Console.WriteLine("Normal Çözüm");
            int[] dizi = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
            int aranan = 12;

            int sonuc = BinaryArama(dizi, aranan);

            if (sonuc != -1) Console.WriteLine("Aranan {0} sayısi {1}. indekste bulundu", aranan, sonuc);
            else Console.WriteLine("sayı bulunamadı");

            // recursive çözüm
            Console.WriteLine();
            Console.WriteLine("Recursive Çözüm");

          
            int left = 0;
            int right = dizi.Length - 1;

            int recursivesonuc = RecursiveBinaryArama(dizi, aranan, left, right);
            if (recursivesonuc != -1) Console.WriteLine("Aranan {0} sayısi {1}. indekste bulundu", aranan, recursivesonuc);
            else Console.WriteLine("Aranan sayı bulunamadı");



        }

        static int BinaryArama(int[] dizi, int aranan)
        {
            int left = 0;
            int right = dizi.Length - 1;

            while (left <= right)
            {
                int orta = left + (right - left) / 2;

                if (dizi[orta] == aranan) return orta;

                if (dizi[orta] > aranan)
                {
                    right = orta - 1;
                }
                else
                {
                    left = orta + 1;
                }
            }
            return -1;
        }

        static int RecursiveBinaryArama(int[] dizi, int aranan, int left, int right)
        {
            if (left <= right)
            {
                int orta = left + (right - left) / 2;

                if (dizi[orta] == aranan) return orta;

                if (dizi[orta] > aranan) return RecursiveBinaryArama(dizi, aranan, left, orta - 1);
                else return RecursiveBinaryArama(dizi, aranan, left + 1, right);
            }
            return -1;
        }
    }
}
