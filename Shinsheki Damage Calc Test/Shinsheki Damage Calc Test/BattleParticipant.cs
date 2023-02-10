using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinsheki_Damage_Calc_Test
{
    internal abstract class BattleParticipant
    {
        // Fields

        int maxHP;

        public int MaxHP
        {
            get { return maxHP; }
            set {
                if (value <= 0)
                {
                    Console.WriteLine("Max HP cannot be lower than 1. Setting it to 1.");
                    maxHP = 1;
                }
                else
                {
                    maxHP = value;
                }
            }
        }

        int currentHP;

        public int CurrentHP
        {
            get { return currentHP; }
            set
            {
                if (value <= -1)
                {
                    Console.WriteLine("Current HP cannot be lower than 0. Setting it to 0.");
                    currentHP = 0;
                }
                else
                {
                    currentHP = value;
                }
            }
        }

        int maxSP;

        public int MaxSP
        {
            get { return maxSP; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Max SP cannot be lower than 1. Setting it to 1.");
                    maxSP = 1;
                }
                else
                {
                    maxSP = value;
                }
            }
        }

        int currentSP;

        public int CurrentSP
        {
            get { return currentSP; }
            set
            {
                if (value <= -1)
                {
                    Console.WriteLine("Current SP cannot be lower than 0. Setting it to 0.");
                    currentSP = 0;
                }
                else
                {
                    currentSP = value;
                }
            }
        }

        int str;
        public int Strength
        {
            get { return str; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Strength stat cannot be lower than 1. Setting it to 1.");
                    str = 1;
                }
                else
                {
                    str = value;
                }
            }
        }

        int mag;

        public int Magic
        {
            get { return mag; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Magic stat cannot be lower than 1. Setting it to 1.");
                    mag = 1;
                }
                else
                {
                    mag = value;
                }
            }
        }

        int luck;

        public int Luck
        {
            get { return luck; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Luck stat cannot be lower than 1. Setting it to 1.");
                    luck = 1;
                }
                else
                {
                    luck = value;
                }
            }
        }

        int agl;

        public int Agility
        {
            get { return agl; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Agility stat cannot be lower than 1. Setting it to 1.");
                    agl = 1;
                }
                else
                {
                    agl = value;
                }
            }
        }

        int def;

        public int Defense
        {
            get { return def; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Defense stat cannot be lower than 1. Setting it to 1.");
                    def = 1;
                }
                else
                {
                    def = value;
                }
            }
        }

        int armor;

        public int Armor
        {
            get { return armor; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Defense stat cannot be lower than 1. Setting it to 1.");
                    armor = 1;
                }
                else
                {
                    armor = value;
                }
            }
        }

        List<Skill> usuableSkills = new List<Skill>();
    }
}
