using BussinesLogic.Enums;

namespace BussinesLogic.Models
{
   

    public class Credentials 
    {
        protected string? Login { get; set; }
        protected string? Password { get; set; }
        protected Access Access { get; set; }
    }
}
