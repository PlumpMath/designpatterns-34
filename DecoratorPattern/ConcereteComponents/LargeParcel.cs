using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcereteComponents
{
    public class LargeParcel : ItemToShip
    {
        public override string GetDescription()
        {

            return "Large parcel up to 20kg"; 
        }

        public override double CalculateShippingCosts()
        {
            return 40.0; 
        }
    }
}
