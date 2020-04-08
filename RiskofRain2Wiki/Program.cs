using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RiskofRain2Wiki
{
    class Program
    {
        static void Main(string[] args)
        {
            Characters characters = new Characters();
            Items items = new Items();
            int counter = 0;
            Console.WriteLine("Welcome to Brandon's crappy Risk of Rain 2 offline Wiki! What would you like to look up?");
            while (counter == 0)
            {
                Console.WriteLine("Choose one \n| Characters | Items | exit");
                string choice = Console.ReadLine().ToLower();
                if (choice == "characters")
                {
                    Console.WriteLine("Please Choose a character: ");
                    characters.CharacterList();
                    string charChoice = Console.ReadLine().ToLower();

                    switch (charChoice)
                    {
                        case "commando":
                            {
                                characters.Commando();
                                break;


                            }

                        case "huntress":
                            {
                                characters.Huntress();
                                break;
                            }

                        case "mul-t":
                            {
                                characters.MULT();
                                break;
                            }

                        case "engineer":
                            {
                                characters.Engineer();
                                break;
                            }

                        case "artificer":
                            {
                                characters.Artificer();
                                break;
                            }

                        case "mercenary":
                            {
                                characters.Mercenary();
                                break;
                            }

                        case "rex":
                            {
                                characters.Rex();
                                break;
                            }

                        case "loader":
                            {
                                characters.Loader();
                                break;
                            }

                        case "acrid":
                            {
                                characters.Acrid();
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                else if (choice == "items")
                {
                    Console.WriteLine("To see all items, type ALL. To see common, uncommon, rare, boss, or lunar items specifically, please identify which one.");
                    items.CommonItemList();
                    Console.WriteLine();
                    items.UncommonItemList();
                    Console.WriteLine();
                    items.RareItemList();
                    Console.WriteLine();
                    items.BossItemList();
                    Console.WriteLine();
                    items.LunarItemList();
                    Console.WriteLine();
                    choice = Console.ReadLine().ToLower();
                    switch (choice)
                    {
                        case "tougher times":
                            {
                                items.TougherTimes();
                                break;
                            }
                        case "soldiers syringe":
                            {
                                items.SoldiersSyringe();
                                break;
                            }
                        case "crowbar":
                            {
                                items.CrowBar();
                                break;
                            }
                    }
                }

                else if (choice == "exit")
                {
                    ++counter;
                }
                else
                {
                    Console.WriteLine("Please input a correct response.");
                }

            }
            }
        }
    }

