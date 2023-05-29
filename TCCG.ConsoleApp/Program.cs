using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TCCG.Models;

namespace TCCG.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataPath = "";
            ConsoleApplication app = new ConsoleApplication(new SynchronizationContext(), new JsonContext(dataPath));
        }
    }
}
