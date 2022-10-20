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
            //Welcome to Damage Calcer

            Console.WriteLine("Welcome to the first Shinsheki damage calculator! Let's pray this thing actually works.");

            //Get all of the variables (Weapon Power, Strength Stat, Enemy Defense, Enemy Armor, Skill Power, Magic Stat)

            Console.WriteLine("To start things off, let's make sure we have all the variables we need. \n I'm going to run through all of them and you give me the answer, okay? \n Press any key to continue.");
            Console.ReadLine();

            string AllInfo = GetAllStats.GrabStats();

            // Split the string and convert variables to ints

            bool parse = false;
            AllInfo.Split(",");
            double WeaponPower;
            
            

            double SOTBuffs = 1;
            double PlusAnAdditional = 1;
            Random CritRoll = new Random();
            Random VarianceRoll = new Random();
            bool Passives = true;

            

            Console.WriteLine("How many ATK buffs? (0-3)");

            // Check for how many ATK buffs

            switch (Console.ReadLine().Trim().ToUpper())
            {
                case "0":
                    SOTBuffs = 1;
                    break;
                case "1":
                    SOTBuffs = 1.2;
                    break;
                case "2":
                    SOTBuffs = 1.4;
                    break;
                case "3":
                    SOTBuffs = 1.6;
                    break;
            }

            // Check for how many enemy DEF buffs

            Console.WriteLine("How many enemy DEF buffs?");
            switch (Console.ReadLine().Trim().ToUpper())
            {
                case "0":
                    break;
                case "1":
                    EnemyDefense = EnemyDefense * 1.2;
                    break;
                case "2":
                    EnemyDefense = EnemyDefense * 1.4;
                    break;
                case "3":
                    EnemyDefense = EnemyDefense * 1.6;
                    break;
            }

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

            //What formula you want boss

            Console.WriteLine("Now that we have all the variables, which formula would you like to use? \n 1) Fight Command \n 2) Physical Skills \n 3) Magic Skills");

            //Make a method for each Formula (Fight Command, Physical Skill, Magic Skill)
            //Send the needed information to the correct method
            //Give the final damage number
            //Write all of the methods on the bottom

        }

        


}


}
    
    

