using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            // lets calculate the price of small , medium and large pizza 1 with cheese and other with peperoni. 

            Pizza small = new SmallPizza();
            Pizza medium = new MediumPizza();
            Pizza large = new LargePizza();


            // toppings 
            var cheeseToppingSmall = new ExtraCheese(small);

            var pepperoniSmall = new Peperoni(small);

            Console.WriteLine("Small pizza with extra cheese costs {0}" , cheeseToppingSmall.CalculatePrice());
            Console.WriteLine("Small pizza with pepperoni costs {0}", pepperoniSmall.CalculatePrice());

            Console.ReadLine(); 


        }
    }
}
