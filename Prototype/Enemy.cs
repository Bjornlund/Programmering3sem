using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Enemy : IEnemyPrototype
    {
        public string Type  { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public Enemy(string type, int health, int damage)
        {
            Type = type;
            Health = health;
            Damage = damage;
        }

        public IEnemyPrototype Clone()
        {
            return new Enemy(Type, Health, Damage); //Shallow copy, refererer til samme værdi som original object
        }

        public void Print()
        {
            Console.WriteLine($"{Type} | HP: {Health} | DMG: {Damage}");
        }
    }
}
