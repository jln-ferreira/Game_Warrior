using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
    public class Monsters: Char
    {
        //My Monsters

        //public string Name { get; set; } //NAME OF THE MONSTER
        //public int HP { get; set; } //LIFE
        //public int STR { get; set; } //STRENGHT
        //public int DEF { get; set; } //DEFENSE
        //public int AGI { get; set; } //AGILITY
        //int EXP {get; set;} //EXPERIENCE

        //_____Contructor Overload_____
        public Monsters(string Name, int HP, int STR, int DEF,int AGI, int EXP)
        {
            this.Name = Name;
            this.HP = HP;
            this.STR = STR;
            this.DEF = DEF;
            this.AGI = AGI;
            this.EXP = EXP;
        }

        //______Method will show Monster Status______
        public void StatusMonster()
        {
            Console.WriteLine("Status of the {0}\n" +
                                        "HP = {1};\n" +
                                        "STR = {2};\n" +
                                        "DEF = {3};\n" +
                                        "AGI = {4};\n" +
                                        "EXP = {5};\n", Name, HP, STR, DEF, AGI, EXP);
        }
    }
}
