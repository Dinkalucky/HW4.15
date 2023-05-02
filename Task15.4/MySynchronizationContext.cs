using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task15._2
{
    internal class MySynchronizationContext:SynchronizationContext
    {
        public override void OperationCompleted()
        {
            Console.WriteLine($"Finish");
        }

        public override void OperationStarted()
        {
            Console.WriteLine($"Start");
        }

        public override void Post(SendOrPostCallback d, object state)
        {
            try
            {
                d.Invoke(state);
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e.GetType());
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
    }
}
