using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillsUSA_App_1
{
    public partial class Form1 : Form
    {
        //Global lists to get the corrisponding compound frequency
        int[] CompoundFrequencyNums = new int[] { 52, 12, 4, 1 };
        int[] RepayFrequencyNums = new int[] { 52, 26, 12, 1 };

        public Form1()
        {
            InitializeComponent();
        }

        //Calculate the outputs
        private void CalcButton_Click(object sender, EventArgs e)
        {
            //Declare Variables to store input values for calculations
            double Principle = 0;
            double InterestRate = 0;
            int Term = 0;
            int Compound = 0;
            int Repayment = 0;
            bool canContinue = true;

            //Get Values
            Principle = InputValidation.ToDouble(PrincipleTextBox.Text, 1);
            InterestRate = InputValidation.ToDouble(InterestRateTextBox.Text, 0.01, 100);
            Term = InputValidation.ToInt(TermTextBox.Text, 1, 1000);

            //Test for all non valid values
            //Make sure the Combo Boxes are not empty/default
            try
            {
                //Get Compound and Repayment Combo Box Selected Enteries, and use lists to get integers
                Compound = CompoundFrequencyNums[CompoundCombo.SelectedIndex];
                
            }
            catch
            {
                MessageBox.Show("Compound must not be empty.", "Entry Error");
                canContinue = false;
            }

            try
            {
                Repayment = RepayFrequencyNums[RepaymentCombo.SelectedIndex];
            }
            catch
            {
                MessageBox.Show("Repayment must not be empty.", "Entry Error");
                canContinue = false;
            }

            //Validate All Values the user can enter
            // -1 means failed test, otherwise will return value needed
            if (Principle == -1 || InterestRate == -1 || Term == -1)
            {
                if (Principle == -1)
                {
                    MessageBox.Show("Principle must be a decimal value greater than or equal to 1 and less than or equal to 1000 (1.0, 1.1, 1.2, etc.), and must not contain non-numeric symbols (%, $, &, etc.) or letters", "Entry Error");
                    canContinue = false;
                }
                if (InterestRate == -1)
                {
                    MessageBox.Show("Interest Rate must be a decimal value greater than or equal to 0.01, but less than 100 (1.1, 2.2, 3.3, etc.), and must not contain non-numeric symbols (%, $, &, etc.) or letters", "Entry Error");
                    canContinue = false;
                }
                if (Term == -1)
                {
                    canContinue = false;
                    MessageBox.Show("Term must be a whole number value greater than or equal to 1, but less than or equal to 100 (1, 2, 3, etc.), and must not contain non-numeric symbols (%, $, &, etc.) or letters", "Entry Error");
                }
            }
            if(canContinue)
            {

                InterestRate /= 100;
                //Calculate Outputs
                double Total = CalculateOutputs.CalculateTotalAmount(Principle, InterestRate, Term, Compound, Repayment);
                double InterestAccured = CalculateOutputs.CalculateInterestAccrued(Total, Principle);
                double RepaymentAmount = CalculateOutputs.CalculateRepaymentAmount(Total, Term, Repayment);
                double IPR = CalculateOutputs.CalculateIPR(InterestAccured, Repayment, Term);
                double PPR = CalculateOutputs.CalculatePPR(Principle, Repayment, Term);

                //Format Outputs as Currency
                String CurrencyFormat = "{0:c}";
                String FormatTotal = String.Format(CurrencyFormat, Total);
                String FormatInterest = String.Format(CurrencyFormat, InterestAccured);
                String FormatRepayment = String.Format(CurrencyFormat, RepaymentAmount);
                String FormatIPR = String.Format(CurrencyFormat, IPR);
                String FormatPPR = String.Format(CurrencyFormat, PPR);


                //Set Output Labels with header
                TotalLabel.Text = "Total Amount: " + FormatTotal;
                AccruedLabel.Text = "Interest Accrued: " + FormatInterest;
                RepayLabel.Text = "Repayment Amount: " + FormatRepayment;
                IPRLabel.Text = "Interest Per Repay: " + FormatIPR;
                PPRLabel.Text = "Principle Per Repay: " + PPR;
            }

        }
        //Close the program on Exit Button Click, or escape key pressed
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DestroyHandle();
        }

        //Define DropDownStyles on form load
        private void Form1_Load(object sender, EventArgs e)
        {
            CompoundCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            RepaymentCombo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}