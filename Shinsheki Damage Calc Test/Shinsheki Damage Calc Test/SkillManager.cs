using ShinshekiDamageCalcer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shinsheki_Damage_Calc_Test
{
    internal class SkillManager
    {
        public static void Initialize()
        {
            try
            {
                Skill.SkillList = new List<Skill>();
                string[] temp = new string[7]; // 3, 4, 5, 6, and 9 need to be parsed as ints and 7 and 8 needs to be parsed as enum
                int[] tempnums = new int[5];
                ElementType tempType;
                SkillType tempskillType;

                List<string> Values = CodeValidation.ReadIn("Skills.csv");

                for (int i = 0; i < Values.Count; i++)
                {
                    temp = Values[i].Split(',');
                    tempnums[0] = int.Parse(temp[2]);
                    tempnums[1] = int.Parse(temp[3]);
                    tempnums[2] = int.Parse(temp[4]);
                    tempnums[3] = int.Parse(temp[5]);
                    tempType = (ElementType)Enum.Parse(typeof(ElementType), temp[6]);
                    tempskillType = (SkillType)Enum.Parse(typeof(SkillType), temp[7]);
                    tempnums[4] = int.Parse(temp[4]);
                    Skill.SkillList.Add(new Skill(temp[0], temp[1], tempnums[0], tempnums[1], tempnums[2], tempnums[3], tempType, tempskillType, tempnums[4]));
                }
            }
            catch (Exception vinny)
            {
                Console.WriteLine("Vinny error\n" + vinny);
            }
        }
    }
}
