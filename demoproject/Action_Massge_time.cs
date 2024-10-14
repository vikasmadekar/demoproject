using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    internal class Action_Massge_time
    {
        static void PrintMessage(Action<string> action, string message)
        {
            action(message);
        }
        static void LogError(Action<string> logAction, string message)
        {
            string timestampedMessage = $"[{DateTime.Now}] ERROR: {message}";
            logAction(timestampedMessage);
        }
        static void Main(string[] args)
        {
            Action<string> printAction = msg => Console.WriteLine(msg);
            Console.WriteLine("Enter a message to print:");
            string userMessage = Console.ReadLine();
            PrintMessage(printAction, userMessage);


            Action<string> consoleLogger = msg => Console.WriteLine(msg);

            Console.WriteLine("Enter an error message to log:");
            string errorMessage = Console.ReadLine();

            LogError(consoleLogger, errorMessage);

        }
    }

}
    

