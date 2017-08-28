using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class OCell : Cell
    {
        public OCell()
        {

        }
        public OCell(Position pos)
            : base(pos)
        {
            _pos = new Position(pos.X, pos.Y);
        }

        public override CellState State
        {
            get
            {
                return CellState.O;
            }
        }
    }
}
