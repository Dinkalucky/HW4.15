using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task15._2;

namespace Task15._4
{
    internal class Program
    {
        static Program()
        {
            SynchronizationContext.SetSynchronizationContext(new MySynchronizationContext());
        }

        private static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            MethodAsync();
            Console.ReadKey();
        }

        private static async void MethodAsync()
        {
            await Task.Run(() => throw new AsyncVoidException("Error"));
            throw new AsyncVoidException("Error");
        }
    }
    internal class AsyncVoidException : Exception
    {
        public AsyncVoidException(string message)
            : base(message) { }
    }
}
