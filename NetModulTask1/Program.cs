using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetModulTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int alas;
            int tinggi;
            int hitung;
            Console.Write("Masukan Alas :");
            alas = int.Parse(Console.ReadLine());
            Console.Write("Masukan Tinggi :");
            tinggi = int.Parse(Console.ReadLine());
            if (alas < 0 || tinggi < 0)
            {
                Console.WriteLine("Sorry must input positive number");
            }
            else
            {
                hitung = alas * tinggi / 2;
                Console.WriteLine("Hasil Perhitungan :" + hitung);
            }
            Console.ReadKey();
        }
    }
}
