using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TacticalCCG
{
    public abstract class GameApplication
    {
        public readonly SynchronizationContext UiContext;
        public readonly UnitOfWork DataHandler;
        public MapManager MapManager;

        public GameApplication(SynchronizationContext uiContext, UnitOfWork dataHandler) 
        { 
            UiContext = uiContext;
            DataHandler = dataHandler;
        }

        public virtual async void Start(IMapManagerView view)
        {
            await DataHandler.DataContext.Load();
            MapManager = new MapManager(DataHandler, view);
            MapManager.Open();
        }
    }
}
