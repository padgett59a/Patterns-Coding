using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //Robot Engineer/Director
    class RobotDirector
    {
        //Constructor - Send in the concrete builder (DI)
        public RobotDirector(IRobotBuilder pRobotBuilder)
        {
            robotBuilder = pRobotBuilder;
        }
        private IRobotBuilder robotBuilder;

        public Robot getRobot()
        {
            return this.robotBuilder.getRobot();
        }
        public void makeRobot()
        {
            //Execute Bulder methods to decorate the robot 
            //composed fields
            this.robotBuilder.buildRobotHead();
            this.robotBuilder.buildRobotTorso();
            this.robotBuilder.buildRobotLegs();
            this.robotBuilder.buildRobotArms();
        }


    }
}
