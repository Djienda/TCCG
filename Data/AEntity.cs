using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class AEntity
    {
        public uint Id { get; protected set; }
    }
}
