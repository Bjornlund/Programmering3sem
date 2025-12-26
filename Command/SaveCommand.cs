using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class SaveCommand : ICommand
    {
        private readonly FileManager fileManager;

        public SaveCommand(FileManager fileManager)
        {
            this.fileManager = fileManager;
        }

        public void Execute()
        {
            fileManager.Save();
        }

    }
}
