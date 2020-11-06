using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characterLibrary
{
    public class Sword
    {
        private int _maxDamage;
        private int _minDamage;

        public int _damage { get; set; }

        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = _minDamage < _maxDamage ? value : _maxDamage - 1;  }
        }

        public Sword(int minDamage, int maxDamage)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

       public int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(MinDamage, MaxDamage + 1);
            return damage;
        }
    }
}
