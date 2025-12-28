using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoadingT
{
    internal class Inventory
    {
        public Inventory() 
        {
            Console.WriteLine("Inventory oprettet");
        }

        public void Show()
        {
            Console.WriteLine("Inventory vises");
        }
    }
}
