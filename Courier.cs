using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoCoordinatePortable;

namespace Delivery
{
    internal class Courier
    {
        public Courier(string name, string phoneNumber, float maxWeight, GeoCoordinate currentLocation)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            MaxWeight = maxWeight;
            CurrentLocation = currentLocation;
            IsAvailable = true;
        }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public float MaxWeight { get; set; }
        public bool IsAvailable { get; set; }

        public GeoCoordinate CurrentLocation { get; set; }

        public List<Order> Orders { get; set; } =new List<Order>();

        
    }
}
