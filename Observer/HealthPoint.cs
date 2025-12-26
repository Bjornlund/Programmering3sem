using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class HealthPoint : IHealthObserver //Concrete observer
    {
        public void Update(int health)
        {
            Console.WriteLine($"HUD: Player health = {health}");
        }
    }
}
