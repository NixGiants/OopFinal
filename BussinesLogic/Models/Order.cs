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

        public void ShortOrderInfo()
        {
            var anon = BasketInOrder.GetAvilableProducts().Select(n => new {
                ProdName = n.Name,
                Brand = n.Brand,
                Price = n.Price,
                FirstName = UserInOrder.FirstName,
                LastName = UserInOrder.LastName,
                Access = UserInOrder.Access
            });

            foreach (var p in anon)
            {
                Console.WriteLine($"{p.Access} {p.FirstName} {p.LastName} order product with " +
                    $"name: {p.ProdName}, brand: {p.Brand}, price: {p.Price}  ");
            }
        }
    }
}
