using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery
{
    internal class MinimalDistanceStrategy : IStrategy
    {
        public Courier Select(Order order, List<Courier> list)
        {
            var listCouriers = list.Where(t => t.IsAvailable && t.MaxWeight > order.Weight);
            listCouriers = listCouriers.OrderBy(t => t.CurrentLocation.GetDistanceTo(order.StartPoint));
            Courier courier = listCouriers.FirstOrDefault();
            return courier;
        }
    }
}
