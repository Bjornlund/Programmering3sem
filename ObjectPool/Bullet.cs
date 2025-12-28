using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    internal class Bullet
    {
        public bool IsActive {  get; private set; }

        public void Fire()
        {
            IsActive = true;
            Console.WriteLine("Bullet fired");
        }

        public void Reset()
        {
            IsActive = false;
            Console.WriteLine("bullet returned to pool");
        }
    }
}
