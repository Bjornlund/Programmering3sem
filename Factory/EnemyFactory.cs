using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class EnemyFactory
    {
        public static IEnemy CreateEnemy(string type)
        {
            switch (type)
            {
                case "Archer":
                    return new Archer();
                case "Mage":
                    return new Mage();
                default:
                    throw new ArgumentException("Unknown enemy type");
            }
        }
    }
}
