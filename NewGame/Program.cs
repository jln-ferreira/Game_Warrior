using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //_______________________Hero_______________________________
            List<Hero> MyHero = new List<Hero>();
            Hero Warrior = new Hero(); //15,5,3,3,0 (HP,STR,DEF,AGI)
            Hero Knight = new Hero("Knight", 18, 5, 2, 4, true, 1, new List<Itens>()); //(HP,STR,DEF,AGI, MANA, EXP, LIST BAG)
            Hero Swordman = new Hero("Swordman", 20, 7, 3, 6, true, 10, new List<Itens>()); //(HP,STR,DEF,AGI, MANA, EXP, LIST BAG)
            Hero Guardian = new Hero("Guardian", 20, 8, 3, 6, true, 20, new List<Itens>()); //(HP,STR,DEF,AGI, MANA, EXP, LIST BAG)
            Hero Paladin = new Hero("Paladin", 21, 9, 3, 6, true, 32, new List<Itens>()); //(HP,STR,DEF,AGI, MANA, EXP, LIST BAG)
            Hero WarLord = new Hero("WarLord", 23, 10, 4, 6, true, 50, new List<Itens>()); //(HP,STR,DEF,AGI, MANA, EXP, LIST BAG)
            Hero Apollo = new Hero("Apollo", 25, 11, 4, 10, true, 70, new List<Itens>()); //(HP,STR,DEF,AGI, MANA, EXP, LIST BAG)

            //List of Heroes to evolue!
            MyHero.Add(Warrior);//[1]
            MyHero.Add(Knight);//[2]
            MyHero.Add(Swordman);//[3]
            MyHero.Add(Guardian);//[4]
            MyHero.Add(Paladin);//[5]
            MyHero.Add(WarLord);//[6]
            MyHero.Add(Apollo);//[7]

            //_______________________Monster_______________________________
            List<Monsters> MyMonsters = new List<Monsters>();
            //Monsters (enemies)
            Monsters Spider = new Monsters("Spider", 7, 4, 1, 1, 1); //(Name, HP, STR, DEF, AGI, EXP)
            Monsters Bull = new Monsters("Bull", 13, 4, 2, 2, 5); //(Name, HP, STR, DEF, AGI, EXP)
            Monsters Skeleton = new Monsters("Skeleton", 15, 6, 1, 3, 7); //(Name, HP, STR, DEF, AGI, EXP)
            Monsters Lich = new Monsters("Lich", 16, 6, 2, 3, 10); //(Name, HP, STR, DEF, AGI, EXP)
            Monsters Golen = new Monsters("Golen", 18, 6, 2, 4, 15); //(Name, HP, STR, DEF, AGI, EXP)
            Monsters Yety = new Monsters("Yety", 20, 6, 3, 6, 19); //(Name, HP, STR, DEF, AGI, EXP)
            Monsters Warewolf = new Monsters("Warewolf", 25, 6, 4, 10, 28); //(Name, HP, STR, DEF, AGI, EXP)
            Monsters Queen_Bee = new Monsters("Queen Bee", 27, 7, 5, 20, 32); //(Name, HP, STR, DEF, AGI, EXP)
            Monsters Nightmare = new Monsters("Nightmare", 35, 8, 5, 15,39); //(Name, HP, STR, DEF, AGI, EXP)
            Monsters Erohim = new Monsters("Erohim", 45, 10, 8, 15, 45); //(Name, HP, STR, DEF, AGI, EXP)
            Monsters Devil = new Monsters("Devil", 55, 12, 7, 20, 66); //(Name, HP, STR, DEF, AGI, EXP)
            Monsters MichaelJackson = new Monsters("Michael Jackson", 123, 58, 10, 33, 1000); //(Name, HP, STR, DEF, AGI, EXP)

            //create a list of Monsters to follow my attack
            MyMonsters.Add(Spider); //[0]
            MyMonsters.Add(Bull); //[1]
            MyMonsters.Add(Skeleton); //[2]
            MyMonsters.Add(Lich);//[3]
            MyMonsters.Add(Golen);//[4]
            MyMonsters.Add(Yety);//[5]
            MyMonsters.Add(Warewolf);//[6]
            MyMonsters.Add(Queen_Bee);//[7]
            MyMonsters.Add(Nightmare);//[8]
            MyMonsters.Add(Erohim);//[9]
            MyMonsters.Add(Devil);//[10]
            MyMonsters.Add(MichaelJackson);//[11]

            //_______________________Itens_______________________________
            List<Itens> totalItens = new List<Itens>();
            //Itens (Itens to use in battle)
            Itens SmallPotionHealth = new Itens("Small Health Potion", 7, 0, 0); //Name, HP, STR, DEF 
            Itens SmallPotionSTR = new Itens("Small Streght Potion", 0, 4, 0);
            Itens SmallPotionDEF = new Itens("Small Defense Potion", 0, 0, 4);
            Itens PotionWAR = new Itens("Small War Potion", 4, 3, 3);
            Itens HealthPotion = new Itens("Health Potion", 15, 1, 1);
            Itens SuperPotion = new Itens("Super Health Potion", 25, 3, 3);
            Itens MarioStar = new Itens("Mario Star", 13, 7, 7);
            Itens Mushroom = new Itens("Mushroom", 30, 3, 0);
            Itens Steroids = new Itens("Steroids", 0, 18, 10);
            Itens DragonBalls = new Itens("DragonBalls", 40, 10, 5);
            Itens InfinityStones = new Itens("Infinity Stones", 45, 19, 15);

            //insert all potion in the list Mylist
            totalItens.Add(SmallPotionHealth); //[0]
            totalItens.Add(SmallPotionSTR); //[1]
            totalItens.Add(SmallPotionDEF); //[2]
            totalItens.Add(PotionWAR); //[3]
            totalItens.Add(HealthPotion); //[4]
            totalItens.Add(SuperPotion); //[5]
            totalItens.Add(MarioStar); //[6]
            totalItens.Add(Mushroom); //[7]
            totalItens.Add(Steroids); //[8]
            totalItens.Add(DragonBalls); //[9]
            totalItens.Add(InfinityStones); //[10]

            //MY BAG
            //List<Itens> myItens = new List<Itens>();

            //___________GamePlay!______________
            //Introduction:
            Console.WriteLine("______Welcome to Warrior Game!_______\n");

            int countMonster = 0;
            int countHero = 0;

            while (countMonster != 12)
            {
                if (MyHero[countHero].HP > 0) //if the hero is dead, don`t comeback to loop
                {
                    Console.WriteLine($"Your Hero is {MyHero[countHero].Name}:\n");
                    MyHero[countHero].StatusHero();

                    Console.WriteLine($"Your Enemy is {MyMonsters[countMonster].Name}:\n");
                    MyMonsters[countMonster].StatusMonster();

                    //__________________________Battle___________________________

                    Console.WriteLine("\n Battle TIME!\n");
                    Console.WriteLine("1. ATTACK      2. SPECIAL ATTACK    3. ITENS    4.RUN");
                    string hitorruin = Console.ReadLine();
                    int hitorruinInt;

                    bool canCoverted = int.TryParse(hitorruin, out hitorruinInt); //convert first Hit or run

                    if (!canCoverted) Console.WriteLine("GAME OVER!"); //if the player input diferent numbers than 1 (attack), 2 (Special Attack) or 3 ( Run)
                    else //if the choose was correct (number 1 , 2 or 3)
                    {
                        switch (hitorruinInt)   
                        {
                            case 1: //I want to ATTACK!
                                Console.WriteLine($"You Attacked {MyMonsters[countMonster].Name}\n");
                                Console.WriteLine($"His HP = {MyMonsters[countMonster].HP = MyMonsters[countMonster].HP - MyHero[countHero].STR + MyMonsters[countMonster].DEF}\n");

                                if (MyMonsters[countMonster].HP <= 0) //if you kill the monster
                                {
                                    Console.WriteLine($"You Killed the Monster {MyMonsters[countMonster].Name} !");

                                    //receive the EXP of the monster:
                                    MyHero[countHero].EXP -= MyMonsters[countMonster].EXP;

                                    if (MyHero[countHero].EXP <= 0) //I Change character
                                    {
                                        countHero = countHero + 1; //changed
                                        Console.WriteLine("*****************************\n" +
                                                            "Your Uped the LVL!\n" +
                                                          "*****************************");

                                        MyHero[countHero].MyBag = MyHero[countHero -1].MyBag;//Pass the bag from old hero to new Hero //=-----------------------CHANGED 
                                    }

                                    //EARN NEW ITEM AFTER KILL THE MONSTER

                                    MyHero[countHero].MyBag.Add(totalItens[countMonster]);//earn item after kill the monster //=-----------------------CHANGED 

                                    Console.WriteLine("*****************************\n" +
                                                            "You earned the item " + totalItens[countMonster].Name + "! \n" +
                                                          "*****************************");

                                    countMonster = countMonster + 1;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"The Monster: {MyMonsters[countMonster].Name} attacked you:\n");
                                    Console.WriteLine($"Your HP = {MyHero[countHero].HP = MyHero[countHero].HP - (MyMonsters[countMonster].STR - MyHero[countHero].DEF)}\n");
                                    if (MyHero[countHero].HP <= 0)
                                    {
                                        Console.WriteLine($"You died!!!");
                                        Console.WriteLine($"___________________GAME OVER_________________");
                                        break;
                                    }
                                }
                                continue;
                            case 2: // case Want to use special attack
                                if (MyHero[countHero].MANA) //if Hero has Mana to attack
                                {
                                    Console.WriteLine($"You Attacked {MyMonsters[countMonster].Name} With Special Attack! Your damege was : {MyHero[countHero].STR * 2};\n");
                                    Console.WriteLine($"His HP = {MyMonsters[countMonster].HP = MyMonsters[countMonster].HP - (MyHero[countHero].STR * 2) + MyMonsters[countMonster].DEF}\n");
                                    MyHero[countHero].MANA = false;

                                    if (MyMonsters[countMonster].HP <= 0)
                                    {
                                        Console.WriteLine($"You Killed the Monster {MyMonsters[countMonster].Name} !");

                                        //receive the EXP of the monster:
                                        MyHero[countHero].EXP -= MyMonsters[countMonster].EXP;

                                        if (MyHero[countHero].EXP <= 0) //I Change character
                                        {
                                            countHero = countHero + 1; //changed
                                            Console.WriteLine("*****************************\n" +
                                                                "Your Uped the LVL!\n" +
                                                              "*****************************");
                                            MyHero[countHero].MyBag = MyHero[countHero - 1].MyBag;//Pass the bag from old hero to new Hero //=-----------------------CHANGED 
                                        }

                                        //EARN NEW ITEM AFTER KILL THE MONSTER
                                        MyHero[countHero].MyBag.Add(totalItens[countMonster]);//earn item after kill the monster //=-----------------------CHANGED 

                                        Console.WriteLine("*****************************\n" +
                                                                "You earned the item " + totalItens[countMonster].Name + "! \n" +
                                                              "*****************************");

                                        countMonster = countMonster + 1;
                                        break;
                                    }
                                    else
                                    {//ATTACK from MONSTER
                                        Console.WriteLine($"The Monster: {MyMonsters[countMonster].Name} attacked you:\n");
                                        Console.WriteLine($"Your HP = {MyHero[countHero].HP = MyHero[countHero].HP - (MyMonsters[countMonster].STR - MyHero[countHero].DEF)}\n");
                                        if (MyHero[countHero].HP <= 0) //if HERO DIED
                                        {
                                            Console.WriteLine("You died!!!");
                                            Console.WriteLine("___________________GAME OVER_________________");
                                            break;
                                        }
                                    }
                                }
                                else //if the HERO doen`t have MANA
                                {
                                    Console.WriteLine($"Your Hero Doen`t have MANA enough!");
                                    break;
                                }
                                break;

                            case 3://Use Potion 

                                Console.WriteLine("You opened your Bag and your itens are: ");

                                //--------------------SHOW INSIDE BEG ---------------------//
                                int countItensBag = 0; ///count of number of itens inside forloop:
                               
                                if(MyHero[countHero].MyBag.Count()!=0) //try to show the bag (if there is something inside) //------------CHANGED
                                {
                                    //for loop to access all itens inside my Bag
                                    foreach (var item in MyHero[countHero].MyBag)
                                    {
                                        Console.WriteLine("[" + countItensBag + "] " + item.Name + " - Increase of : HP: " + item.HP + ", STR: " + item.STR + ", DEF:" + item.DEF);
                                        countItensBag += 1;
                                    }

                                    //--------------------USE ITEM---------------------//               
                                    int itmUsageInt; //variable to hold the option for item
                                    Console.WriteLine("\nChoose your item: ");
                                    string itmUsageStr = Console.ReadLine();

                                    //see if was right coise (integer)
                                    bool canCovertedItem = int.TryParse(itmUsageStr, out itmUsageInt);                          

                                    if (!canCovertedItem) Console.WriteLine("You didn`t choose a right option.");
                                    
                                    else //if the choose was correct (integer)
                                    {
                                        if (itmUsageInt < MyHero[countHero].MyBag.Count() && itmUsageInt >= 0) //if the number if item is between what the user has inside the bag
                                        {
                                            //add all atributes of the item in the HERO
                                            Console.WriteLine("You used the item "+ MyHero[countHero].MyBag[itmUsageInt].Name);
                                            MyHero[countHero].HP = MyHero[countHero].HP + MyHero[countHero].MyBag[itmUsageInt].HP; //add HP
                                            MyHero[countHero].STR = MyHero[countHero].STR + MyHero[countHero].MyBag[itmUsageInt].STR; //add STR
                                            MyHero[countHero].DEF = MyHero[countHero].DEF + MyHero[countHero].MyBag[itmUsageInt].DEF; //add STR

                                            //delete the item used
                                            MyHero[countHero].MyBag.RemoveAt(itmUsageInt);

                                            //status hero:
                                            MyHero[countHero].StatusHero();

                                            //ATTACK from MONSTER after potion
                                            Console.WriteLine($"The Monster: {MyMonsters[countMonster].Name} attacked you:\n");
                                            Console.WriteLine($"Your HP = {MyHero[countHero].HP = MyHero[countHero].HP - (MyMonsters[countMonster].STR - MyHero[countHero].DEF)}\n");
                                            if (MyHero[countHero].HP <= 0) //if HERO DIED
                                            {
                                                Console.WriteLine("You died!!!");
                                                Console.WriteLine("___________________GAME OVER_________________");
                                                break;
                                            }
                                        }
                                        else //if the user choose a wrong number (no item with with item)
                                        {
                                            Console.WriteLine("You didn`t choose a right option.");
                                        }
                                    }
                                }
                                else //if there is nothing inside the bag
                                {
                                    Console.WriteLine("There is nothing inside.");
                                }
                                break;

                            case 4: //Let`s RUN from monster
                                if (MyMonsters[countMonster].AGI < MyHero[countHero].AGI) //if my hero has more AGI than monster, can run
                                {
                                    countMonster = countMonster + 1;
                                    Console.WriteLine("You just Ran!");
                                }
                                else //HERO Can`t RUN. Monster has more AGI than HERO
                                {
                                    Console.WriteLine($"You can`t run! Monster`s Agility is {MyMonsters[countMonster].AGI} and your is {MyHero[countHero].AGI}.");
                                }
                                break;
                        }
                        string hitorruin1 = Console.ReadLine(); //stop debugging
                    }
                }
                else break; //break the game if the HERO DIE (start right under the while loop)
            }  
        }       
    }
}
