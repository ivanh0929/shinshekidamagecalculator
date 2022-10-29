using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinsheki_Damage_Calc_Test
{
    internal class Calcs
    {
        static double[] MagicianRally = new double[] { 1.03, 1.05, 1.10, 1.15 };
        static double[] EmperorOnslaught = new double[] { 1.03, 1.05, 1.10 };
        static double[] ULTEmperorOnslaught = new double[] { 1.10, 1.25 };
        static double[] BurgeoningStrength = new double[] { 1.09, 1.15, 1.30 };

        double SOTBuffs = 1;
        double PlusAnAdditional = 1;
        Random CritRoll = new Random();
        Random VarianceRoll = new Random();
        bool Passives = true;

        public static double ATKBuffs(double SOTBuffs)
            {
                Console.WriteLine("How many ATK buffs? (1-4) \n (1 being no buffs and 4 being 3 buffs)");

                // Check for how many ATK buffs

                int ATKBuffChoice = CodeValidation.CVNumber("Please enter a valid integer.");
                switch (ATKBuffChoice)
                {
                    case 1:
                        SOTBuffs = 1;
                        break;
                    case 2:
                        SOTBuffs = 1.2;
                        break;
                    case 3:
                        SOTBuffs = 1.4;
                        break;
                    case 4:
                        SOTBuffs = 1.6;
                        break;
                }
                return SOTBuffs;
            
        }
        
            // Check for how many enemy DEF buffs
            
            public static double DEFBuffs(double EnemyDefense)
            {
                Console.WriteLine("How many enemy DEF buffs? (1-4) \n (1 being no buffs and 4 being 3 buffs)");
                int DEFBuffChoice = CodeValidation.CVNumber("Please enter a valid integer.");
                    switch (DEFBuffChoice)
                    {
                        case 1:
                            break;
                        case 2:
                            EnemyDefense = EnemyDefense * 1.2;
                            break;
                        case 3:
                            EnemyDefense = EnemyDefense * 1.4;
                            break;
                        case 4:
                            EnemyDefense = EnemyDefense * 1.6;
                            break;
                    }
                return EnemyDefense;
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

        /*
            // Loop while the user adds as many passives as they want

            do
            {
                Console.WriteLine("Any passive abilities active? (Y/N)");
                string KeepAskingForPassives = Console.ReadLine().Trim().ToUpper();

                switch ((KeepAskingForPassives))
                {
                    case "Y":
                        Console.WriteLine("Choose which ability is active. \n 0) None \n 1) Magician's Rally \n 2) Emperor's Onslaught \n 3) Chariot's Safeguard \n 4) Burgeoning Strength");
                        switch (Console.ReadLine())
                        {
                            case "0":
                                break;
                            case "1":
                                MagicStat = MagicStat * 1.1;
                                break;
                            case "2":
                                StrengthStat = StrengthStat * 1.1;
                                break;
                            case "3":
                                PlusAnAdditional = PlusAnAdditional + 0.3;
                                break;
                            case "4":
                                PlusAnAdditional = PlusAnAdditional + 0.3;
                                SOTBuffs = SOTBuffs + 0.1;
                                break;
                        }
                        break;
                    case "N":
                        Passives = false;
                        break;
                }

            }
            while (Passives == true);
        */

    }
}
