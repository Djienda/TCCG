using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCG.Models;

namespace TacticalCCG
{
    public class MapManager
    {
        public Map SelectedMap { get; private set; }

        private UnitOfWork data;
        private IMapManagerView view;
        
        public MapManager(UnitOfWork data, IMapManagerView view)
        {
            this.data = data;
            this.view = view;
        }

        public void Open()
        {
            view.SetMaps(data.DataContext.Set<Map>()); 
            view.Show();
        }

        public void Close()
        {
            view.Hide();
        }

        public void SelectMap(Map map)
        {
            SelectedMap = map;
        }

        public void OnLoadMap()
        {

        }
    }
}
