using TCCG.Models;

namespace TacticalCCG
{
    public interface IMapView
    {
        void Show();

        void Hide();

        void SetMap(Map map);
    }
}