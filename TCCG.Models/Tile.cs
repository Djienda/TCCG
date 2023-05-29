using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCCG.Models
{
    [Serializable]
    public class Tile
    {
        public readonly TerrainType Type;
        public List<TerrainFeature> Features { get; private set; }

        public Tile(TerrainType type, List<TerrainFeature> features)
        {
            Type = type;
            Features = features ?? new List<TerrainFeature>();
        }
    }
}
