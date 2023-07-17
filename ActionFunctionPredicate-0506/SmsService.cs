using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFunctionPredicate_0506
{
    internal class SmsService
    {
        public static void Send(string orderNumber)
        {
            Console.WriteLine("Send sms with order " + orderNumber);
        }
    }
}
