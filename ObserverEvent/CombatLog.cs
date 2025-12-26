using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ObserverEvent
{
    internal class CombatLog //observer
    {
        public void LogHealth(int health)
        {
            Console.WriteLine($"Log: Player health is now {health}");
        }

        public void LevelUp(int level)
        {
           
            Console.WriteLine($"Player Level = {level}");
        }
    }
}
