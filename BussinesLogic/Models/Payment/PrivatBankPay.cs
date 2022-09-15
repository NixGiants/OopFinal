using BussinesLogic.Interfaces;

namespace BussinesLogic.Models.Payment
{
    public class PrivatBankPay : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Handling PrivatBank payment");
        }
    }
}
