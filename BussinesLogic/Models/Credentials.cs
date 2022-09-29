using BussinesLogic.Enums;
using BussinesLogic.Interfaces;

namespace BussinesLogic.Models
{
    public class Credentials 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<IPaymentMethod>? PaymentMethods{ get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Access Access { get; set; }

        public Credentials(string firstName, string lastName, List<IPaymentMethod>? paymentMethods, string login, string password, Access access)
        {
            if (String.IsNullOrEmpty(firstName) || String.IsNullOrEmpty(lastName) || String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Fullname and login with password cant be null or empty");
            }

            FirstName = firstName;
            LastName = lastName;
            PaymentMethods = paymentMethods;
            Login = login;
            Password = password;
            Access = access;
        }

        public bool CheckIsRegistered (string loginCheck, string passwordCheck)
        {
            if(this.Login == loginCheck && this.Password == passwordCheck)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
