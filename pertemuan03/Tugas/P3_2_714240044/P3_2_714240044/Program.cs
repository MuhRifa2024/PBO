using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714240044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENU PERSEGI PANJANG ===");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Pilih menu (1-3): ");
                int pilihan = int.Parse(Console.ReadLine());

                if (pilihan == 1)
                {
                    Console.Write("\nMasukan Panjang: ");
                    double panjang = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukan Lebar: ");
                    double lebar = Convert.ToDouble(Console.ReadLine());
                    double luas = panjang * lebar;
                    Console.WriteLine("Luas Persegi Panjang: " + luas);
                }
                else if (pilihan == 2)
                {
                    Console.Write("\nMasukan Panjang: ");
                    double panjang = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukan Lebar: ");
                    double lebar = Convert.ToDouble(Console.ReadLine());
                    double keliling = 2 * (panjang + lebar);
                    Console.WriteLine("Keliling Persegi Panjang: " + keliling);
                }
                else if (pilihan == 3)
                {
                    Console.WriteLine("Program selesai");
                    Console.WriteLine("Terimakasih!");
                    break;
                }
                else
                {
                    Console.WriteLine("Menu tidak tersedia. Silakan pilih menu yang valid.");
                }
                Console.Write("\nIngin mengulang Kembali (Y/T)? ");
            }
            while (Console.ReadLine() == "Y");
        }
    }
}
