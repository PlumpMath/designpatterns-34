using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class SiteShipmentCommand : ICommand
    {
        public string Name
        {
            get { return "Site";  }
        }

        public string Description
        {
            get { return "Sends shipments directly to the study site for distribution to individual patients";  }

        }

        public void Order()
        {
            //dummy implementation 
            Console.WriteLine("Site shipment dispatched");
        }
    }
}
