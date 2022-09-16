
using BussinesLogic.Interfaces;

namespace BussinesLogic.Models
{
    public class SubCategory : ICategory
    {
        public Category BaseCategory { get; set; }
        public string Name { get; set; }
        public List<SubCategory>? SubCategories { get; set; }

        public SubCategory(Category? baseCategory, string? name, List<SubCategory>? subCategories)
        {
            if (baseCategory == null)
                throw new ArgumentException("BaseCategory vant be null");

            else if (String.IsNullOrEmpty(name))
                throw new ArgumentException("Name cant be null or empty");

            BaseCategory = baseCategory;
            Name = name;
            SubCategories = subCategories;
        }
    }
}
