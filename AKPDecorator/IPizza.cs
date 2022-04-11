using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AKPDecorator
{
    public interface IPizza
    {
        public string getDescription();
        public decimal getTotalPrice();
    }
}
