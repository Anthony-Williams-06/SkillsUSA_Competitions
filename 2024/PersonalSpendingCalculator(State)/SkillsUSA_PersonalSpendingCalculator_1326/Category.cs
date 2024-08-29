using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSA_PersonalSpendingCalculator_1326
{
    public class Category
    {
        //Defind the categories, add extra space characters for later formating (Must have 13 characters)
        string[] categories = new string[9] { "Housing      ", "Savings      ", "Utilities      ", "Health       ", "Consumer Debt", "Food          ", "Personal Care", "Entertainment", "Emergency" };
        public int categoryIndex { get; set; }
        public string categoryName { get; set; }
        public decimal value { get; set; }

        //Constructors
        public Category() 
        {
            this.categoryIndex = 0;
            this.categoryName = this.GetCategoryName();
            this.value = 0;
        }
        public Category(int categoryIndex, decimal value) 
        {
            this.categoryIndex = categoryIndex;
            this.categoryName = this.GetCategoryName();
            this.value = value;
        }

        //Force update the category name defined to an object
        public void updateName()
        {
            this.categoryName = this.GetCategoryName();
        }


        //Retreieve the Category Name
        public string GetCategoryName()
        {
            return categories[categoryIndex].ToString();
        }

    }
}
