using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerHT
{
    public class Actions
    {
        public Result FirstMethod()
        {
            var logger = Logger.GetInstance();
            logger.PrintLogg("Start method:FirstMethod", LogType.Info);
            return new Result { Status = true };
        }

        public Result SecondMethod()
        {
            var logger = Logger.GetInstance();
            logger.PrintLogg("Start method:SecondMethod", LogType.Warning);
            return new Result { Status = true };
        }

        public Result ThirdMethod()
        {
            return new Result { Status = false, ErrorMessage = "I broke a logic" };
        }
    }
}
