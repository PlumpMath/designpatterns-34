using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class PatientShipmentCommand : ICommand
    {
        public void Order()
        {

            Console.WriteLine("Patient shipment dispatched ... directly to the patient");
        }
    }
}
