using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class OpenCommand : ICommand
    {
        private readonly FileManager fileManager;

        public OpenCommand(FileManager fileManager)
        { 
            this.fileManager = fileManager; 
        }

        public void Execute()
        {
            fileManager.Open();
        }
    }
}
