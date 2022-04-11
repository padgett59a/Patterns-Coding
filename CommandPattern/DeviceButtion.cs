using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //The Invoker. It does not know what device or command is being used until instantiation
    public class DeviceButton
    {
        ICommand theCommand;  //Command 'knows' which target (device) and all other state details needed

        public DeviceButton(ICommand pCommand) //by composition
        {
            theCommand = pCommand;
        }

        //this is called by the button
        public void press()
        {
            theCommand.Execute();
        }
    }
}
