using BussinesLogic.Interfaces;

namespace BussinesLogic.Models.Payment
{
    public class GooglePay : IPaymentMethod
    {
        public void Pay()
        {
            Console.WriteLine("Handling GooglePay payment");
        }
    }
}
