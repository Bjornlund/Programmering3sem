using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    //State bestemmer hvad der sker og næste state
    internal interface IGameState
    {
        void PressStart(Game game);
        void PressPause(Game game);
    }
}
