using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Field
    {
        public Field(int heigth, int wigth)
        {
            _heigth = heigth; // высота
            _wigth = wigth; // ширина

            _cells = new Cell[heigth, wigth]; // массив ячеек

        }

        public bool IsMoveCursore(int dx, int dy)
        {
            bool retValue = false;

            _posX += dx;
            _posY += dy;

            //Проверка на граничные условия

            if (_posX > _cells.GetLength(1) - 1)
            {
                _posX = 0;
            }

            if (_posY > _cells.GetLength(0) - 1)
            {
                _posY = 0;
            }

            if (_posX < 0)
            {
                _posX = _cells.GetLength(1) - 1;
            }

            if (_posY < 0)
            {
                _posY = _cells.GetLength(0) - 1;
            }


            retValue = true;

            return retValue;
        }

        #region CheckWin

        #region Horizontal

        public int GetHorizontalWinX(object sender, MyPosEventArgs args)
        {
            int win = 0;

            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                if (_cells[i, args.Y] is XCell)
                {
                    win = 1;
                }
                else
                {
                    win = 0;
                    break;
                }

            }
            _horzWinX = win;
            return win;

        }

        public int GetHorizontalWinO(object sender, MyPosEventArgs args)
        {
            int win = 0;

            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                if (_cells[i, args.Y] is OCell)
                {
                    win = 1;
                }
                else
                {
                    win = 0;
                    break;
                }

            }
            _horzWinO = win;
            return win;

        }

        #endregion

        #region Vertical

        // Проверка на вертикаль
        public int GetVerticalWinX(object sender, MyPosEventArgs args)
        {
            int win = 0;

            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                if (_cells[args.X, i] is XCell)
                {
                    win = 1;
                }
                else
                {
                    win = 0;
                    break;
                }

            }
            _vertWinX = win;
            return win;

        }

        public int GetVerticalWinO(object sender, MyPosEventArgs args)
        {
            int win = 0;

            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                if (_cells[args.X, i] is OCell)
                {
                    win = 1;
                }
                else
                {
                    win = 0;
                    break;
                }

            }
            _vertWinO = win;
            return win;

        }

        #endregion

        #region  Diagonal

        public int GetDiagonalWin(int capacity)
        {
            int countX = 0;
            int countO = 0;

            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                if (_cells[i, i] is XCell)
                {
                    countX++;
                }
                if (_cells[i, i] is OCell)
                {
                    countO++;
                }
            }

            if (countX == capacity || countO == capacity)
            {
                return 1;
            }

            return 0;
        }

        public int GetDiagonalWinSec(int capacity)
        {
            int countX = 0;
            int countO = 0;

            for (int i = 0, j = _cells.GetLength(1) - 1; i < _cells.GetLength(0); i++, j--)
            {
                if (_cells[i, j] is XCell)
                {
                    countX++;
                }
                if (_cells[i, j] is OCell)
                {
                    countO++;
                }
            }

            if (countX == capacity || countO == capacity)
            {
                return 1;
            }

            return 0;
        }

        #endregion

        #endregion

        #region Indexator

        public CellState this[int index1, int index2]
        {
            get
            {
                return _cells[index1, index2].State;
            }
        }

        #endregion

        #region Properties

        public int Heigth
        {
            set
            {
                _heigth = value;
            }
            get
            {
                return _heigth;
            }
        }

        public int Wigth
        {
            set
            {
                _wigth = value;
            }
            get
            {
                return _wigth;
            }
        }

        public int PosX
        {

            get
            {
                return _posX;
            }
        }

        public int PosY
        {

            get
            {
                return _posY;
            }
        }

        public int VerticalWinX
        {
            get
            {
                return _vertWinX;
            }

        }

        public int VerticalWinO
        {
            get
            {
                return _vertWinO;
            }

        }

        public int HorizontalWinX
        {
            get
            {
                return _horzWinX;
            }
        }

        public int HorizontalWinO
        {
            get
            {
                return _horzWinO;
            }
        }

        #endregion

        #region Public
        public Cell[,] _cells;

        // текущая позиция курсора на игровом поле
        public int _posX;
        public int _posY;

        #endregion

        #region Protected

        protected int _heigth;
        protected int _wigth;

        #endregion

        #region Private

        public int _vertWinX;

        public int _horzWinX;
        public int _vertWinO;
        public int _horzWinO;

        #endregion
    }
}
