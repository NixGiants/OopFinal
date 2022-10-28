using BussinesLogic.Interfaces;
using BussinesLogic.Models.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Models
{
    public class Linq_Panasenko
    {
        private List<Product> products;

        public Linq_Panasenko()
        {
            (DateTime, DateTime) timeTuple = (DateTime.Now, DateTime.MaxValue);
            Discount discount10 = new Discount(timeTuple, "Discount 10", 10);
            Discount discount15 = new Discount(timeTuple, "Discount15", 15);

            ICategory milkProducts = new Category("milk Prducts");
            Product milk = new Product("Milk", "Romol", "Good Milk", null, 40, milkProducts, false);
            Product sourCream = new("Sour cream", "Zakarpatiia", "25% Sour Cream", null, 80, milkProducts, true);
            Product butter = new Product("Butter", "Romol", "85% Butter", discount10, 120, milkProducts, true);
            Product hollandCheese = new("Cheese", "Zakarpatia", "Perfect cheese from cow milk", null, 350, milkProducts, false);
            Product serum = new("Serum", "Zakarpatia", "good serum", null, 30, milkProducts, true);
            Product goatCheese = new("Cheese", "Romol", "Very old cheese", discount15, 400, milkProducts, true);
            Product goatMilk = new("Milk", "Zakarpatia", "Strange Milk", discount10, 350, milkProducts, false);
            Product horseMilk = new Product("Milk", "Romol", "Milk from horses", null, 700, milkProducts, true);
            products = new List<Product>();
            products.Add(milk);
            products.Add(sourCream);
            products.Add( butter);
            products.Add( hollandCheese);
            products.Add( serum);
            products.Add( goatCheese);
            products.Add(goatMilk);
            products.Add(horseMilk);
        }

        public void FiltrByBrand(string brand)
        {
            List<Product> filteredProducts = products.Where(p => p.Brand == brand).ToList();
            printProducts(filteredProducts);
        }

        public void FiltrByName(string name)
        {
            var productsF = products;
            var filtered = from product in productsF where product.Name == name select product;
            List < Product > filteredProducts= filtered.ToList();
            printProducts(filteredProducts);
        }

        public void SortByPriceAsc()
        {
            var productsS = products;
            var sorted = from product in productsS orderby product.Price select product;
            List<Product> sortedProducts = sorted.ToList();
            printProducts(sortedProducts);
        }

        public void SortByNameDesc()
        {
            List<Product> sortedProducts = products.OrderByDescending(p => p.Name).ToList();
            printProducts(sortedProducts);
        }

        public void Projection()
        {
            var myCollection = products.Select(p => new {PrName = p.Name, PrPrice = p.Price, PrCategory = p.CategoryOfProduct}).Where(p=>p.PrPrice>products.Average(p=>p.Price)).OrderBy(p=>p.PrPrice).ToList();
            
            foreach (var item in myCollection)
            {
                Console.WriteLine($"{item.PrName} - {item.PrPrice} in Category {item.PrCategory.Name}");
            }
        }

        public void OtherProjection()
        {
            var myCollection = products
                .Where(p => p.Reduction != null)
                .Select(p => new { prName = p.Name, prDiscountPrice = p.GetRealPriceFromDiscount(), prOldPrice = p.Price, prDiscount = p.Reduction})
                .OrderBy(p => p.prDiscountPrice)
                .ToList();

            foreach(var item in myCollection)
            {
                Console.WriteLine($"Product {item.prName} for price {item.prDiscountPrice} that costs {item.prOldPrice} without discount\nDiscount is valid to {item.prDiscount!.DurationTuple.Item2} and equal to {item.prDiscount.Percantage}\n");
            }
        }

        public void PrintAllProducts()
        {
            printProducts(products);
        }

        private void printProducts(List<Product> products)
        {
            products.ForEach(p => Console.WriteLine(p));
        }
    }
}
