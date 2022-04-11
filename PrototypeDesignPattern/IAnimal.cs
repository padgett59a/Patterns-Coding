using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public interface IAnimal : ICloneable  //allow full copies to be made [not just the reference]
    {
        public IAnimal makeShallowCopy();
    }
}
