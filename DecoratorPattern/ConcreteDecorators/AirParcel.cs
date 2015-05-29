using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorators
{
   public class AirParcel : ShipmentItemDecorator
    {
       public AirParcel(ItemToShip item) : base(item)
       {

       }

       public override string GetDescription()
       {
           return  "Airfreight " + _item.GetDescription(); 
       }

       public override double CalculateShippingCosts()
       {
           return 50.00 +_item.CalculateShippingCosts(); 
       }
    }
}
