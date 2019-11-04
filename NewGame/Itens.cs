using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
    public class Itens
    { //this class is for create a Itens to use between battle
        public string Name { get; set; }
        public int HP { get; set; }
        public int STR { get; set; }
        public int DEF { get; set; }

        //_____Contructor Default_____
        public Itens()
        {
            Name = "Small Health Potion"; //name of the item
            HP = 7; //HP = Life
            STR = 0; //STR = Increase str of the Hero
            DEF = 0; //DEF = Increase Def of the Hero
        }

        //_____Contructor Overload_____
        public Itens(string Name, int HP, int STR, int DEF)
        {
            this.Name = Name;
            this.HP = HP;
            this.STR = STR;
            this.DEF = DEF;
        }
    }
}
