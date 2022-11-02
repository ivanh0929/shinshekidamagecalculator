using System;
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Calculation was successful!");
            return Calced;
        }

        public static double PhysicalSkill(SavedStats savedStats, double SOTBuffs, double PAA)
        {
            savedStats.StrengthStat = savedStats.StrengthStat * SOTBuffs;
            double Calced = (savedStats.SkillPower * (Math.Sqrt(savedStats.StrengthStat)) / (Math.Sqrt((savedStats.EnemyDefense * 8) + savedStats.EnemyArmor)));
            Calced = Calced * PAA;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Calculation was successful!");
            return Calced;
        }

        public static double MagicSkill(SavedStats savedStats, double SOTBuffs, double PAA)
        {
            savedStats.MagicStat = savedStats.MagicStat * SOTBuffs;
            double Calced = (savedStats.SkillPower + (savedStats.SkillPower*(savedStats.MagicStat/30))) / (Math.Sqrt((savedStats.EnemyDefense * 8) + savedStats.EnemyArmor));
            Calced = Calced * PAA;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Calculation was successful!");
            return Calced;
        }

        public static double Crit(double Calced, Random CritRoll)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("How should I handle crit chance? \n1) My attack will crit \n2) My attack will NOT crit \n3) Roll for it (10% chance to crit) \n4)My attack is effective against all types");

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
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your attack was a critical hit!");
                        Calced = Calced * 1.3;
                    }
                    else
                    {
                        Console.WriteLine("Your attack didn't crit...");
                    }
                    break;
                case 4:
                    Calced = Calced * 1.1;
                    break;
            }
            return Calced;
        }

        public static double Variance(Random VarianceRoll)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press enter to roll for variance.");
            Console.ReadLine();
            double rand = VarianceRoll.NextDouble() * (1.05 - .95) + .95;
            rand = Math.Round(rand, 2);
            Console.WriteLine("Your random variance is {0}.", rand);
            return rand;
        }

        public static double EnemyDR(double Calced)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter the amount of damage reduction as a whole number (0-99).");
            int DRValue = CodeValidation.CVNumber("Please enter a valid integer.");
            if(DRValue >= 1)
            {
                DRValue = (100 - DRValue) / 10;
                Calced = Calced * DRValue;
            }
            return Calced;


        }



    }
}
