using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using characterLibrary;

namespace DantesInferno
{
    public class DantesInfernoApplication
    {
        static void Main(string[] args)
        {
            Console.Title = "Dante's Inferno";
            Console.WriteLine("This will not be easy....");

            //1 create a player
            //we need to learn about custom classes first

            Console.WriteLine("Hey, what is your name? ");
            bool naming = true;

            string name = "";
            do
            {
                name = Console.ReadLine();
                naming = name.Length <= 20 ? false : true;
                Console.WriteLine("{0}", naming == true ? "Please enter a valid name" : "");
            } while (naming);



            Character Hero = new Character();
            Hero.MaxHealth = 150;
            Hero.Health = 150;
            Hero.Name = name;
            Hero.Weapon = new Sword(2, 30);
            Character Monster = new Character();
            int MonsterSelector = 0;

            Console.WriteLine("Ok, {0} lets begin this journey... It will be challenging! Take this sword!\n", Hero.Name);

            //2 create a loop for the room
            bool exit = false;

            do
            {
                //3 create a room - write a () to get a room description
                Console.WriteLine(GetRoom(MonsterSelector));

                //4 create a monster
                //we need to learn about creating objects and then probably randomly
                //select one
                Monster = Character.GetMonster(MonsterSelector);
                Console.WriteLine("{0} has entered the room!", Monster.Name);
                MonsterSelector++;

                //5 create a loop for the menu
                bool reload = false;

                do
                {
                    //6 create a menu of options that tells the player what they can do

                    #region MENU
                    Console.WriteLine("\nPlease choose an action:\nA) Attack\nR) Run Away\n" +
                        "P) Player Info\nM) Monster Info\nX) Exit\n");

                    //7 Catch the users input
                    ConsoleKey userChoice = Console.ReadKey(true).Key;

                    //8 Clear the console after the user input to clean up the screen
                    Console.Clear();

                    //9 Build out a switch for userChoice
                    switch (userChoice)
                    {
                        case ConsoleKey.A:
                            //TODO 10 Engage battle sequence
                            //TODO 11 Handle if the player wins
                            break;
                        case ConsoleKey.R:
                            Console.WriteLine("Run Away!!!");
                            //TODO 12 Handle running away and getting a new room
                            //TODO 13 Monster gets a free attack
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Info");
                            //TODO 14 Need to print out player info
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster Info");
                            //TODO 15 Need to print out monster info
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("This speaks of your character...");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("It is sin that brought you here, do not continue. " +
                                "Try something else that might be truer to your heart." +
                                "Otherwise, you may never make it out!");
                            break;
                    }
                    #endregion

                } while (!exit && !reload);

            } while (!exit);
        }//end Main()
        private static string GetRoom(int selector)
        {
            string[] rooms = {
                "A dark mist and think clouds fill the air, and the taste of death is on your tongue.",
                "An island cries. Difficult to see through the fog, but it appears the trees are people!",
                "A river divides the banks of nothingness and dispair. The sound of thunder crackles."

            };
            

            string room = rooms[selector];

            return room;
        }
    }//end class
}//end namespace
