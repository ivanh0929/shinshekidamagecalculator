using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinsheki_Damage_Calc_Test
{
    internal class CodeValidation
    {

        // Check is a string is null or empty
        public static bool CVString(string error)
        {
            bool validity;
            string valid;
            do
            {
                valid = Console.ReadLine().Trim();
                if (String.IsNullOrEmpty(valid))
                {
                    Console.WriteLine(error);
                    validity = false;
                }
            }
            while (String.IsNullOrEmpty(valid));
            validity = true;
            return validity;
        }

        // Return a number from a string w/error checking
        public static int CVNumber(string error)
        {
            int realnum;
            bool parse;
            string valid;
            do
            {
                valid = Console.ReadLine().Trim();
                parse = int.TryParse(valid.Trim(), out realnum);
                if (parse == false)
                {
                    Console.WriteLine(error);
                }
            }
            while (realnum <= -1 || parse == false);
            return realnum;
        }

        // Check for Y or N

        public static string CVYORN(string error)
        {
            string Answer;
            do
            {
                Answer = Console.ReadLine().Trim().ToUpper();

                if (String.IsNullOrEmpty(Answer))
                {
                    Console.WriteLine(error);
                }

                if (Answer.Substring(0) != "Y" || Answer.Substring(0) != "N")
                {
                    Console.WriteLine(error);
                }

            }
            while (String.IsNullOrEmpty(Answer) || Answer.Substring(0) != "Y" & Answer.Substring(0) != "N");
            return Answer;
        }



    }
}
