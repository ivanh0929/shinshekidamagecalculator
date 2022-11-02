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
            Random rand = new Random();

            //Welcome to Damage Calcer

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Welcome to the first Shinsheki damage calculator! Let's pray this thing actually works.");

            // What formula you want boss

            Console.WriteLine("To start things off, let's make sure we have all the variables we need. \nWhat formula do you want to use? Enter the number that corresponds to your choice. \n1)Fight Command \n2)Physical Skill \n3)Magic Skill");
            int FormulaChoice = 4;
            do
            {
                FormulaChoice = CodeValidation.CVNumber("Please enter a valid integer.");
                if (FormulaChoice >=4)
                {
                    Console.WriteLine("Please enter a valid choice.");
                }
            }
            while (FormulaChoice >= 4);

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

            Console.WriteLine("Now, we have to define all of the buffs!");

            SOT_PAA.ATKBuffs(SOT_PAA.SOTbuffs);
            SOT_PAA.DEFBuffs(savedStats.EnemyDefense);
            SOT_PAA.Passives(savedStats);

            Console.WriteLine("Lastly, let's calculate the formula! Press any key to continue.");
            double Calced = 0.0;
            Console.ReadLine();

            switch (FormulaChoice)
            {
                case 1:
                    Calced = Calculations.FightCommand(savedStats, SOT_PAA.SOTbuffs, SOT_PAA.paa);
                    break;
                case 2:
                    Calced = Calculations.PhysicalSkill(savedStats, SOT_PAA.SOTbuffs, SOT_PAA.paa);
                    break;
                case 3:
                    Calced = Calculations.MagicSkill(savedStats, SOT_PAA.SOTbuffs, SOT_PAA.paa);
                    break;
            }

            Calced = Calculations.Crit(Calced, rand);
            double variance = Calculations.Variance(rand);
            Calced = Calced * variance;
            Calced = Calculations.EnemyDR(Calced);
            Calced = Math.Round(Calced);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Without further ado...With all the information you hve given me, your attack should do {0} damage!", Calced);
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            System.Environment.Exit(0);






        }

    }


}
    
    

