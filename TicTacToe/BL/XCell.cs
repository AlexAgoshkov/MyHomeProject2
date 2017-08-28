using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class XCell : Cell
    {
        public XCell()
        {

        }

        public XCell(Position pos)
            : base(pos)
        {
            _pos = new Position(pos.X, pos.Y);
        }

        public override CellState State
        {
            get
            {
                return CellState.X;
            }
        }
    }
}
