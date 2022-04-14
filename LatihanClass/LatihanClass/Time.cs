using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    internal class Time
    {
        //privar variable atau field
        private int year;
        private int month;
        private int date;
        private int hour;
        private int minute;
        private int second;

        //public method
        public void DisplayCurrentTime()
        {
            Console.WriteLine("Waktu sekarang : {0}", DateTime.Now.ToString());
        }
    }
}
