using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{

    /// <summary>
    /// This is the client, it invokes the Order manager passing it the rigth command to execute. 
    /// </summary>
    class SupplyManager
    {

        public void SendSupplies(string [] args)
        {
            var orderMan = new OrderManager(); 

            // available commands 
            // lets create  a patient shipment directly to the patient. 
            var factory = new CommandFactory(); 

            var commands = factory.GetAvailableCommands();
            
            if (args.Length == 0)
            {
                DisplayUsage(commands);
                // stop execution we cant do anything without the arguments. 
                return; 
            }

            var parser = new CommandParser();
            var command = parser.GetCommand(args); 

            orderMan.CreateOrder(command);

        }

        public void DisplayUsage(IEnumerable<ICommand> availableCommands)
        {
            Console.WriteLine("Command not found -------");
            Console.WriteLine("List of available commands");

            foreach (var command in availableCommands)
            {
                Console.WriteLine(" {0} ", command.Description);
            }

           

        }

    }
}
