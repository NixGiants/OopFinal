
namespace BussinesLogic.Models
{
    public class User : Credentials
    {
        public Basket? UsersBasket { get; set; }
        public Order? UsersOrder{ get; set; }
    }
}
