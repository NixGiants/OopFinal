using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Models
{
    public class Basket
    {
        private decimal _totalPrice;
        private List<Product> _products = new List<Product>();
        public decimal TotalPrice
        {
            get
            {
                if(_products.Count > 0)
                {
                    _totalPrice = 0;
                    _products.ForEach(product => {
                        _totalPrice += product.Price;
                    });
                    return _totalPrice;
                }
                return 0;
            }
        }
        public bool AddProduct(Product product)
        {
            if (!product.IsAvailable) return false;
            
            _products.Add(product);
            return true;
        }
        public void DeleteProduct(Product product)/*Uniqe identifier later on*/
        {
            Console.WriteLine("Product by the name of {0} was deleted",product.Name);
        }
    }
}
