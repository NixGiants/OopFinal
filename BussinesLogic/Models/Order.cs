using BussinesLogic.Interfaces;

namespace BussinesLogic.Models
{
    public class Order
    {
        public ApplicationUser? UserInOrder { get; set; }
        public Basket? BasketInOrder { get; set; }
        public IPaymentMethod? PaymentInfo { get; set; }
        public IShipmentMethod? ShipmentInfo{ get; set; }

        public Order(ApplicationUser? userInOrder, Basket? basketInOrder, IPaymentMethod? paymentInfo, IShipmentMethod? shipmentInfo)
        {
            UserInOrder = userInOrder;
            BasketInOrder = basketInOrder;
            PaymentInfo = paymentInfo;
            ShipmentInfo = shipmentInfo;
        }

        public void PayForOrder()
        {
            Console.WriteLine("Success Payment");
        } 

        public override string ToString()
        {
            string res = "";
            res += $"{UserInOrder}\n{BasketInOrder}";
            return res;
        }
    }
}
