using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Title = "Aplikasi Calculator C# Deni Wijaya"; 

            // daftar pilihan menu
            Console.WriteLine("Operator Tersedia");            
            Console.WriteLine("1. Penambahan ");       
            Console.WriteLine("2. Pengurangan ");       
            Console.WriteLine("3. Perkalian ");       
            Console.WriteLine("4. Pembagian ");
            // input pilihan
            Console.Write("Pilih operator yang dibutuhkan ");
            int pilihan = Convert.ToInt32(Console.ReadLine());

            if (pilihan == 1)
            {
                // input nilai a
                Console.Write("Inputkan nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                // input nilai b
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (pilihan == 2)
            {
                // input nilai a
                Console.Write("Inputkan nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                // input nilai b
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Penambahan " + a + " - " + b + " = " + Pengurangan(a, b));
            }
            else if (pilihan == 3)
            {
                // input nilai a
                Console.Write("Inputkan nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                // input nilai b
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Penambahan " + a + " * " + b + " = " + Perkalian(a, b));
            }
            else if (pilihan == 4)                                                                                                                                                           
            {   
                // input nilai a
                Console.Write("Inputkan nilai a = ");
                int a = Convert.ToInt32(Console.ReadLine());
                // input nilai b
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Hasil Penambahan " + a + " / " + b + " = " + Pembagian(a, b));
            }
            else if (pilihan == 0 || pilihan > 4) {
                Console.WriteLine("Pilihan yang anda masukkan salah");
            }

            Console.WriteLine("Tekan Sembarang Untuk Keluar");
            Console.ReadKey();
        }
         static int Penambahan (int a, int b) {
                return a + b;
            }
        static int Pengurangan (int a, int b) {
            return a - b;
        }
        static int Perkalian (int a, int b) {
            return a * b;
        }
        static int Pembagian (int a, int b) {
            return a / b;
        }
    }
}