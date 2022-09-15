using BussinesLogic.Interfaces;

namespace BussinesLogic.Models.Shipments
{
    public class CurierShipment : IShipmentMethod
    {
        public void Ship()
        {
            Console.WriteLine("Shiping by curier");
        }
    }
}
