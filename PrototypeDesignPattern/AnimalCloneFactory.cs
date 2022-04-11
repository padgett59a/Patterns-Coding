using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class AnimalCloneFactory
    {
        public IAnimal getClone(IAnimal pAnimal)  //can be called for any subclassed object
        {
            //NOTE: this returns base type so must be cast after returned
            return pAnimal.makeShallowCopy();
            //need another call for a deep copy e.g. this.getDeepClone(IAnimal pAnimal)
        }

        //Could implement getShallowClone() for shallow copy and getDeepClone() for deep copy 
    }
}
