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
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Magic stat cannot be lower than 1. Setting it to 1.");
                    CalculationStats[0] = 1;
                }
                else
                {
                    CalculationStats[0] = value;
                }
            }
        }
        public double StrengthStat
        {
            get { return CalculationStats[1]; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Strength stat cannot be lower than 1. Setting it to 1.");
                    CalculationStats[1] = 1;
                }
                else
                {
                    CalculationStats[1] = value;
                }
            }
        }
        public double SkillPower
        {
            get { return CalculationStats[2]; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Skill power cannot be lower than 1. Setting it to 1.");
                    CalculationStats[2] = 1;
                }
                else
                {
                    CalculationStats[2] = value;
                }
            }
        }
        public double WeaponPower
        {
            get { return CalculationStats[3]; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Weapon power cannot be lower than 1. Setting it to 1.");
                    CalculationStats[3] = 1;
                }
                else
                {
                    CalculationStats[3] = value;
                }
            }
        }
        public double EnemyDefense
        {
            get { return CalculationStats[4]; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Enemy defense cannot be lower than 1. Setting it to 1.");
                    CalculationStats[0] = 1;
                }
                else
                {
                    CalculationStats[0] = value;
                }
            }
        }
        public double EnemyArmor
        {
            get { return CalculationStats[5]; }
            set
            {
                if (value <= -1)
                {
                    Console.WriteLine("Enemy armor cannot be lower than 0. Setting it to 0.");
                    CalculationStats[5] = 0;
                }
                else
                {
                    CalculationStats[5] = value;
                }
            }
        }
    }
}
