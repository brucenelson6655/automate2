using System;

namespace automate2
{
    public class HelloWorld
    {
        public static string Start()
        {
            return "Hello World at " + DateTime.Now.ToString();
        }

        public static string SayHello(String whoisit )
        {
            return "Howdy " + whoisit.ToString();
        }
        public static string Stop()
        {
            return "all done";
        }

        public static string All()
        {
            String foo = Start();
            String bar = Stop();
            return $"finished Start: {foo} Stop : {bar}";
        }
    }
}
