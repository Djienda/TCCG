using System;

namespace TCCG.Models
{
    [Serializable]
    public class TerrainType
    {
        public readonly string Id;
        public readonly uint MovementCost;
        public readonly string Name;

        public TerrainType(string id, uint movementCost, string name)
        {
            Id = id;
            MovementCost = movementCost;
            Name = name;
        }
    }
}
