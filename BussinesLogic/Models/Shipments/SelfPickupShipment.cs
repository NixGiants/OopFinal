using BussinesLogic.Interfaces;

namespace BussinesLogic.Models.Shipments
{
    public class SelfPickupShipment : IShipmentMethod
    {
        public void Ship()
        {
            Console.WriteLine("Shipment by yourself");
        }
    }
}
