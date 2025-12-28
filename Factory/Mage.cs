using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Mage : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Mage casts a spell!");
        }
    }
}
