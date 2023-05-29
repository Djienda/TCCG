using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCG.Models
{
    public class GameData : UnitOfWork
    {
        MapRepository mapRepository;

        public MapRepository MapRepository => mapRepository;

        public GameData(DataContext dataContext)
        {
            DataContext = dataContext;
                       
            mapRepository = new MapRepository(dataContext);
        }
    }
}
