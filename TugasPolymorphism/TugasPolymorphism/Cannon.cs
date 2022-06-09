using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolymorphism
{
    public class Cannon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Cannon Display Dimension : 9.5*12");
        }
        public override void Print()
        {

            Console.WriteLine("Cannon printer printing...");
        }
    }
}
