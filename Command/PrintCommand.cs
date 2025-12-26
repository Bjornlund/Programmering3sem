using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Handling

namespace Command
{
    internal class PrintCommand : ICommand
    {
        private readonly Printer printer;

        public PrintCommand(Printer printer)
        {
            this.printer = printer;
        }

        public void Execute()
        {
            printer.Print();
        }
    }
}
