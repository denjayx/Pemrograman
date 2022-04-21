using System;
namespace ResponsiPemrograman4511
{
    public class Program
    {
        static void Main(string[] args)
        {
            Karyawan objJono = new Karyawan();
            Karyawan objPaijo = new Karyawan();

            //paijo
            objJono.Nama = "Paijo";
            objJono.Nik = 4511;
            objJono.Gaji = 3000000;

            //jono
            objJono.Nama = "Jono";
            objJono.Nik = 4512;
            objJono.Gaji = 2000000;

            objPaijo.Paijo();
            objPaijo.PaijoNaikGaji();
            Console.WriteLine("-------------------------------------");
            objJono.Jono();
            objJono.JonoNaikGaji();
        }
    }
}