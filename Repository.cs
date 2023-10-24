using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoCoordinatePortable;

namespace Delivery
{
    internal class Repository
    {
        protected List<Courier> couriers = new List<Courier>();
        protected List<Order> Orders = new List<Order>();
        private IStrategy strategy;

        public Repository(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public Order AddOrder(float weight, GeoCoordinate source, GeoCoordinate destination) 
        {
            int number;
            if (Orders.Count == 0)
                number = 1;
            else number = Orders.Max(t => t.Number)+1;
            Order order = new Order(number, source, destination, weight);
            Orders.Add(order);
            return order;                   
     
        }
        public bool AssignCourier(Order order)
        {
            var courier = strategy.Select(order, couriers);
           
            if (courier == null)
            {
                return false;
            }
            else
            {
                courier.Orders.Add(order);
                order.Courier = courier;
                courier.IsAvailable = false;
                order.DeliveryStartDateTime = DateTime.Now;
                return true;
            }    

                            
        }

        public void CompleteOrder(Order order)
        {
            order.DeliveryEndDateTime = DateTime.Now;
            order.Courier.IsAvailable = true;
            order.Courier.CurrentLocation = order.DestinationPoint;

        }
        public void AddCourier(Courier courier)
        {
            couriers.Add(courier);
        }
    }
}
