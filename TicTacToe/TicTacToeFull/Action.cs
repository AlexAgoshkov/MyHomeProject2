using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;

namespace TicTacToeFull
{

    delegate void Show(object sender, MyPosEventArgs args);

    delegate int CheckWin(object seder, MyPosEventArgs args);

    class Action : IActionable
    {
        public Action()
        {

            ToShow += PrintWalk;

            // Подписка на победу
            _WinCheck += _f.GetHorizontalWinX;
            _WinCheck += _f.GetVerticalWinX;
            _WinCheck += _f.GetHorizontalWinO;
            _WinCheck += _f.GetVerticalWinO;

        }

        /// <summary>
        /// Управление с помощью кнопок
        /// </summary>
        public void MainFunction()
        {
            View v = new View();

            v.InitializeField();

            UserAction action = UserAction.NoAction;
            int i = 0;
            do
            {
                v.ShowModel(_f); // Отрисовка Х или О
                action = Control.GetUserAction();
                switch (action)
                {
                    case UserAction.Left:
                        _f.IsMoveCursore(-1, 0);
                        break;
                    case UserAction.Right:
                        _f.IsMoveCursore(1, 0);
                        break;
                    case UserAction.Top:
                        _f.IsMoveCursore(0, -1);
                        break;
                    case UserAction.Bottom:
                        _f.IsMoveCursore(0, 1);
                        break;
                    case UserAction.SetXO:
                         PlayerMove(); // Ставит Х или О по нажатию Пробела
                        break;
                    default:
                        break;
                }


                Console.SetCursorPosition(30, 6);
                Console.WriteLine("Iteration - {0}", i++);


            } while (IsWin());

            v.ShowModel(_f); //Повторный вызов метода для того чтобы не затерало последний элемент
        }

        /// <summary>
        /// Определение победы
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        private bool IsWin()
        {
            #region Win
          
            return _f.GetDiagonalWin(_capacity) != 1 &&
                   _f.GetDiagonalWinSec(_capacity) != 1 &&
                    _f.VerticalWinX != 1 &&
                    _f.HorizontalWinO != 1 &&
                    _f.HorizontalWinX != 1 &&
                    _f.VerticalWinO != 1;

            #endregion
        }

       
        private void PlayerMove()
        {

            if (_f._cells[_f._posX, _f._posY] == null)
            {
                if (_isXMove)
                {
                    OnShow(_f._posX, _f._posY);
                    _isXMove = false;
                }
                else
                {
                    OnShow(_f._posX, _f._posY);
                    _isXMove = true;
                }
            }
        }

        /// <summary>
        /// Ставит Х или О
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void PrintWalk(object sender, MyPosEventArgs args)
        {
            if (_isXMove == false)
            {
                _f._cells[args.X, args.Y] = new XCell();
            }
            else if (_isXMove == true)
            {
                _f._cells[args.X, args.Y] = new OCell();
            }

            WinCheck(args.X, args.Y);

        }

        public void WinCheck(int x, int y)
        {
            if (_WinCheck != null)
            {
                _WinCheck(this, new MyPosEventArgs(x, y));
            }
        }

        public bool IsMove
        {
            get
            {
                return _isXMove;
            }
        }

        public event CheckWin EventWinCheck
        {
            add
            {
                _WinCheck += value;
            }
            remove
            {
                _WinCheck -= value;
            }

        }

        public event Show ToShow
        {
            add
            {
                _setxo += value;
            }
            remove
            {
                _setxo -= value;
            }
        }

        public void OnShow(int x, int y)
        {
            if (_setxo != null)
            {
                _setxo(this, new MyPosEventArgs(x, y));

            }
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }

        #region Private

        private Field _f = new Field(_capacity, _capacity);
        private Show _setxo = null; //Делегат
        private CheckWin _WinCheck = null;  //Делегат
        private static int _capacity = 3; // Размер игрового поля
        private bool _isXMove = false; //Ход игрока fasle - X   ,  true - O

        #endregion
    }
}
