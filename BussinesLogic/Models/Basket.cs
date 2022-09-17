
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

        public Basket()
        {
            _products = new List<Product>();
        }

        public Basket(List<Product> products)
        {
            _products = products;
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

        public override string ToString()
        {
            string res = "";
            foreach (Product pr in _products)
            {
                res += $"\n{pr}\n";
            }
            res +="Total price =\t"+TotalPrice;
            return res;

        }
    }
}
