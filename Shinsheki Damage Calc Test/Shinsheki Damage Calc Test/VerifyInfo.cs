using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinsheki_Damage_Calc_Test
{
    internal class VerifyInfo
    {
        // Verify strings
        public static void VerifyString(string Verify)
        {
            do
            {
                if (String.IsNullOrEmpty(Verify))
                {
                    Console.WriteLine("Please enter a valid string.");
                }
            }
            while (String.IsNullOrEmpty(Verify));
        }

        public static double VerifyNumber(string NumberString)
        {
            bool parse;
            double Number;
            do
            {
                parse = double.TryParse(NumberString, out Number);

                if (parse == false)
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            }
            while (Number <= 0);
            return Number;
        }

    }
}
