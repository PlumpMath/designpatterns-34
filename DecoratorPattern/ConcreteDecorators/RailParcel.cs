using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorators
{
    class RailParcel : ShipmentItemDecorator
    {
        public RailParcel(ItemToShip item) : base(item)
        {

        }

        public override string GetDescription()
        {
            return "Rail freight " + _item.GetDescription(); 
        }

        public override double CalculateShippingCosts()
        {
            return base.CalculateShippingCosts() + 10; 
        }
    }
}
