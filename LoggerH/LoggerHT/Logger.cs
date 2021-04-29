using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerHT
{
    public class Logger
    {
        private static Logger _instance;
        private static StringBuilder _data = new StringBuilder();
        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Logger();
            }

            return _instance;
        }

        public void PrintLogg(string message, LogType logType)
        {
            string log = $"{{{DateTime.UtcNow}}} {{{message}}} {{{logType}}}";
            switch (logType)
            {
                case LogType.Info:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case LogType.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case LogType.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            _data.AppendLine(log);
            Console.WriteLine(log);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public string ReturnAllLogs()
        {
            return _data.ToString();
        }
    }
}