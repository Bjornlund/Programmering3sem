using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    //Character kan ikke oprettes direkte
    //Builder styrer hele opbygningen
    //Metoder kan kædes(fluent builder interface)

    internal class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public string Weapon { get; set; }

        public bool HasMagic { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Name} | HP:{Health} | Armor:{Armor} | Weapon:{Weapon} | Magic:{HasMagic}");
        }

        //Kun builder må oprette objektet
        private Character() { }

        //builder har adgang
            internal class Builder
        {
            private readonly Character character = new Character();

            public Builder SetName(string name)
            {
                character.Name = name;
                return this;
            }

            public Builder SetHealth(int health)
            {
                character.Health = health;
                return this;
            }

            public Builder SetArmor(int armor)
            {
                character.Armor = armor;
                return this;
            }

            public Builder SetWeapon(string weapon)
            {
                character.Weapon = weapon;
                return this;
            }

            public Builder EnableMagic()
            {
                character.HasMagic = true;
                return this;
            }

            public Character Build()
            {
                return character;
            }
        }
    }
}
