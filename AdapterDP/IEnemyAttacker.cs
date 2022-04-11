using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDP
{
    public interface IEnemyAttacker
    {
        public void fireWeapon();
        public void driveFoward();
        public void assignDriver(String pDriver);

    }
}
