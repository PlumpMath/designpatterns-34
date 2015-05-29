using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcereteComponents
{
    public class MediumParcel : ItemToShip
    {
        public override string GetDescription()
        {
            return "Medium parcel up to 10kg"; 
        }

        public override double CalculateShippingCosts()
        {

            return 22.50; 
        }
    }
}
