using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dosen dosenDefault = new Dosen(1, "Kamarudin", 4539854, "Laki-laki", "Pemrograman");

            dosenDefault.cetakHasil();
            Console.WriteLine();
            dosenDefault.addDosen();
            dosenDefault.addCourse();
            Console.WriteLine();
            dosenDefault.cetakAkhir();

            Console.ReadKey();
        }
    }
}