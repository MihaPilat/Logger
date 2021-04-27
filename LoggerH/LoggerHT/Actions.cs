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
            logger.PrintLogg("Start method:FirstMethod", "Info");
            Result result = new Result();
            result.Status = true;
            return result;
        }

        public Result SecondMethod()
        {
            var logger = Logger.GetInstance();
            logger.PrintLogg("Start method:SecondMethod", "Warning");
            Result result = new Result();
            result.Status = true;
            return result;
        }

        public Result ThirdMethod()
        {
            Result result = new Result();
            result.Status = false;
            result.ErrorMessageProperty = "I broke a logic";
            return result;
        }
    }
}
