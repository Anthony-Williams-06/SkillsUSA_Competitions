using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSA_App_1
{
    internal class CalculateOutputs
    {
        //Use Given Formula to calculate total
        public static double CalculateTotalAmount(double Principle, double InterestRate, int Term, int Compound, int Repayment)
        {
            return Math.Round(Principle * Math.Pow((1 + (InterestRate / Compound)), (Compound * Term)), 2, MidpointRounding.AwayFromZero);
            
        }

        //Calculate Intereast Accrued
        public static double CalculateInterestAccrued(double TotalAmount, double Principle)
        {
            return TotalAmount - Principle;
        }

        //Calculate Repayment Amount
        public static double CalculateRepaymentAmount(double TotalAmount, int Term, int Repayment)
        {
            return Math.Round(TotalAmount / (Repayment * Term), 2, MidpointRounding.AwayFromZero);
        }

        //Calculate the Principle Per Repayment (PPR)
        public static double CalculatePPR(double InterestAccrued, double Repayment, int Term)
        {
            return Math.Round(InterestAccrued / (Repayment * Term), 2, MidpointRounding.AwayFromZero);
        }

        //Calculate the Interest Per Repayment (IPR)
        public static double CalculateIPR(double Principle, double Repayment, int Term)
        {
            return Math.Round(Principle / (Repayment * Term), 2, MidpointRounding.AwayFromZero);
        }
    }
}
