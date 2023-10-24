using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoCoordinatePortable;

namespace Delivery
{
    internal class Order
    {
        public int Number { get; set; }
        public float Weight { get;set; }
        public DateTime DeliveryStartDateTime { get; set; }
        public DateTime DeliveryEndDateTime { get;set; }
        public GeoCoordinate StartPoint { get; set; }
        public GeoCoordinate DestinationPoint { get; set;}
        public Courier Courier { get; set; }

        public Order(int number, GeoCoordinate startPoint, GeoCoordinate destinationPoint,float weight)
        {
            Number = number;
            StartPoint = startPoint;
            DestinationPoint = destinationPoint;
            Weight = weight; 
        }
    }
}
