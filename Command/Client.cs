using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Client Vælger command
//Opretter receiver, concretecommand, invoker - binder det sammen

namespace Command
{
    internal class Client
    {
        public void Run()
        {
            Receiver receiver = new Receiver();
            Printer printer = new Printer();
            FileManager fileManager = new FileManager();
            //ICommand command = new ConcreteCommand(receiver, "Hello command pattern");

            //Commands
            Dictionary<int, ICommand> menu = new Dictionary<int, ICommand>
            {
                {1, new PrintCommand(printer) },
                {2, new SaveCommand(fileManager) },
                {3, new OpenCommand(fileManager) }
            };

            Invoker invoker = new Invoker();

            while(true)
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Print");
                Console.WriteLine("2. Save");
                Console.WriteLine("3. Open");
                Console.WriteLine("0. Exit");
                Console.Write("Vælg: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                    break;

                if(menu.ContainsKey(choice))
                {
                    invoker.SetCommand(menu[choice]);
                    invoker.ExecuteCommand();
                }
                else
                {
                    Console.WriteLine("Ugyldigt valg"); 
                }
            }

         
        }
    }
}
