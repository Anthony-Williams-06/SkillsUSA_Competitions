using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsUSA_PersonalSpendingCalculator_1326
{
    public partial class frmAddCategory : Form
    {
        Category category = new Category();

        public frmAddCategory()
        {
            InitializeComponent();
        }

        //Handler for Opening new form
        public Category GetNewCategory()
        {
            this.ShowDialog();
            return category;
        }

        //Add items to combo box on load
        private void frmAddCategory_Load(object sender, EventArgs e)
        {
            //Add all the List Items on load
            cboCategory.Items.Clear();
            cboCategory.Items.Add("Housing");
            cboCategory.Items.Add("Savings");
            cboCategory.Items.Add("Utilities");
            cboCategory.Items.Add("Health Care");
            cboCategory.Items.Add("Consumer Debt");
            cboCategory.Items.Add("Food and Groceries");
            cboCategory.Items.Add("Personal Care");
            cboCategory.Items.Add("Entertainment");
            cboCategory.Items.Add("Emergency Fund");
            //Set index to 0 to display first item
            cboCategory.SelectedIndex = 0;
        }

        //Check for validation before adding to object, then close form
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(IsValid())
            {
                category.value = Decimal.Parse(txtAmount.Text);
                category.categoryIndex = cboCategory.SelectedIndex;
                category.updateName();
                this.Close();
            }
            
            
        }

        //Check for validation
        private bool IsValid()
        {
            string value = txtAmount.Text;
            string msg = String.Empty;

            msg += Validation.isNotEmpty(lblAmount.Text, txtAmount.Text);

            //Only test for Percentage value if "Emergency Fund" isn't selected
            if(cboCategory.SelectedIndex != 8)
            {
                msg += Validation.isPercent(lblAmount.Text, value);
            }
            else
            {
                msg += Validation.isDecimal(lblAmount.Text, value);
            }

            //If no validation errors, continue, otherwise show error box
            if (msg == String.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show(msg, "Entry Error");
                return false;
            }
        }

        //Change label if "Emergency Fund" is selected
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCategory.SelectedIndex == 8)
            {
                lblAmount.Text = "Amount";
            }
            else
            {
                lblAmount.Text = "Percent";
            }
        }
    }
}
