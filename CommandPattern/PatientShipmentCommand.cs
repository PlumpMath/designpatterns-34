using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class PatientShipmentCommand : ICommand
    {
        public string Name
        {
            get { return "Patient"; }
        }

        public string Description
        {
            get { return "Sends shipments directly to the patient";  }
        }

        public void Order()
        {

            Console.WriteLine("Sending medication ....");
            Console.WriteLine("Patient shipment dispatched ... directly to the patient");
        }
    }
}
