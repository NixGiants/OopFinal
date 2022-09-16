
using BussinesLogic.Interfaces;

namespace BussinesLogic.Models
{
    public class SubCategory : ICategory
    {
        public Category? BaseCategory { get; set; }
        public string? Name { get; set; }
        public List<SubCategory>? SubCategories { get; set; }

        public SubCategory(Category? baseCategory, string? name, List<SubCategory>? subCategories)
        {
            BaseCategory = baseCategory;
            Name = name;
            SubCategories = subCategories;
        }
    }
}
