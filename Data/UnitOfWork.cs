using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public abstract class UnitOfWork
    {
        public DataContext DataContext { get; protected set; }
        public async void Save() => await DataContext.Save();
    }
}
