using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class History
    {
        private List<IUndoableCommand> _commands = new List<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            _commands.Add(command);
        }

        public IUndoableCommand Pop()
        {
            var last = _commands.Last();
            _commands.Remove(last);
            return last;
        }

        //checking if there is anything stored
        public int Size()
        { 
            return _commands.Count; 
        }
    }
}
