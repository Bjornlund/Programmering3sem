using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //State: IState
    //ConcreteState: MenuState, PLayingState, PausedState
    //Context: Game

    internal class Game
    {
        private IGameState currentState;

        public Game() 
        {
            currentState = new MenuState();
        }

        public void SetState(IGameState state)
        {
            currentState = state;
        }

        public void PressStart()
        {
            currentState.PressStart(this);
        }
        public void PressPause()
        {
            currentState.PressPause(this);
        }
    }
}
