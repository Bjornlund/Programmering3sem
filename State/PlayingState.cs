using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class PlayingState : IGameState
    {
        public void PressPause(Game game)
        {
            Console.WriteLine("Game is already playing");
        }

        public void PressStart(Game game)
        {
            Console.WriteLine("Game Paused");
            game.SetState(new PausedState());
        }
    }
}
