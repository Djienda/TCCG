using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class DataContext
    {
        public DataHolder Database { get; protected set; }

        public abstract Task Load();

        public abstract Task Save();

        public List<T> Set<T>()
        {
            return Database.db[typeof(T)] as List<T>;
        }
    }
}
