﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinsheki_Damage_Calc_Test
{
    internal class SOT_PAA
    {
        // Tier 1, Tier 2, Tier 3
        static double[] MagicianRally = new double[] { 1.03, 1.05, 1.10};
        static double[] EmperorOnslaught = new double[] { 1.03, 1.05, 1.10 };
        static double[] ULTEmperorOnslaught = new double[] { 1.10, 1.25 };
        static double[] StrengthChariot = new double[] { 1.09, 1.15, 1.30 };

        static double SOTBuffs = 1;

        public double SOTbuffs
        {
            get { return SOTBuffs; }
            set { if (value >= 100)
                {
                    Console.WriteLine("SOT buffs cannot be greater than 100.");
                    SOTBuffs = 99;
                }
                if (value <= 0)
                {
                    Console.WriteLine("SOT buffs cannot be lower than 0.");
                    SOTBuffs = 1;
                }

                SOTBuffs = value;
                    
            }
        }

        static double PAA = 1;

        public double paa
        {
            get { return PAA; }
            set
            {
                if (value >= 100)
                {
                    Console.WriteLine("PAA buffs cannot be greater than 100.");
                    PAA = 99;
                }
                if (value <= 0)
                {
                    Console.WriteLine("PAA buffs cannot be lower than 0.");
                    PAA = 1;
                }

                PAA = value;

            }
        }

        Random VarianceRoll = new Random();
        

        public static double ATKBuffs(double SOTBuffs)
            {
                Console.WriteLine("How many ATK buffs? (1-4) \n (1 being no buffs and 4 being 3 buffs)");

                // Check for how many ATK buffs and add them to the SOT buffs

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

        public static void Passives(SavedStats savedStats)
            {

            // Loop while the user adds as many passives as they want
            bool WantPassives = true;

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
                                savedStats.MagicStat = AddMagicianRally(savedStats.MagicStat, PAA);
                                break;
                            case "2":
                                savedStats.StrengthStat = AddEmperorOnslaught(savedStats.StrengthStat, PAA);
                                break;
                            case "3":
                                savedStats.StrengthStat = AddStrengthChariot(savedStats.StrengthStat, PAA, false);
                                break;
                            case "4":
                                savedStats.StrengthStat = AddStrengthChariot(savedStats.StrengthStat, PAA, true);
                                break;
                        }
                        break;
                    case "N":
                        WantPassives = false;
                        break;
                }

            }
            while (WantPassives == true);
        }

        public static double AddMagicianRally(double MagicStat, double PAA)
        {
            Console.WriteLine("What tier is Magician's Rally? \n1)Tier 1 \nTier 2 \n3) Tier 3 \n4) Tier 3 + fire skill");
            int TierChoice = CodeValidation.CVNumber("Please enter a valid integer.");
            switch (TierChoice)
            {
                case 1:
                    MagicStat = MagicStat * MagicianRally[0];
                    break;
                case 2:
                    MagicStat = MagicStat * MagicianRally[1];
                    break;
                case 3:
                    MagicStat = MagicStat * MagicianRally[2];
                    break;
                case 4:
                    MagicStat = MagicStat * MagicianRally[2];
                    PAA = PAA * 1.05;
                    break;
            }
            return MagicStat;
        }

        public static double AddEmperorOnslaught(double StrengthStat, double PAA)
        {
            Console.WriteLine("What tier is Emperor's Onslaught? \n1)Tier 1 \nTier 2 \n3) Tier 3");
            int TierChoice = CodeValidation.CVNumber("Please enter a valid integer.");
            switch (TierChoice)
            {
                case 1:
                    PAA = PAA * EmperorOnslaught[0];
                    break;
                case 2:
                    PAA = PAA * EmperorOnslaught[1];
                    break;
                case 3:
                    PAA = PAA * EmperorOnslaught[2];
                    StrengthStat = StrengthStat * 1.05;
                    break;
            }
            return StrengthStat;
        }

        public static double AddStrengthChariot(double StrengthStat, double PAA, bool ChariotOrStrength)
        {
            Console.WriteLine("What tier is the passive? \n1)Tier 1 \nTier 2 \n3) Tier 3");
            int TierChoice = CodeValidation.CVNumber("Please enter a valid integer.");
            switch (TierChoice)
            {
                case 1:
                    PAA = PAA * StrengthChariot[0];
                    break;
                case 2:
                    PAA = PAA * StrengthChariot[1];
                    break;
                case 3:
                    PAA = PAA * StrengthChariot[2];
                    break;
            }
            if (ChariotOrStrength == true)
            {
                StrengthStat = StrengthStat * 1.10;
            }
            return StrengthStat;
        }

    }
}
