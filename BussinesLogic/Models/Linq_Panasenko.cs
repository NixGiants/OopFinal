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
            ICategory milkProducts = new Category("milk Prducts");
            Product milk = new Product("Milk", "Romol", "Good Milk", null, 40, milkProducts, false);
            Product sourCream = new("Sour cream", "Zakarpatiia", "25% Sour Cream", null, 80, milkProducts, true);
            Product butter = new Product("Butter", "Romol", "85% Butter", null, 120, milkProducts, true);
            Product hollandCheese = new("Cheese", "Zakarpatia", "Perfect cheese from cow milk", null, 350, milkProducts, false);
            Product serum = new("Serum", "Zakarpatia", "good serum", null, 30, milkProducts, true);
            Product goatCheese = new("Cheese", "Romol", "Very old cheese", null, 400, milkProducts, true);
            Product goatMilk = new("Milk", "Zakarpatia", "Strange Milk", null, 350, milkProducts, false);
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
