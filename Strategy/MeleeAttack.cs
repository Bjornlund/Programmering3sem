using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class MeleeAttack : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Player attacks with a sword!");
        }
    }
}
