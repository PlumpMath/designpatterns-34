using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
   public class Target
    {

       public virtual void Request()
       {
           Console.WriteLine("Target system request called");
       }
    }


    public class Adapter : Target
    {
        private LegacySystem legacySystem = new LegacySystem();
        public override void Request()
        {
            Console.WriteLine("Did some data manipulation to match the legacy system");

            legacySystem.SpecificRequest();
            //base.Request();
        }
    }
}
