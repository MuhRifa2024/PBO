using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714240044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Soal ===");
            Console.WriteLine("Masukan angka pertama= ");
            double angka1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukan angka kedua= ");
            double angka2 = Convert.ToDouble(Console.ReadLine());

             var hasil = angka1 + angka2;
             var hasil2 = angka1 - angka2;
             var hasil3 = angka1 * angka2;
             var hasil4 = angka1 / angka2;
            Console.WriteLine($"{angka1} + {angka2} = {hasil}");
            Console.WriteLine($"{angka1} - {angka2} = {hasil2}");
            Console.WriteLine($"{angka1} x {angka2} = {hasil3}");
            Console.WriteLine($"{angka1} : {angka2} = {hasil4}");


        }
    }
}
