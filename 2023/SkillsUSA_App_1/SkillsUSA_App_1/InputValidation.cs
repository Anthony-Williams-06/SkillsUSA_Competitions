using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSA_App_1
{
    internal class InputValidation
    {

        //String to Double Conversion, with try catch
        public static double ToDouble(String inputValue)
        {
            try 
            { 
                return Double.Parse(inputValue);

            } catch
            {
                return -1;
            }
        }

        //String to double Conversion with minimum value
        public static double ToDouble(String inputValue, int min)
        {
            try
            {
                double doubleInput = ToDouble(inputValue);
                if (doubleInput >= min)
                {
                    return doubleInput;
                }
                else
                {
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
        }
        
        //Overload the ToDouble Function in order to apply upper and lower bounds, Inclusive
        public static double ToDouble(String inputValue, double min, double max)
        {
            try
            {
                double doubleInput = ToDouble(inputValue);
                if (doubleInput <= max && doubleInput >= min)
                {
                    return doubleInput;
                }
                else
                {
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
        }


        //Change String to int
        public static int ToInt(String inputValue)
        {
            try
            {
                return int.Parse(inputValue);
            }
            catch
            {
                return -1;
            }
        }

        //Overload the ToInt Function to allow for contraining values
        public static int ToInt(String inputValue, int min)
        {
            int intInput = ToInt(inputValue);
            if(intInput >= min)
            {
                return intInput;
            }
            return -1;
        }

        //Overload the ToInt Function to allow for upper and lower bounds
        public static int ToInt(String inputValue, int min, int max)
        {
            int intInput = ToInt(inputValue);
            if (intInput >= min && intInput <= max)
            {
                return intInput;
            }
            return -1;
        }
    }
}
