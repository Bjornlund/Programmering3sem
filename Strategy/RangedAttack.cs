using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class RangedAttack : IAttackStrategy
    {
        public void Attack()
        {
            Console.WriteLine("Player shoots with a bow and arrow!");
        }
    }
}
