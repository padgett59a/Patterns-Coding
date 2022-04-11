using System;

namespace CommandPattern
{
    //The client code
    public class UseRemote
    {
        public static void Main(string[] args)
        {
            //choose Invoker (TV remote) and get the device from the it (Television)
            IElectronicDevice newDevice = TVRemote.getDevice();  //this could also go in Device Button

            //create the command sending in device and any state needed (e.g., newVol = 15)
            TurnTVOn onCommand = new TurnTVOn(newDevice);  //command - abstracts away command details
            
            //create new invoker button and associate with the command
            DeviceButton onPressed = new DeviceButton(onCommand); //invoker
            
            //trigger the command on the invoker Several of these can be queued up in a List and done or undone together
            onPressed.press();  //calls Execute on command

            TurnTVOff offCommand = new TurnTVOff(newDevice);  //command
            DeviceButton offPressed = new DeviceButton(offCommand); //invoker
            offPressed.press();
        }

    }
}
