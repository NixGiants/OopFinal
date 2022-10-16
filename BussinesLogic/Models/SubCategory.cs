using BussinesLogic.Interfaces;

namespace BussinesLogic.Models
{
    public class SubCategory : ICategory
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public SubCategory(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
