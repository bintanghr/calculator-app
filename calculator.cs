using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Menu Kalkulator: ");

            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.WriteLine("Masukkan menu piilihan anda: ");
            int pilihan = int.Parse(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("Inputkan nilai a = ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inputkan nilai b = ");
                    int b = int.Parse(Console.ReadLine()); //konversi / casting
                    Console.WriteLine("Hasil penambahan dari " + a + " + " + b + " = " + Penambahan(a, b));
                    break;

                case 2:
                    Console.WriteLine("Inputkan nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inputkan nilai b = ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil pengurangan dari {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    break;

                case 3:
                    Console.WriteLine("Inputkan nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inputkan nilai b = ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil perkalian dari {0} x {1} = {2}", a, b, Perkalian(a, b));
                    break;

                case 4:
                    Console.WriteLine("Inputkan nilai a = ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Inputkan nilai b = ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Hasil pembagian dari {0} : {1} = {2}", a, b, Pembagian(a, b));
                    break;
            }

            Console.WriteLine("\nTekan sembarang key untuk kelaur");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
