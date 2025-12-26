using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Invoker udløser handlingen, ved hvornår noget skal ske, ikke hvad der skal ske
//Kunne være en knap, ecenthandler, scheduler

namespace Command
{
    internal class Invoker
    {
        private ICommand command;

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
