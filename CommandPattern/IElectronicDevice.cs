using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface IElectronicDevice
    {
        public void on();
        public void off();
        public void volumeUp();
        public void volumeDown();
    }
}
