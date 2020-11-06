using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using characterLibrary;

namespace Testing
{
    class TestEnvironment
    {
        static void Main(string[] args)
        {
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
            

            Console.WriteLine("Ok, {0} lets begin this journey... It will be challenging! Take this sword!\n", Hero.Name);


            Character Monster = new Character("Cerberus", 300, new Sword(5,15));
            Console.WriteLine("Oh no, the hell hound {0}, is here! Dont get hit buy his claws or three heads!", Monster.Name);



            //Loop needed for battle sequence
            //bool loop = true;
            //Console.Clear();
            //do
            //{
            //    Console.SetCursorPosition(0, 0);
            //    Console.WriteLine(Hero.Weapon.CalcDamage() + " damage   ");
            //    switch (Console.ReadKey(true).Key)
            //    {
            //        case ConsoleKey.A:
            //            loop = false;
            //            break;

            //        case ConsoleKey.N:
            //            Console.WriteLine("\n" + Hero.Name);
            //            break;
            //    }
            //} while (loop);

        }
    }
}
