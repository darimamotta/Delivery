using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    internal class MinCountStrategy:IStrategy
    {
        public Courier Select(Order order, List<Courier> list)
        {
            var listCouriers = list.Where(t => t.IsAvailable && t.MaxWeight > order.Weight);
            listCouriers = listCouriers.OrderBy(t => t.Orders.Count);
            Courier courier = listCouriers.FirstOrDefault();
            return courier;
        }
    }
}
