using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class MyPosEventArgs : EventArgs
    {
        public MyPosEventArgs(int x, int y)
        {
            _x = x;
            _y = y;

        }

        #region Properties

        public int X
        {
            set
            {
                _x = value;
            }
            get
            {
                return _x;
            }
        }

        public int Y
        {
            set
            {
                _y = value;
            }
            get
            {
                return _y;
            }
        }

        #endregion

        #region Private

        private int _x = 0;
        private int _y = 0;

        #endregion
    }
}
