using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TacticalCCG
{
    [Serializable]
    public class TurnPhase
    {
        public readonly string Name;
        public readonly List<ITurnPhaseEvent> Phases;
        public bool isOver { get; private set; } = false;

        public TurnPhase(string name, List<ITurnPhaseEvent> phases) 
        { 
            Name = name;
            Phases = phases;
        }

        public void StartPhase()
        {
            isOver = false;
            foreach (var turn in Phases)
            {
                turn.Trigger();
            }
            isOver = true;
        }

        public void EndPhase()
        {

        }
    }
}
