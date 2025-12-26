using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverEvent
{
    internal class SoundSystem //observer
    {
        public void PlayHealthSound(int health) 
        {
            Console.WriteLine("Sound: Player health changed");
        }
    }
}
