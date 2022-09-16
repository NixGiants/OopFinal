using BussinesLogic.Interfaces;

namespace BussinesLogic.Models
{
    public class Category : ICategory
    {
        public string Name { get; set; }

        public Category(string name)
        {
            if(String.IsNullOrEmpty(name))
                throw new ArgumentException("Category name cant be null or empty");

            Name = name;
        }
    }
}