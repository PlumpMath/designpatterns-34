using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcereteComponents
{
   public  class SmallParcel : ItemToShip
    {
        public override string GetDescription()
        {
            return "Small parcel up to 1kg"; 
        }

        public override double CalculateShippingCosts()
        {
            return 3.5; 
        }
    }
}
