namespace ActionFunctionPredicate_0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action<string> log = new Action<string>(LogInfo);
            //Action<string> log1 = LogInfo;
            //log.Invoke("Hi ALL");
            //log1("aaaaaaa");
            //Console.ReadLine();

            //Action<int> printValue = delegate (int val)
            //{
            //    Console.WriteLine(val);
            //};

            //printValue(1);

            //Action<int> printValue2 = (i) => {
            //    Console.WriteLine(i);
            //};

            //printValue2(1);



            //Func<string, string> func1 = new Func<string, string>(LogInfoAsFunc);

            //func1.Invoke("test");

            //Predicate<string> pred1 = new Predicate<string>(Match);



            //var randomTestObject = new RandomTestClass();

            //randomTestObject.DoSomething = delegate (int val)
            //{
            //    Console.WriteLine(val);
            //};

            //var examplePredicate = delegate (RandomTestClass randomTestClass)
            //{
            //    return randomTestClass.Name == "Gusts";
            //};

            //var list = new List<RandomTestClass> { randomTestObject };

            //var result = list.Where(a => examplePredicate(a));

            //randomTestObject.CallMethod();


            var order = new Order();

            order.AfterCreateActions = new List<Action<string>> { 
                EmailService.Send,
                SmsService.Send,
            };

            order.Create();

            var order1 = new Order();

            order1.AfterCreateActions = new List<Action<string>> {
                EmailService.Send
            };

            order1.Create();
        }

        //static void LogInfo(string message)
        //{
        //    Console.WriteLine(message);
        //}

        //static string LogInfoAsFunc(string message)
        //{
        //    return message;
        //}

        //static bool Match(string message)
        //{
        //    return message == string.Empty;
        //}
    }
}