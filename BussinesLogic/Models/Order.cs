using BussinesLogic.Interfaces;

namespace BussinesLogic.Models
{
    public class Order
    {
        public ApplicationUser? UserInOrder { get; set; }
        public Basket? BasketInOrder { get; set; }
        public IPaymentMethod? PaymentInfo { get; set; }
        public IShipmentMethod? ShipmentInfo{ get; set; }
    }
}
