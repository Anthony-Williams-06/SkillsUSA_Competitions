using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSA_PersonalSpendingCalculator_1326
{
    public class CategoryList
    {
        List<Category> categories = new List<Category>();
        public int Length { get; set; }

        //Add Category Object to List
        public void Add(Category category)
        {
            categories.Add(category);
            Length = categories.Count;
        }
        
        //Remove Category Object from List using an Index
        public void Remove(int index)
        {
            categories.RemoveAt(index);
            Length = categories.Count;
        }

        //Remove Category Object from list using Object
        public void Remove(Category category)
        {
            categories.Remove(category);
            Length = categories.Count;
        }

        //Edit existing object with new values
        public void Edit(int index, decimal value, string categoryName)
        {
            categories[index].value = value;
            categories[index].categoryName = categoryName;
        }

        //Return the category at index
        public Category GetCategory(int index)
        {
            return categories[index];
        }
        
    }
}
