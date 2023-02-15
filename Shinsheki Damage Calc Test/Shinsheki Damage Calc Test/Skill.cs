using ShinshekiDamageCalcer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinsheki_Damage_Calc_Test
{
    enum StatusCond
    {
        None,
        Knocked,
        Dizzy,
        Poison,
        Seal,
        Confusion,
        Enrage,
        Fear,
        Stun,
        Burn,
        Freeze,
        Shock,
        Hunger,
        Lethargy,
        SiSw
    }
    enum SkillType
    {
        Magic,
        Phys,
        MagicAndPhys,
        Heal,
        Status,
        Support,
        Passive,
        ULT
    }

    enum ElementType
    {
        Phys,
        Ice,
        Fire,
        Elec,
        Wind,
        Psy,
        Nuc,
        Bls,
        Cur,
        Alm
    }

    internal class Skill
    {
        static List<Skill> skillList; // All Skills

        public static List<Skill> SkillList
        {
            get { return skillList; }
            set { SkillList = value; }
        }

        // Fields

        SkillType SkillType; // Type of Skill
        ElementType ElementType; // Elemental type
        int sp; // Skill Power
        int acc; // Accuracy
        int ail; // Ailment Chance
        int crit; // Crit chance
        int cost; // Cost
        string desc; // Description
        string name; // Skill Name
        

        protected static List<Skill> allSkillList; // All Skills

        public static List<Skill> AllSkillList
        {
            get { return allSkillList; }
        }

        // Constructor

        public Skill(string name, string desc, int sp, int acc, int crit, int cost, ElementType elementType, SkillType skillType, int ail)
        {
            this.sp = sp;
            this.acc = acc;
            this.ail = ail;
            this.crit = crit;
            this.cost = cost;
            this.name = name;
            this.desc = desc;
            this.name = name;
            this.ElementType = elementType;
            this.SkillType = skillType;
        }

        // Methods

        public int CalculateDMG(Player player, Enemy enemy)
        {
            double Calced = 0;
            Random rand = new Random();

            switch (this.SkillType)
            {
                case (SkillType.Phys):
                    player.Strength = (int)Math.Round(player.Strength * SOT_PAA.SOTbuffs);
                    Calced = (this.sp * (Math.Sqrt(player.Strength)) / (Math.Sqrt((enemy.Defense * 8) + enemy.Armor)));
                    Calced = Calced * SOT_PAA.paa;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Calculation was successful!");
                    break;
                case (SkillType.Magic):
                    player.Magic = (int)Math.Round(player.Magic * SOT_PAA.SOTbuffs);
                    Calced = (this.sp + (this.sp * (player.Magic / 30))) / (Math.Sqrt((enemy.Defense * 8) + enemy.Armor));
                    Calced = Calced * SOT_PAA.paa;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Calculation was successful!");
                    break;
                case (SkillType.MagicAndPhys):
                    player.Strength = (int)Math.Round(player.Strength * SOT_PAA.SOTbuffs);
                    player.Magic = (int)Math.Round(player.Magic * SOT_PAA.SOTbuffs);
                    double C1 = (this.sp * (Math.Sqrt(player.Strength)) / (Math.Sqrt((enemy.Defense * 8) + enemy.Armor)));
                    double C2 = Calced = (this.sp + (this.sp * (player.Magic / 30))) / (Math.Sqrt((enemy.Defense * 8) + enemy.Armor));
                    Calced = (C1 / C2) + ((C1 / C2) / 2);
                    Calced = Calced * SOT_PAA.paa;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Calculation was successful!");
                    break;
                case (SkillType.Heal):
                    int rando = rand.Next(-5, 6);
                    Calced = Calced + rando;
                    break;
                /*
                 * case (SkillType.ULT)
                 * break;
                 */
            }

            Calculations.Crit(Calced, rand, this.crit);
            Calced = Calculations.Variance(rand);
            Calced = Calculations.EnemyDR(Calced, enemy.DR);
            int final = (int)Math.Round(Calced);
            return final;

        }

        // public StatusCond ChangeStatusCond(Enemy enemy)
        // public bool CalculateAilChance()
        // Make a method to give support
        // Use the crit chance to determine the type of buff to give w/support!
        // 

        public override string ToString()
        {
            string ET_ts = this.ElementType.ToString();
            string ts = "Name - " + this.name + "\nDescription - " + this.desc + "\nSkill Power - " + this.sp + "\nCritical Chance - " + this.crit + "%\nCost - " + this.cost + "(HP if Phys, SP if Elemental)\nElemental Typing - " + ET_ts;
            return ts;
        }

    }
}
