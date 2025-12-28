using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{

    internal class Player
    {
        private IAttackStrategy attackStrategy;

        public Player(IAttackStrategy strategy)
        {
            attackStrategy = strategy;
        }

        public void SetStrategy(IAttackStrategy strategy)
        {
            attackStrategy = strategy;
        }

        //Player ved ikke hvordan der angrubes, blot at der angribes
        public void Attack()
        {
            attackStrategy.Attack();
        }
    }
}
