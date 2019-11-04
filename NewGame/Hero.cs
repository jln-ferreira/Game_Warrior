using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
    //this class is for create a new hero
    public class Hero: Char
    {//atributes
        //string Name { get; set; }
        //int HP { get; set; }
        //int STR { get; set; }
        //int DEF { get; set; }
        //int AGI { get; set; }
        //int EXP {get; set;}
        public bool MANA { get; set; }
        public List<Itens> MyBag { get; set; }

        //_____Contructor Default_____
        public Hero()
        {
            Name = "Warrior"; //name of the HERO
            HP = 15; //HP = Life
            STR = 5; //STR = kill monsters
            DEF = 3; //ARMOR = hold more ATACK
            AGI = 3; //AGILITY = to run from monsters
            MANA = true; //MANA = Possibilities to use Special attack
            EXP = 1; //EXP = When the exp go < 0, Change character
            MyBag = new List<Itens>();
        }

        //_____Contructor Overload_____
        public Hero(string Name, int HP, int STR, int DEF, int AGI, bool MANA, int EXP, List<Itens> MyBag)
        {
            this.Name = Name;
            this.HP = HP;
            this.STR = STR;
            this.DEF = DEF;
            this.AGI = AGI;
            this.MANA = MANA;
            this.EXP = EXP;
            this.MyBag = MyBag;
        }

        //______Method will show Monster Status______
        public void StatusHero()
        {
            string manaName; //change name insted of (true and false) (Active and desactived)
            if (MANA) manaName = "Active";
            else manaName = "Desactived";

            Console.WriteLine("Status of the {0}\n" +
                            "HP = {1};\n" +
                            "STR = {2};\n" +
                            "DEF = {3};\n" +
                            "AGI = {4};\n" +
                            "MANA = {5};\n" +
                            "EXP = {6}.\n", Name, HP, STR, DEF, AGI, manaName, EXP);
        }
    }
}
