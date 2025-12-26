using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Selve arbejdet der kaldes

namespace Command
{
    internal class Receiver
    {
        public void Action(string parameter)
        {
            Console.WriteLine($"Receiver udfører action med {parameter}");
        }
    }
}
