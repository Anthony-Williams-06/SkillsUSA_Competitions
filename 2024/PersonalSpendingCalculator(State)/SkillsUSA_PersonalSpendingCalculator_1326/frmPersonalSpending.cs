using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsUSA_PersonalSpendingCalculator_1326
{
    public partial class frmPersonalSpending : Form
    {
        private CategoryList categoryList = new CategoryList();
        private List<decimal> percentList = new List<decimal>();
        private decimal emergencyFund = 0;

        public frmPersonalSpending()
        {
            InitializeComponent();
        }

        //Event handler to handle adding new categories
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCategory addCategory = new frmAddCategory();
            Category category = addCategory.GetNewCategory();
            if(category != null && category.value != 0)
            {
                bool alreadyExists = false;
                for (int i = 0; i < categoryList.Length; i++)
                {
                    if(categoryList.GetCategory(i).GetCategoryName() == category.GetCategoryName())
                    {
                        alreadyExists = true;
                        break;
                    }
                }
                if(alreadyExists)
                {
                    MessageBox.Show("Could not add " + category.GetCategoryName() + " because it already exists.", "Duplication Error");
                }
                else
                {
                    categoryList.Add(category);
                }
                
            }
            PopulateListBox();
        }

        //event handler to handle removing categories
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lstCatagoriesDisplay.SelectedIndex;
            categoryList.Remove(index);
            PopulateListBox();
        }

        //Check if the category list is valid
        public bool isValidInputs()
        {
            string msg = String.Empty;

            msg += Validation.isNotEmpty("Income", txtIncome.Text);
            msg += Validation.isDecimal("Income", txtIncome.Text);

            //Check if there are any errors, if so, display them.
            if(msg == String.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show(msg, "Entry Error");
                return false;
            }
            
        }

        //Create a validation in order to check for 100%
        public bool IsValidPercents()
        {
            string msg = Validation.isHundredPercent("Categories", percentList);
            msg += Validation.CheckListSize("Categories", percentList, 8);

            if (msg != String.Empty)
            {
                MessageBox.Show(msg, "Entry Error");
                return false;
            }
            return true;
        }

        //Create a list of just percents to use in validation
        public void CreatePercentList(decimal multipliedIncome)
        {
            percentList = new List<decimal>();
            for (int i = 0; i < categoryList.Length; i++)
            {
                if(categoryList.GetCategory(i).categoryIndex != 8)
                {
                    percentList.Add(categoryList.GetCategory(i).value / 100);
                }
                else
                {
                    //Store the Emergency fund amount for later use
                    emergencyFund = categoryList.GetCategory(i).value;
                }

            }
        }

       

        //Populate the list box to display current categories
        public void PopulateListBox()
        {
            lstCatagoriesDisplay.Items.Clear();
            for(int i = 0; i < categoryList.Length; i++)
            {
                if(categoryList.GetCategory(i).categoryIndex != 8)
                {
                    lstCatagoriesDisplay.Items.Add(categoryList.GetCategory(i).GetCategoryName() + "\t" + categoryList.GetCategory(i).value + "%");
                }
                else
                {
                    lstCatagoriesDisplay.Items.Add(categoryList.GetCategory(i).GetCategoryName() + "\t$" + categoryList.GetCategory(i).value);
                }
                
            }
        }

        //Calculate Functions
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal multiplyer = 1;
            decimal income = 0;
            decimal multipliedIncome = 0;
            string output = "Category      \t| Annually | Monthly | Weekly | Daily\n";
            //Check for valid values
            if(isValidInputs())
            {
                //If valid, income will be a decimal value
                income = decimal.Parse(txtIncome.Text);

                //Get radio button value for multiplyer
                if (rdoAnnually.Checked)
                {
                    multiplyer = 1;
                }
                else if(rdoBiWeekly.Checked)
                {
                    multiplyer = 26;
                }
                else
                {
                    multiplyer = 2080; //2080 = 40 hours per week * 52 weeks
                }

                //Multiply the multiplyer by the income submitted
                multipliedIncome = income * multiplyer;

                //create list of percents
                CreatePercentList(multipliedIncome);


                //Check if percents add to 100%
                if (IsValidPercents())
                {
                    //Create Output
                    for(int i = 0; i < categoryList.Length; i++)
                    {
                        if (categoryList.GetCategory(i).categoryIndex != 8)
                        {
                            decimal yearlyAmount = Decimal.Round((multipliedIncome - emergencyFund) * percentList[i], 2);
                            output += categoryList.GetCategory(i).GetCategoryName() + "\t| " +
                                String.Format("{0:c}", yearlyAmount) + " | " +
                                String.Format("{0:c}", yearlyAmount / 12) + " | " +
                                String.Format("{0:c}", yearlyAmount / 52) + " | " +
                                String.Format("{0:c}", yearlyAmount / 365) + "\n";
                        }
                            
                    }
                    MessageBox.Show(output, "Output", MessageBoxButtons.OK);
                    lstCatagoriesDisplay.Items.Clear();
                    categoryList = new CategoryList();
                }
                
            }
        }
    }
}
