
namespace BussinesLogic.Models
{
    public class Review
    {
        public ApplicationUser? UserFrom { get; set; }
        public string? Text { get; set; }

        public Review(ApplicationUser? userFrom, string? text)
        {
            UserFrom = userFrom;
            Text = text;
        }
    }
}
