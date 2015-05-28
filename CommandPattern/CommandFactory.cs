using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class CommandFactory : ICommandFactory
    {
        public  IEnumerable<ICommand> GetAvailableCommands()
        {
            var commandList = new List<ICommand>
            {
                new PatientShipmentCommand(),
                new SiteShipmentCommand()
            };
            return commandList; 
        }

        public ICommand MakeCommand(string request)
        {
           var command = GetAvailableCommands().First(c => c.Name == request);
            return command ?? new NullCommand(); // returns a found command or a null object (null object pattern) 
        }
        
    }
}
