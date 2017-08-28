using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{

    [Flags]
    public enum CellState : ushort
    {
        Empty = 0x0000,
        X = 0x0001,
        O = 0x0002
    }

    public abstract class Cell
    {
        public Cell()
        {

        }
        public Cell(Position pos)
        {
            _pos = new Position(pos.X, pos.Y);
        }

        #region Properties

        public int X
        {
            get
            {
                return _pos.X;
            }
        }

        public int Y
        {
            get
            {
                return _pos.Y;
            }
        }

        public abstract CellState State { get; }

        #endregion

        #region Protected


        protected Position _pos;


        #endregion
    }
}
