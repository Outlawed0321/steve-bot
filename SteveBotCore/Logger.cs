using System;
using System.Collections.Generic;
using System.Text;

namespace SteveBotCore
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
