using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class TestClass
    {
       
            private int health;
            public int Health
            {
                get { return health; }
                set
                {
                    if (value > 0 && value <= 100)
                    { health = value; }
                }
            }
        
    }

    public abstract class Animal
    {

        public Animal()
        {
        }


        public abstract void Eat();
       
    }

    public class Parrot : Animal
    {
        public Parrot()
        {
        }

        public override void Eat() 
        {
             Console.WriteLine("squawk"); 

        }

        //public override void Eat()
        //{ Console.WriteLine("squawk"); }
    }
}

