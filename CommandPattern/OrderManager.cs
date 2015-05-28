using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class OrderManager
    {

        public void CreateOrder(ICommand cmd)
        {
            cmd.Order();
        }
    }
}
