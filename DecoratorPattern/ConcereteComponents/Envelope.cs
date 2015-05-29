using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;

namespace DecoratorPattern.ConcereteComponents
{
    public class Envelope : ItemToShip
    {
        public override string GetDescription()
        {
            return "Envelope"; 
        }

        public override double CalculateShippingCosts()
        {
            return 0.2; 
        }
    }
}
