using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18PatternsAndAntipatterns
{
    abstract class Command
    {
        public abstract Task Run();
        public abstract void Cancel();
    }
}
