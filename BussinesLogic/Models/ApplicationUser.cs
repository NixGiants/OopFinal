using BussinesLogic.Enums;
using BussinesLogic.Interfaces;


namespace BussinesLogic.Models
{
    public class ApplicationUser : Credentials
    {
        public ApplicationUser(string firstName, string lastName, List<IPaymentMethod>? paymentMethods, string login, string password, Access access) : base(firstName, lastName, paymentMethods, login, password, access)
        {
        }

        public override string ToString()
        {
            string res = $"User login: {this.Login}\nWith full name {this.FirstName} {this.LastName}";
            return res;
        }
    }
}
