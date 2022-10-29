/* Name: Shinsheki Damage Calculations
 * Creator: Ivan Hernandez
 * Purpose: make a test program for Shinsheki damage calculations to practice methods
 * Date: 9/21/222
 * Modification:
*/

using Shinsheki_Damage_Calc_Test;

namespace ShinshekiDamageCalcer // Note: actual namespace depends on the project name.
{

    internal class Program
    {

        static void Main(string[] args)
        {
            //Initialize

            SavedStats savedStats = new SavedStats();
            
            //Welcome to Damage Calcer

            Console.WriteLine("Welcome to the first Shinsheki damage calculator! Let's pray this thing actually works.");

            // What formula you want boss

            Console.WriteLine("To start things off, let's make sure we have all the variables we need. \n What formula do you want to use? Enter the number that corresponds to your choice. \n1)Fight Command \n2)Physical Skill \n3)Magic Skill");
            int FormulaChoice = 0;
            do
            {
                FormulaChoice = CodeValidation.CVNumber("Please enter a valid integer.");
            }
            while (FormulaChoice == 0);

            // Grab necessary stats based on chosen formula

            switch(FormulaChoice)
            {
                case 1:
                    GetAllStats.GrabFightStats(savedStats);
                    break;
                case 2:
                    GetAllStats.GrabPhysSkillStats(savedStats);
                    break;
                case 3:
                    GetAllStats.GrabElementSkillStats(savedStats);
                    break;
            }
            

            

            //What formula you want boss

            //Make a method for each Formula (Fight Command, Physical Skill, Magic Skill)
            //Send the needed information to the correct method
            //Give the final damage number
            //Write all of the methods on the bottom

        }

        


}


}
    
    

