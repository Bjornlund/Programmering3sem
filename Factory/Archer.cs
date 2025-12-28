using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Archer : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Archer shoots an arrow!");
        }
    }
}
