using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TacticalCCG;

namespace TCCG.ConsoleApp
{
    public class ConsoleApplication : GameApplication
    {
        public ConsoleApplication(SynchronizationContext uiContext, UnitOfWork dataHandler) : base(uiContext, dataHandler)
        {

        }
    }
}
