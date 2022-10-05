using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinsheki_Damage_Calc_Test
{
    internal class GetAllStats
    {
        // Get the stats
        public static string GrabStats()
        {
                Console.WriteLine("Great! Let's get started then. \n What is the weapon power stat?");
                string WeaponPowerString = Console.ReadLine();
                Console.WriteLine("How about the strength stat?");
                string StrengthStatString = Console.ReadLine();
                Console.WriteLine("How about the enemy defense stat?");
                string EnemyDefenseString = Console.ReadLine();
                Console.WriteLine("How about the enemy armor stat?");
                string EnemyArmorString = Console.ReadLine();
                Console.WriteLine("How about the skill power stat?");
                string SkillPowerString = Console.ReadLine();
                Console.WriteLine("How about the magic stat?");
                string MagicStatString = Console.ReadLine();
                string AllInfo = WeaponPowerString+","+StrengthStatString+ "," + EnemyDefenseString + "," + EnemyArmorString + "," + SkillPowerString + "," + MagicStatString;
            return AllInfo;
        }

    }
}
