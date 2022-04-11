using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    // Methods to build the components
    // Method to get the result
    interface IRobotBuilder
    {
        public void buildRobotHead();
        public void buildRobotTorso();
        public void buildRobotArms();
        public void buildRobotLegs();

        public Robot getRobot();
    }
}
