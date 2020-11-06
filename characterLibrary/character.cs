using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characterLibrary
{
    public class Character
    {
        //Fields
        //Monster and hero health
        private int _health;

        //Properties
        public int MaxHealth { get; set; }

        public int Health {
            get { return _health; }
            set { _health = value <= MaxHealth ? value : MaxHealth; }
        }

        //Monster and Hero name
        public string Name { get; set; }

        //Monster and Hero attack and block
        public Sword Weapon { get; set; } //Todo create sword class
                                          /* public Shield Shield { get; set; }*/ //Todo create shield class


        //CTORS
        public Character()
        {

        }

        public Character(string name, int maxHealth, Sword weapon)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
            Weapon = weapon;
        }

        public static Character GetMonster(int selector)
        {
            Character monster;
            string[] names = new string[]
            {
                "Cerberus",
                "The Harpies",
                "Demons",
                "Satan"
            };

            Sword weapon = new Sword(selector + 1, selector + 5);
            monster = new Character(names[selector], 300 + (selector * 50), weapon);
            return monster;
        }

    }




}
