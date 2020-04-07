using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskofRain2Wiki
{
    class Items
    {
        public void ItemList()
        {
            List<string> Items = new List<string>();
            foreach (string item in new string[3] { "Tougher Times", "Soldiers Syringe", "Crowbar" })
            {
                Items.Add(item);
                Console.Write(item + ", ");
            }
        }
        public void TougherTimes()
        {
            int counter = 0;
            Console.WriteLine("Description :\nWhenever the player is dealt damage, there is a chance to ignore it per stack.");
            Console.WriteLine("When stacking tougher times, it should be noted that there is not a flat amount of chance to ignore damage per item.");
            Console.WriteLine("For example, if you have 1 Tougher Times, the chance to ignore damage is 13%, and at 2 Tough Times the chance is 23%. To have a 50% chance of ignoring damage, you will need 7 Tougher Times.");
            while (counter == 0)
            {
                Console.WriteLine("To see what your damage reduction would be with a certain amount of Tougher Times, please insert your number. Otherwise, type EXIT.");
                int number = 0;
                string choice = Console.ReadLine();
                bool tf = int.TryParse(choice, out number);
                if (tf == true)
                {
                    double damage = (1 - 1 / (0.15 * number + 1)) * 100;
                    Console.WriteLine(damage + "%");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (choice == "exit")
                {
                    ++counter;
                }
                else
                {
                    Console.WriteLine("Please input a correct value.");
                }
            }

        }
        public void SoldiersSyringe()
        {
            int counter = 0;
            Console.WriteLine("The Soldier's Syringe passively increasing attack speed and wind-up time of all abilities by 15%. Unlike the first game, this version doesn't cap out after 13 stacks.");
            Console.WriteLine("The soldiers syringe is one of the few items in the game that unconditionally increases DPS, and as such is very valuable for most clases.");
            Console.WriteLine("Plan to add tool tips depending on the character chosen, and what abilities benefit most from this item.");
            Console.WriteLine("To see what your damage reduction would be with a certain amount of Soldier's Syringes, please insert your number. Otherwise, type EXIT.");
            int number = 0;
            string choice = Console.ReadLine();
            bool tf = int.TryParse(choice, out number);
            while (counter == 0)
                if (tf == true)
                {
                    double attackspeed = number * 15;
                    Console.WriteLine(attackspeed + "%");

                }
                else if (choice == "exit")
                {
                    ++counter;
                }
                else
                {
                    Console.WriteLine("Please input a correct value.");
                }


        }
        public void CrowBar()
        {
            int counter = 0;
            Console.WriteLine("The crowbar increases the damage to enemies above 90% health by 150%, and stacking increases the damage by 50%. This means the Crowbar is most efficient with high-damage skills and items, as the bonus is lost almost instantly after the first few hits.");
            Console.WriteLine("Plan to add tool tips depending on the character chosen, and what abilities benefit most from this item.");
            while (counter == 0)
            {
                Console.WriteLine("To see what your increased damage output would be with a certain crowbars, please insert your number. Otherwise, type EXIT.");
                int number = 0;
                string choice = Console.ReadLine();
                bool tf = int.TryParse(choice, out number);
                if (tf == true)
                {
                    double damage = 150 + (50 * (number-1));
                    Console.WriteLine(damage + "%");
                    Console.ReadLine();
                    Console.Clear();

                }
                else if (choice == "exit")
                {
                    ++counter;
                }
                else
                {
                    Console.WriteLine("Please input a correct value.");
                }
            }
        }
    }
}
