
using System.Linq;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace BussinesLogic.Models
{
    public class Basket
    {
        private decimal _totalPrice;
        private ObservableCollection<Product> _products = new ObservableCollection<Product>();
        public decimal TotalPrice { get => _totalPrice; }
       

        public Basket()
        {
            _products = new ObservableCollection<Product>();
            _products.CollectionChanged += _products_CollectionChanged;
        }

        public delegate void Add(List<Product> senders);
        private void _products_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {

            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:

                    _totalPrice += (sender as IEnumerable<Product>).Last().Price;
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:

                    if (_products.Count >= 1)
                    {
                        _totalPrice -= (sender as IEnumerable<Product>).Last().Price;
                    }
                    else _totalPrice = 0;
                    break;
                default:
                    break;
            }
        }

        public Basket(ObservableCollection<Product> products)
        {
            _products = products;
        }

        public bool AddProduct(Product product)
        {
            if (!product.IsAvailable) return false;

            _products.Add(product);
            return true;
        }
        public bool AddProducts(List<Product> products)
        {
            if (products.All((p) => p.IsAvailable))
            {
                foreach (Product product in products)
                {
                    _products.Add(product);
                }
                return true;
            }
            return false;
        }

        public bool DeleteProduct(Product product)/*Uniqe identifier later on*/
        {
            return _products.Remove(product);
        }
        public bool DeleteProducts(List<Product> products)
        {
            // return _products.RemoveAll(p => products.Contains(p)) > 0 ? true : false;
            foreach (var p in _products)
            {
                if (products.Contains(p))
                {
                    _products.Remove(p);
                }
                else return false;
            }
            return true;

        }

        public override string ToString()
        {
            string res = "";
            foreach (Product pr in _products)
            {
                res += $"\n{pr}\n";
            }
            res += "Total price =\t" + TotalPrice;
            return res;

        }
    }
}
