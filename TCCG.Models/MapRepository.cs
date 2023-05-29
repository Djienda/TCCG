using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCG.Models
{
    public class MapRepository : Repository<Map>
    {
        public MapRepository(DataContext context) 
        {
            _context = context;
        }

        public override void Update(Map entity)
        {
            throw new NotImplementedException();
        }
    }
}
