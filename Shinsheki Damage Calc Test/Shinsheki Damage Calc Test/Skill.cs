using ShinshekiDamageCalcer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinsheki_Damage_Calc_Test
{
    internal class Skill
    {
        // Fields

        ElementType ElementType; // Elemental type
        int sp; // Skill Power
        int acc; // Accuracy
        int crit; // Crit chance
        int cost; // Cost
        string desc; // Description
        string name; // Skill Name

        static List<Skill> skillList; // All Skills

        public static List<Skill> SkillList
        {
            get { return skillList; }
        }

        // Constructor

        public Skill(string name, string desc, int sp, int acc, int crit, int cost, ElementType elementType)
        {
            this.sp = sp;
            this.acc = acc;
            this.crit = crit;
            this.cost = cost;
            this.name = name;
            this.desc = desc;
            this.name = name;
            this.ElementType = elementType;
        }

        // Methods

        public int Calculate(Player player, Enemy enemy)
        {
            double Calced;
            Random rand = new Random();

            switch (this.ElementType)
            {
                case (ElementType.Phys):
                    player.Strength = (int)Math.Round(player.Strength * SOT_PAA.SOTbuffs);
                    Calced = (this.sp * (Math.Sqrt(player.Strength)) / (Math.Sqrt((enemy.Defense * 8) + enemy.Armor)));
                    Calced = Calced * SOT_PAA.paa;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Calculation was successful!");
                    
                    break;
                default:
                    player.Magic = (int)Math.Round(player.Magic * SOT_PAA.SOTbuffs);
                    Calced = (this.sp + (this.sp * (player.Magic / 30))) / (Math.Sqrt((enemy.Defense * 8) + enemy.Armor));
                    Calced = Calced * SOT_PAA.paa;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Calculation was successful!");
                    break;
            }

            Calculations.Crit(Calced, rand, this.crit);
            Calced = Calculations.Variance(rand);
            Calced = Calculations.EnemyDR(Calced);
            int final = (int)Math.Round(Calced);
            return final;

        }
        public static void Initialize()
        {
            try
            {
                skillList = new List<Skill>();
                StreamReader sr = new StreamReader("Skills.csv");
                List<string> Values = new List<string>();
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Values.Add(line);
                }
                sr.Close();

                string[] temp = new string[7]; // 3, 4, 5, 6 need to be parsed as ints and 7 needs to be parsed as enum
                int[] tempnums = new int[4];
                ElementType tempType;

                for (int i = 0; i < Values.Count; i++)
                {
                    temp = Values[i].Split(',');
                    tempnums[0] = int.Parse(temp[2]);
                    tempnums[1] = int.Parse(temp[3]);
                    tempnums[2] = int.Parse(temp[4]);
                    tempnums[3] = int.Parse(temp[5]);
                    tempType = (ElementType)Enum.Parse(typeof(ElementType), temp[6]);
                    Skill.skillList.Add(new Skill(temp[0], temp[1], tempnums[0], tempnums[1], tempnums[2], tempnums[3], tempType));
                }
            }
            catch(Exception vinny)
            {
                Console.WriteLine("Vinny error\n"+vinny);
            }
        }

        public override string ToString()
        {
            string ET_ts = this.ElementType.ToString();
            string ts = "Name - " + this.name + "\nDescription - " + this.desc + "\nSkill Power - " + this.sp + "\nCritical Chance - " + this.crit + "%\nCost - " + this.cost + "(HP if Phys, SP if Elemental)\nElemental Typing - " + ET_ts;
            return ts;
        }

    }
}
