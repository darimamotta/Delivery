using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    internal interface IStrategy
    {
        Courier Select(Order order, List<Courier> list);
    }
}
