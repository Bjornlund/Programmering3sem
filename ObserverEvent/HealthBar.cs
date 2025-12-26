using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverEvent
{
    internal class HealthBar //HUD, observer
    {
        public void Update(int health)
        {
            Console.WriteLine($"HUD: Health = {health}");
        }
    }
}
