
using BussinesLogic.Interfaces;
namespace BussinesLogic.Models
{
    public class Product 
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public Discount? Reduction { get; set; }
        public decimal Price { get; set; }
        public ICategory CategoryOfProduct { get; set; } //not null
        public bool IsAvailable { get; set; }

        public Product(string name, string brand, string description, Discount reduction, decimal price, ICategory categoryOfProduct, bool isAvailable)
        {
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(brand) || String.IsNullOrEmpty(description))
                throw new ArgumentException("Name, Brand, Description cant be null or empty");

            else if (price <= 0)
                throw new ArgumentException("Price cant be less or equal to zero");

            else if (categoryOfProduct == null)
                throw new ArgumentException("CategoryOfProduct cant be null");

            Name = name;
            Brand = brand;
            Description = description;
            Reduction = reduction;
            Price = price;
            CategoryOfProduct = categoryOfProduct;
            IsAvailable = isAvailable;
        }

        public void GetPriceFromDiscount(Category category)
        {

            Console.WriteLine("SomeLogic from GetPriceFromDiscount");
        }
    }
}
