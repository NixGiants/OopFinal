using BussinesLogic.Interfaces;

namespace BussinesLogic.Models
{
    public class Category : ICategory
    {
        public string Name { get; set; }
        public List<SubCategory> SubCategories { get; set; }


        public Category(string name)
        {
            if(String.IsNullOrEmpty(name))
                throw new ArgumentException("Category name cant be null or empty");

            Name = name;
            SubCategories = new List<SubCategory>();
        }

        public void AddSubcategory(SubCategory subCategory)
        {
            SubCategories.Add(subCategory);
        }

        public bool RemoveSubcategory(SubCategory subCategory)
        {
           return SubCategories.Remove(subCategory);
        }

        public bool RemoveSubCategories (List<SubCategory> subCategories)
        {
            return SubCategories.RemoveAll(sc => subCategories.Contains(sc)) > 0 ? true : false;
                
        }
        
    }
}