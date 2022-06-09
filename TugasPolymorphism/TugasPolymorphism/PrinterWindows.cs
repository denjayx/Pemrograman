using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class PrinterWindows
    {
        public string Name { get; set; }
        public virtual void Show()
        {
            Console.WriteLine("Printer Display");
        }
        public virtual void Print()
        {
            Console.WriteLine("Printer is Printing");
        }
    }
}
