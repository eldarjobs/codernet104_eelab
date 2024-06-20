namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        } 
        public class Ilogger
        {
            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }
        public class Iloggerlog : Ilogger
        {
            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
