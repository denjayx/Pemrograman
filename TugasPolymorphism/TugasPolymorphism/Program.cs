using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    class Program
    {
        static void Main(string[] args)

        {
            int nomorPrinter;
            do
            {
                PrinterWindows printer;

                Console.WriteLine("Pilih Printer");
                Console.WriteLine("1. Epson");
                Console.WriteLine("2. Cannon");
                Console.WriteLine("3. LaserJet");
                Console.WriteLine("4. Cancle");

                Console.Write("Nomor Printer [1..3] : ");
                nomorPrinter = Convert.ToInt32(Console.ReadLine());

                if (nomorPrinter == 1)
                {
                    printer = new Epson();
                }
                else if (nomorPrinter == 2)
                {
                    printer = new Cannon();
                }
                else
                {
                    printer = new LaserJet();
                }

                printer.Show();
                printer.Print();
                Console.WriteLine();
            } while (nomorPrinter != 4);
        }
    }
}
