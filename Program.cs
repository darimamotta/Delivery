using GeoCoordinatePortable;
using System.Data.Common;
using System.Linq.Expressions;
using System.Transactions;

namespace Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStrategy strategy = new MinimalDistanceStrategy();
            Repository repo = new Repository(strategy);

            List <Courier> couriers = new List<Courier>();

            GeoCoordinate locCour1 = new GeoCoordinate(47.381350,8.513020);
            Courier courier1 = new Courier("Ivan", "79241234568", 15, locCour1 );
            GeoCoordinate locCour2 = new GeoCoordinate(47.387430,8.493970);
            Courier courier2 = new Courier("Sergey","41231465327",75, locCour2);
            couriers.Add(courier1);
            couriers.Add(courier2);   
            
            //List <Order> orders = new List<Order>();
            GeoCoordinate orderloc1 = new GeoCoordinate(47.372340,8.532990);
            GeoCoordinate orderdest1 = new GeoCoordinate(47.326780,8.800730);
            Order order1 = repo.AddOrder(3, orderloc1, orderdest1);
            //orders.Add(order1);
            repo.AddCourier(courier1);
            repo.AssignCourier(order1);
            //repo.AddOrder(5, orderloc1, orderdest1);


            Console.WriteLine($"Your order is on the way! Order's number is {order1.Number} and courier's name is {order1.Courier.Name}");
           

           
        }
    }
}