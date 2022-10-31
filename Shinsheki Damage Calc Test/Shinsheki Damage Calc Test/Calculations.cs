﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinsheki_Damage_Calc_Test
{
    internal class Calculations
    {
        public static double FightCommand(SavedStats savedStats, double SOTBuffs, double PAA)
        {
            savedStats.StrengthStat = savedStats.StrengthStat * SOTBuffs;
            double Calced = ((Math.Sqrt(savedStats.WeaponPower) * (Math.Sqrt(savedStats.StrengthStat)) / (Math.Sqrt((savedStats.EnemyDefense * 8) + savedStats.EnemyArmor))));
            Calced = Calced * PAA;
            return Calced;
        }

        public static double PhysicalSkill(SavedStats savedStats, double SOTBuffs, double PAA)
        {
            savedStats.StrengthStat = savedStats.StrengthStat * SOTBuffs;
            double Calced = (savedStats.SkillPower * (Math.Sqrt(savedStats.StrengthStat)) / (Math.Sqrt((savedStats.EnemyDefense * 8) + savedStats.EnemyArmor)));
            Calced = Calced * PAA;
            return Calced;
        }

        public static double MagicSkill(SavedStats savedStats, double SOTBuffs, double PAA)
        {
            savedStats.MagicStat = savedStats.MagicStat * SOTBuffs;
            double Calced = (savedStats.SkillPower + (savedStats.SkillPower*(savedStats.MagicStat/30))) / (Math.Sqrt((savedStats.EnemyDefense * 8) + savedStats.EnemyArmor));
            Calced = Calced * PAA;
            return Calced;
        }

        public static double Crit(double Calced, Random CritRoll)
        {
            Console.WriteLine("How should I handle crit chance? \n1) My attack will crit \n2) My attack will NOT crit \n3) Roll for it (10% chance to crit)");

            // Check for how many ATK buffs and add them to the SOT buffs

            int CritChoice = CodeValidation.CVNumber("Please enter a valid integer.");
            switch (CritChoice)
            {
                case 1:
                    Calced = Calced * 1.3;
                    break;
                case 2:
                    break;
                case 3:
                    int CritChance = 0;
                    CritChance = CritRoll.Next(1, 11);
                    if (CritChance == 1)
                    {
                        Calced = Calced * 1.3;
                    }
                    break;
            }
            return Calced;
        }

        public static double Variance(double Variance, Random VarianceRoll)
        {
            Console.WriteLine("Press enter to roll for variance.");
            Console.ReadLine();
            double rand = VarianceRoll.NextDouble() * (1.05 - .95) + .95;
            rand = Math.Round(rand, 2);
            Console.WriteLine("Your random variance is {0}.", rand);
            return rand;
        }

        public static double EnemyDR(double Calced)
        {
            Console.WriteLine("Enter the amount of damage reduction as a whole number (1-99).");
            int DRValue = CodeValidation.CVNumber("Please enter a valid integer.");
            DRValue = (100 - DRValue) / 10;
            Calced = Calced * DRValue;
            return Calced;


        }



    }
}
