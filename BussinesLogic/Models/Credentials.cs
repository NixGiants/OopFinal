using BussinesLogic.Enums;
using BussinesLogic.Interfaces;

namespace BussinesLogic.Models
{
    public class Credentials 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<IPaymentMethod>? PaymentMethods{ get; set; }
        protected string? Login { get; set; }
        protected string? Password { get; set; }
        protected Access Access { get; set; }
    }
}
