using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Handling
//Binder data(parameter) og receiver

namespace Command
{
    internal class ConcreteCommand : ICommand
    {
        private readonly Receiver receiver;
        private readonly string parameter;

        public ConcreteCommand(Receiver receiver, string parameter)
        {
            this.receiver = receiver;
            this.parameter =parameter;
        }

        public void Execute()
        {
            receiver.Action(parameter);
        }

        
    }
}
