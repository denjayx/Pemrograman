using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
       static void Main(String[] args)
        {
            int hasil;
            Calculator calculator = new Calculator();

            hasil = calculator.Penjumlahan(5, 2);
            CetakHasil("Hasil Penjumlahan 2 Bilangan : " + hasil);

            hasil = calculator.Penjumlahan(5, 2, 5);
            CetakHasil("Hasil Penjumlahan 3 Bilangan : " + hasil);

            hasil = calculator.Pengurangan(5, 2);
            CetakHasil("Hasil Pengurangan 2 Bilangan : " + hasil);

            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil Perkalian 2 Bilangan : " + hasil);
        }
        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
