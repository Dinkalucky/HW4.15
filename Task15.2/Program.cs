using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task15._2
{
    internal class Program
    {
        
        static async Task Main(string[] args)
        {
            SynchronizationContext.SetSynchronizationContext(new MySynchronizationContext());
            Console.OutputEncoding = Encoding.UTF8;
            Task.Run(() => MyAsyncMethod());
            Console.ReadLine();
        }

        private static async Task MyAsyncMethod()
        {
            Console.WriteLine($"Id потока: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Ім'я потока: {Thread.CurrentThread.Name}");
            Console.WriteLine($"Пул потока: {Thread.CurrentThread.IsThreadPoolThread}");
            var task = new Task(MyMethod);
            task.Start();
            await task;
            Console.WriteLine($"Id потока: {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Ім'я потока: {Thread.CurrentThread.Name}");
            Console.WriteLine($"Пул потока: {Thread.CurrentThread.IsThreadPoolThread}");
        }

        public static void MyMethod()
        {
            int i = 1, factorial=1;
            while (i!=10)
            {
                factorial *= i;
                i++;
            }
            
            Console.WriteLine("Factorial = " + factorial);
            
        }
    }
}
