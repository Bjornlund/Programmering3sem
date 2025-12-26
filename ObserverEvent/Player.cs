using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverEvent
{
    internal class Player //Subject/publisher, ejer event "HealthChanged"
    {
        private int health = 100;
        private int level = 3;

        //Observer event
        public event Action<int> HealthChanged;
        public event Action<int> LevelChanged;


        

        public void TakeDamage(int damage)
        {
            health -= damage;

            if (health < 0)
                health = 0;

            NotifyHealthChanged();
        }
         
        public void Heal(int amount)
        {
            health += amount;
            NotifyHealthChanged();
        }

        public void LevelUp(int xp)
        {
            if (xp > 10)
                level++;
            NotifyLevelChanged();
        }

        private void NotifyHealthChanged()
        {
            HealthChanged?.Invoke(health);
        }

        private void NotifyLevelChanged()
        {
            LevelChanged?.Invoke(level);
        }
    }
}
