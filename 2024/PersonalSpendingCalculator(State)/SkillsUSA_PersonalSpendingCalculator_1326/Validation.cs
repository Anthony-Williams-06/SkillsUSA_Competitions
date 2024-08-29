using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSA_PersonalSpendingCalculator_1326
{
    internal static class Validation
    {
        //Check if Int32
        public static string isInt32 (string name, string variable)
        {
            if(Int32.TryParse(variable, out _))
            {
                return String.Empty;
            }
            return name + " must be a valid integer.\n";
            
        }

        //Check for empty fields
        public static string isNotEmpty(string name, string variable)
        {
            if(variable == null || variable == String.Empty)
            {
                return name + " is a required field.\n";
            }
            return String.Empty;
        }

        //Check for decimals
        public static string isDecimal(string name, string variable)
        {
            if(Decimal.TryParse(variable, out _))
            {
                return String.Empty;
            }
            return name + " must be a valid decimal value.\n";
        }

        //Check for percent
        public static string isPercent(string name, string percent)
        {
            if(Decimal.TryParse(percent, out decimal num))
            {
                if (num <= 100 && num > 0)
                {
                    return String.Empty;
                }
                return name + " must be a valid percent value.\n";
            }
            return name + " must be a valid percent value.\n";
            
        }

        //Check if a list of percents is equal to 100%. Items in list are Decimal Representations of the percents
        public static string isHundredPercent(string name, List<decimal> percents)
        {
            decimal totals = 0;
            for(int i = 0; i < percents.Count; i++)
            {
                totals += percents[i];
            }

            if(Decimal.Round(totals,0) != 1)
            {
                return name + " must add to 100%\n";
            }
            return String.Empty;
        }

        public static string CheckListSize(string name, List<Decimal> list, int size)
        {
            if(list.Count < size)
            {
                return name + " Must contain " + (size + 1) + " categories.\n";
            }
            return String.Empty;
        }
    }
}
