using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //Concrete class for building Retro model from base Robot
    //Specific instructions for building Retro model
    class RetroRobotBuilder : IRobotBuilder
    {

        //OldRobotBuilder
        public RetroRobotBuilder()
        {
            //Get base robot
            this.robot = new Robot();
        }

        private Robot robot;       

        public void buildRobotHead()
        {
            robot.robotHead = "Tin Head";
        }

        public void buildRobotLegs()
        {
            robot.robotLegs = "Roller Skates";
        }

        public void buildRobotTorso()
        {
            robot.robotTorso = "Tin Torso";
        }
        public void buildRobotArms()
        {
            robot.robotArms = "Blowtorch Arms";
        }

        public Robot getRobot()
        {
            return this.robot;
        }
    }
}
