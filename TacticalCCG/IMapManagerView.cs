using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCCG.Models;

namespace TacticalCCG
{
    public interface IMapManagerView
    {
        void Show();

        void Hide();

        void SetMaps(List<Map> maps);
    }
}
