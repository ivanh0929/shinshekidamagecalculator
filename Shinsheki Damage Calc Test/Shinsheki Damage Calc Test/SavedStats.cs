using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinsheki_Damage_Calc_Test
{
    internal class SavedStats
    {
        // Array of doubles to hold all stats for calculation

        /*
            - 0 = Magic Stat
            - 1 = Strength Stat
            - 2 = Skill Power
            - 3 = Weapon Power
            - 4 = Enemy Defense
            - 5 = Enemy Armor
         */ 
        double[] CalculationStats = new double[] { 1.0, 1.0, 1.0, 1.0, 1.0, 1.0 };


        public double MagicStat
        {
            get { return CalculationStats[0]; }
            set { CalculationStats[0] = value; }
        }
        public double StrengthStat
        {
            get { return CalculationStats[1]; }
            set { CalculationStats[1] = value; }
        }
        public double SkillPower
        {
            get { return CalculationStats[2]; }
            set { CalculationStats[2] = value; }
        }
        public double WeaponPower
        {
            get { return CalculationStats[3]; }
            set { CalculationStats[3] = value; }
        }
        public double EnemyDefense
        {
            get { return CalculationStats[4]; }
            set { CalculationStats[4] = value; }
        }
        public double EnemyArmor
        {
            get { return CalculationStats[5]; }
            set { CalculationStats[5] = value; }
        }
    }
}
