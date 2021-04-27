using System;

namespace LoggerHT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Starter newStarter = new Starter();
            newStarter.Run();
            Console.WriteLine(DateTime.Now);
        }
    }
}
