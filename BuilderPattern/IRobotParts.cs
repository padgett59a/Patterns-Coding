using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //Parts every robot must have
    //Robot Plan
    public interface IRobotParts
    {
        public string robotHead { get; set; }
        public string robotTorso { get; set; }
        public string robotArms { get; set; }
        public string robotLegs { get; set; }
    }
}
