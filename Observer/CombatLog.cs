using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class CombatLog : IHealthObserver //Concrete observer
    {
        public void Update(int health)
        {
            Console.WriteLine($"Combat log: Player took an action, now health is {health}");
        }
    }
}
