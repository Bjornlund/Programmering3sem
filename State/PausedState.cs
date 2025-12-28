using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class PausedState : IGameState
    {
        public void PressPause(Game game)
        {
            Console.WriteLine("Resuming game");
            game.SetState(new PlayingState());
        }

        public void PressStart(Game game)
        {
            Console.WriteLine("Game is already paused");
        }
    }
}
