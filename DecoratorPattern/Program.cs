using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.ConcereteComponents;
using DecoratorPattern.ConcreteDecorators;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var p = new LargeParcel();
            var sendByAir = new AirParcel(p);
            var sendByTrain = new RailParcel(p); 



            Console.WriteLine(String.Format("{0} costs Eur: {1} to ship", sendByAir.GetDescription(), sendByAir.CalculateShippingCosts()));
            Console.WriteLine(String.Format("{0} costs Eur: {1} to ship", sendByTrain.GetDescription(), sendByTrain.CalculateShippingCosts()));

            Console.ReadLine(); 
        }
    }
}
