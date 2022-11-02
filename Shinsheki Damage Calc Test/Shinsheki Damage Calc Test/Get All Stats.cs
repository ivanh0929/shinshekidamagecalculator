using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinsheki_Damage_Calc_Test
{
    internal class GetAllStats
    {
        
        public static void GrabFightStats(SavedStats savedStats)
        {
            // Get the necessary stats and assign them to the array in savedStats

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Great! Let's get started then. \n What is the strength stat?");
                savedStats.StrengthStat = CodeValidation.CVNumber("Please enter a valid integer.");
                Console.WriteLine("How about the weapon power stat?");
                savedStats.WeaponPower = CodeValidation.CVNumber("Please enter a valid integer.");
                Console.WriteLine("How about the enemy defense stat?");
                savedStats.EnemyDefense = CodeValidation.CVNumber("Please enter a valid integer.");
                Console.WriteLine("How about the enemy armor stat?");
                savedStats.EnemyArmor = CodeValidation.CVNumber("Please enter a valid integer.");
                Console.Clear();
        }

        public static void GrabPhysSkillStats(SavedStats savedStats)
        {
            // Get the necessary stats and assign them to the array in savedStats

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Great! Let's get started then. \n What is the strength stat?");
            savedStats.StrengthStat = CodeValidation.CVNumber("Please enter a valid integer.");
            Console.WriteLine("How about the skill power stat?");
            savedStats.SkillPower = CodeValidation.CVNumber("Please enter a valid integer.");
            Console.WriteLine("How about the enemy defense stat?");
            savedStats.EnemyDefense = CodeValidation.CVNumber("Please enter a valid integer.");
            Console.WriteLine("How about the enemy armor stat?");
            savedStats.EnemyArmor = CodeValidation.CVNumber("Please enter a valid integer.");
            Console.Clear();
        }
        public static void GrabElementSkillStats(SavedStats savedStats)
        {
            // Get the necessary stats and assign them to the array in savedStats

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Great! Let's get started then. \n What is the magic stat?");
            savedStats.MagicStat = CodeValidation.CVNumber("Please enter a valid integer.");
            Console.WriteLine("How about the skill power stat?");
            savedStats.SkillPower = CodeValidation.CVNumber("Please enter a valid integer.");
            Console.WriteLine("How about the enemy defense stat?");
            savedStats.EnemyDefense = CodeValidation.CVNumber("Please enter a valid integer.");
            Console.WriteLine("How about the enemy armor stat?");
            savedStats.EnemyArmor = CodeValidation.CVNumber("Please enter a valid integer.");
            Console.Clear();
        }

    }
}
