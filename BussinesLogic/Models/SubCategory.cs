
using BussinesLogic.Interfaces;

namespace BussinesLogic.Models
{
    public class SubCategory : ICategory
    {
        public Category? BaseCategory { get; set; }
        public string? Name { get; set; }
        public List<SubCategory>? SubCategories { get; set; }
    }
}
