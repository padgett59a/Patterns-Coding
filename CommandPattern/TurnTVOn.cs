using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //this is the ‘encapsulation package’ or command object
    public class TurnTVOn : ICommand
    {
        IElectronicDevice theDevice;

        public TurnTVOn(IElectronicDevice pDevice)
        {
            theDevice = pDevice;
        }

        //this is called by the button
        public void Execute()
        {
            theDevice.on();
        }
        public void Undo()
        {
            theDevice.off();
        }
    }
}
