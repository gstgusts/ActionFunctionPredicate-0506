using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionFunctionPredicate_0506
{
    public class RandomTestClass
    {
        public Action<int> DoSomething { get; set; }

        public Predicate<RandomTestClass> IsMatch { get; set; }

        public string Name { get; set; }
        public void CallMethod()
        {
            if(DoSomething != null)
            {
                DoSomething(43);
            }
        }
    }
}
