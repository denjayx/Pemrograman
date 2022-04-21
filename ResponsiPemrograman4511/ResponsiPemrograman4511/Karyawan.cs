using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4511
{
    internal class Karyawan
    {
        //properties
        private int nik;
        private string nama;
        private int gajiBulanan;

        //constructor
        public int Nik
        {
            get { return nik; }
            set { nik = value; }
        }
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
        public int Gaji
        {
            get { return gajiBulanan; }
            set { gajiBulanan = value; }
        }

        //conttructor
        public Karyawan()
        {
            nik = 4511;
            nama = "Paijo";
            gajiBulanan = 3000000;
        }

        public void Paijo()
        {
            Console.WriteLine("Nik  : {0}", Nik);
            Console.WriteLine("Nama : {0}", Nama);
            Console.WriteLine("Nama : {0}", Gaji);
        }
        public void PaijoNaikGaji()
        {
            Console.WriteLine("Paijo Naik Gaji : {0}",(Gaji + (10 * Gaji)/100));
        }

        public void Jono()
        {
            Console.WriteLine("Nik  : {0}", Nik);
            Console.WriteLine("Nama : {0}", Nama);
            Console.WriteLine("Nama : {0}", Gaji);
        }
        public void JonoNaikGaji()
        {
            Console.WriteLine("Paijo Naik Gaji : {0}", (Gaji + (10 * Gaji) / 100));
        }
    }
}
