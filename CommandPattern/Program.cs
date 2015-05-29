using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // call the program with Site or Patient parameters 
            // this will result into a site or direct patient shipment generation. 

            var sm = new SupplyManager(); 
            sm.SendSupplies(args);
            Console.ReadLine(); 
        }
    }
}
