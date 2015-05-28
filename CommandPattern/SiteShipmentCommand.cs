using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class SiteShipmentCommand : ICommand
    {
        public void Order()
        {
            //dummy implementation 
            Console.WriteLine("Site shipment dispatched");
        }
    }
}
