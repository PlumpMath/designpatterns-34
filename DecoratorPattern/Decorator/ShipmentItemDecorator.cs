using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;

namespace DecoratorPattern.Decorator
{
   public class ShipmentItemDecorator : ItemToShip
   {
       protected ItemToShip _item;

       public ShipmentItemDecorator(ItemToShip item)
       {
           _item = item;
       }

       public override string GetDescription()
       {
           return _item.Description; 
       }

       public override double CalculateShippingCosts()
       {

           return _item.CalculateShippingCosts(); 
       }
    }
}
