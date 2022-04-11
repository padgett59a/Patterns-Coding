using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //this is the ‘encapsulation package’ or command object
    public class TurnTVOff : ICommand
    {
        IElectronicDevice theDevice;

        public TurnTVOff(IElectronicDevice pDevice)
        {
            //e.g., the Television
            theDevice = pDevice;
        }

        //this is called by the button
        public void Execute()
        {
            theDevice.off();
        }
        public void Undo()
        {
            theDevice.on();
        }
    }
}
