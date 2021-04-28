using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LoggerHT
{
    public class Starter
    {
        public void Run()
        {
            int random;
            Actions actions = new Actions();
            Result result = null;
            for (int i = 0; i < 100; i++)
            {
                random = new Random().Next(0, 3);
                switch (random)
                {
                    case 0:
                        result = actions.FirstMethod();
                        break;
                    case 1:
                        result = actions.SecondMethod();
                        break;
                    case 2:
                        result = actions.ThirdMethod();
                        break;
                }

                if (result.Status == false)
                {
                    var logger = Logger.GetInstance();
                    logger.PrintLogg("Action failed by a reason:" + result.ErrorMessage, LogType.Error);
                }
            }

            var log = Logger.GetInstance();
            File.WriteAllText("log.txt", log.ReturnAllLogs());
        }
    }
}
