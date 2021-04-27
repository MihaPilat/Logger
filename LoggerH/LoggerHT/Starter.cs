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
            Result result = new Result();
            for (int i = 0; i < 100; i++)
            {
                random = new Random().Next(0, 3);
                if (random == 0)
                {
                    result = actions.FirstMethod();
                }
                else if (random == 1)
                {
                    result = actions.SecondMethod();
                }
                else
                {
                    result = actions.ThirdMethod();
                }

                if (result.Status == false)
                {
                    var logger = Logger.GetInstance();
                    logger.PrintLogg("Action failed by a reason:" + result.ErrorMessageProperty, "Error");
                }
            }

            var logg = Logger.GetInstance();
            File.WriteAllText("log.txt", logg.Data);
        }
    }
}
