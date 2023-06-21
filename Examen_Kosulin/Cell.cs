using System.Collections.Generic;
using System.Linq;

namespace LifeModel
{
    public class Cell
    {
        public bool IsAlive;
        private bool IsAliveNext;

        public readonly List<Cell> neighbors = new List<Cell>();

        public void DetermineNextLiveState()
        {

            int liveNeighbors = neighbors.Where(x => x.IsAlive).Count();

            if (IsAlive)
            {
                IsAliveNext = liveNeighbors == 2 || liveNeighbors == 3;
            }
            else
            {
                IsAliveNext = liveNeighbors == 3;
            }
        }

        public void Advance()
        {
            IsAlive = IsAliveNext;
        }
    }
}
