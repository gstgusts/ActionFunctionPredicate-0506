using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFunctionPredicate_0506
{
    internal class EmailService
    {
        public static void Send(string orderNumber)
        {
            Console.WriteLine("Send email with order " + orderNumber);
        }
    }
}
