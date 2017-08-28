using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeFull
{
    public enum UserAction
    {
        NoAction,
        Left,
        Right,
        Exit,
        Top,
        Bottom,
        SetXO,
        Y,
        N

    }

    class Control
    {
        public static UserAction GetUserAction()
        {
            UserAction action = UserAction.NoAction;
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    action = UserAction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    action = UserAction.Right;
                    break;
                case ConsoleKey.UpArrow:
                    action = UserAction.Top;
                    break;
                case ConsoleKey.DownArrow:
                    action = UserAction.Bottom;
                    break;
                case ConsoleKey.Escape:
                    action = UserAction.Exit;
                    break;
                case ConsoleKey.Spacebar:
                    action = UserAction.SetXO;
                    break;
                case ConsoleKey.Y:
                    action = UserAction.Y;
                    break;
                case ConsoleKey.N:
                    action = UserAction.N;
                    break;
            }

            return action;
        }

    }
}
