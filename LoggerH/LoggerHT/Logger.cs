using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerHT
{
    public class Logger
    {
        private static Logger instance;
        private Logger()
        {
        }

        public string Data { get; set; }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }

            return instance;
        }

        public void PrintLogg(string message, string logtype)
        {
            string logg = "{" + DateTime.Now + "} {" + message + "} {" + logtype + "}" + "\n";
            if (logtype == "Info")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (logtype == "Warning")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.Write(logg);
            Console.ForegroundColor = ConsoleColor.White;
            Data = Data + logg;
        }
    }
}