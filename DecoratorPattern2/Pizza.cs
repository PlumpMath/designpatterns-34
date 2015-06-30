using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern2
{

    /// <summary>
    /// Object being decorated. 
    /// </summary>
    public abstract class Pizza
    {

        public abstract decimal CalculatePrice(); 
    }


    /// <summary>
    ///  Example of a decorator
    /// </summary>
    public abstract class Topping : Pizza
    {
        private readonly Pizza _pizza;

        protected Topping(Pizza pizza)
        {
            _pizza = pizza;
        }
        
    }

    public class ExtraCheese : Topping
    {
        private readonly Pizza _pizza;

        public ExtraCheese(Pizza pizza) : base(pizza)
        {
            _pizza = pizza;
        }

        public override decimal CalculatePrice()
        {
            return 2 + _pizza.CalculatePrice(); 
        }
    }

    public class Peperoni: Topping
    {
        private readonly Pizza _pizza;

        public Peperoni(Pizza pizza) : base(pizza)
        {
            _pizza = pizza;
        }


        public override decimal CalculatePrice()
        {
            return 3 + _pizza.CalculatePrice(); 
        }
    }


    public class LargePizza: Pizza
    {
        public override decimal CalculatePrice()
        {
            return 5; 
        }
    }

    public class SmallPizza: Pizza
    {
        public override decimal CalculatePrice()
        {
            return 3; 
        }
    }

    public class MediumPizza: Pizza
    {
        public override decimal CalculatePrice()
        {
            return 4; 
        }
    }
}
