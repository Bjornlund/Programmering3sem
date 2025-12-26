using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Player //Subject
    {
        private List<IHealthObserver> observers = new List<IHealthObserver>();
        private int health = 100;

        public void Attach(IHealthObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IHealthObserver observer)
        { 
            observers.Remove(observer); 
        }

        public void TakeDamage(int damage)
        {
            health -= damage;
            Notify();
        }

        public void Heal(int heal)
        {
            health += heal;
            Notify();
        }

        private void Notify()
        {
            foreach (IHealthObserver observer in observers)
            {
                observer.Update(health);
            }
        }



    }
}
