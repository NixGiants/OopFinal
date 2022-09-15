
using BussinesLogic.Interfaces;
namespace BussinesLogic.Models
{
    public class Product 
    {
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public string? Description { get; set; }
        public Discount? Reduction { get; set; }
        public decimal Price { get; set; }
        public ICategory? CategoryOfProduct { get; set; } //not null
        public bool IsAvailable { get; set; }

        public void GetPriceFromDiscount(Category category)
        {

            Console.WriteLine("SomeLogic from GetPriceFromDiscount");
        }
    }
}
