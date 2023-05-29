using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalCCG
{
    public class TurnManager
    {
        GameManager _gameManager;
        List<TurnPhase> _turnPhaseList;

        public TurnManager(GameManager gameManager, List<TurnPhase> turnPhaseList)
        {
            _gameManager = gameManager;
            _turnPhaseList = turnPhaseList;
        }

        public void EndTurn()
        {

        }
    }
}
