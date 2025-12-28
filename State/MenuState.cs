using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class MenuState : IGameState
    {
        public void PressPause(Game game)
        {
            Console.WriteLine("Starting Game..");
            game.SetState(new PlayingState());
        }

        public void PressStart(Game game)
        {
            Console.WriteLine("¨Can't pause game in menu");
        }
    }
}
