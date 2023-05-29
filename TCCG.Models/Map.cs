using Data;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace TCCG.Models
{
    [Serializable]
    public class Map : AEntity
    {
        public string Name { get; private set; }

        public Tile[] Tiles { get; private set; }

        public uint Length { get; private set; }
        public uint Height { get; private set; }

        public Map(uint id, string name, uint length, uint height)
        {
            Id = id;
            Name = name;
            Length = length;
            Height = height;
            Tiles = new Tile[length * height];
        }
    }
}
