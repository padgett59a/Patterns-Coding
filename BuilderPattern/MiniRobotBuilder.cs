using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //Concrete class for building Retro model from base Robot
    //Specific instructions for building Retro model
    class MiniRobotBuilder : IRobotBuilder
    {

        //OldRobotBuilder
        public MiniRobotBuilder()
        {
            //Get base robot
            this.robot = new Robot();
        }

        private Robot robot;

        public void buildRobotHead()
        {
            robot.robotHead = "Mini Head";
        }

        public void buildRobotLegs()
        {
            robot.robotLegs = "Little Legs";
        }

        public void buildRobotTorso()
        {
            robot.robotTorso = "Tiny Torso";
        }
        public void buildRobotArms()
        {
            robot.robotArms = "Pencil Arms";
        }

        public Robot getRobot()
        {
            return this.robot;
        }
    }
}
