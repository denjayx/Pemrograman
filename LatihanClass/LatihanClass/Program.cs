using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat instan class/object
            Time objTime = new Time();

            //memanggil method pada class tersebut
            objTime.DisplayCurrentTime();

            //objTime.Year = 2003;
            //objTime.Month = 06;
            //objTime.Date = 06;

            //mengambil nilai dengan property
            Console.WriteLine("Waktu Lahirku :");
            Console.WriteLine("Tahun    : {0}", objTime.Year.ToString());
            Console.WriteLine("Bulan    : {0}", objTime.Month.ToString());
            Console.WriteLine("Tanggal  : {0}", objTime.Date.ToString());

        }
    }
}
