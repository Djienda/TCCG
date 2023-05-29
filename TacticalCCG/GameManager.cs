using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCG.Models;

namespace TacticalCCG
{
    public class GameManager
    {
        public uint TurnNumber { get; private set; } = 0;

        public List<Player> Players { get; protected set; }

        public readonly Map Map;

        IMapView _view;

        public GameManager(Map map, List<Player> players, IMapView view)
        {
            Map = map;
            Players = players;
            _view = view;
        }

        public void Open()
        {
            _view.SetMap(Map);
            _view.Show();

            foreach(var player in Players)
            {
                player.Open();
            }
        }

        public void Close()
        {
            _view.Hide();
        }
    }
}
