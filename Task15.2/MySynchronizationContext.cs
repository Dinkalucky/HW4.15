using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task15._2
{
    internal class MySynchronizationContext:SynchronizationContext
    {
        public override void Post(SendOrPostCallback d, object state)
        {
            new Thread(_ => base.Post(d,state)){Name = "MyPostMethod" }.Start();
        }
    }
}
