using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
   public  class LegacySystem
    {

       public void SpecificRequest()
       {
           Console.WriteLine("Called a method on the legacy api");
       }
    }
}
