using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingT
{
    internal class Player
    {
        private Lazy<Inventory> inventory = new Lazy<Inventory>(() => new Inventory());

        public Inventory Inventory => inventory.Value; //Her oprettes inventory
    }
}
