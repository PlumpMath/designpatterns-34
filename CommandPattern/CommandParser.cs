using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class CommandParser
    {
        internal ICommand GetCommand(string[] args)
        {
           // command will be the first argument 
            var userRequest = args.First();
            
            var factory = new CommandFactory(); // normally this should be injected but you get the point

            var command = factory.MakeCommand(userRequest);

            return command; 
        }
    }
}
