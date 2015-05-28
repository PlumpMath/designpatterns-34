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

        public void SendSupplies()
        {
            var orderMan = new OrderManager(); 

            // available commands 
            // lets create  a patient shipment directly to the patient. 
            var patientCommand = new PatientShipmentCommand(); 
            orderMan.CreateOrder(patientCommand);

        }

    }
}
