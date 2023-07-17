using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFunctionPredicate_0506
{
    public class Order
    {
        public List<Action<string>> AfterCreateActions { get; set; } = new List<Action<string>>();

        public int OrderNumber { get; set; }
        public void Create()
        {
            Console.WriteLine("Order created");

            if (!AfterCreateActions.Any())
            {
                return;
            }

            foreach(var action in AfterCreateActions)
            {
                action(OrderNumber.ToString());
            }
        }
    }
}
