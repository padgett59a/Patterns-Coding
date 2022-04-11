using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Television : IElectronicDevice
    {
        public void off()
        {
            Console.WriteLine("TV is off");
        }

        public void on()
        {
            Console.WriteLine("TV is on");
        }

        public void volumeDown()
        {
            Console.WriteLine("TV volume up");
        }

        public void volumeUp()
        {
            Console.WriteLine("TV volume down");
        }
    }
}
