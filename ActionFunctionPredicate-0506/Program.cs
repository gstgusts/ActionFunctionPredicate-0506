namespace ActionFunctionPredicate_0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> log = new Action<string>(LogInfo);
            log.Invoke("Hi ALL");
            Console.ReadLine();

        }

        static void LogInfo(string message)
        {
            Console.WriteLine(message);
        }
    }
}