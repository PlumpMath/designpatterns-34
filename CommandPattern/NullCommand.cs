using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern
{
    class NullCommand : ICommand
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public void Order()
        {
            Console.WriteLine("Command not found ... ");
        }
    }
}
