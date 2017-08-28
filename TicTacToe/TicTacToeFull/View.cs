using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
namespace TicTacToeFull
{
    class View
    {
        public void MainShow(IActionable a)
        {
            act = a;
            try
            {
                a.MainFunction();
                PrintWin(a);
            }
            catch (NullReferenceException nfe)
            {
                Console.WriteLine(nfe.Message);
            }
            catch (ArgumentOutOfRangeException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void InitializeField()
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 1; i < act.Capacity * 2 + 1; i++)
            {
                for (int j = 0; j < act.Capacity * 2 + 1; j++)
                {
                    if (j == 0 || j == act.Capacity * 2)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.Write('_');
                    }

                    if (j % 2 == 1)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write('_');
                    }

                    if (j == 0 || j % 2 == 0)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write('│');
                    }
                }
            }

            #region field

            //Console.WriteLine("┬─┬─┬─┬");
            //Console.WriteLine("│ │ │ │");
            //Console.WriteLine("┼─┼─┼─┼");
            //Console.WriteLine("│ │ │ │");
            //Console.WriteLine("┼─┼─┼─┼");
            //Console.WriteLine("│ │ │ │");
            //Console.WriteLine("┴─┴─┴─┴");

            //if (capacity == 6)
            //{
            //    Console.WriteLine("┬─┬─┬─┬─┬─┬─┬");
            //    Console.WriteLine("│ │ │ │ │ │ │");
            //    Console.WriteLine("┼─┼─┼─┼─┼─┼─┼");
            //    Console.WriteLine("│ │ │ │ │ │ │");
            //    Console.WriteLine("┼─┼─┼─┼─┼─┼─┼");
            //    Console.WriteLine("│ │ │ │ │ │ │");
            //    Console.WriteLine("┼─┼─┼─┼─┼─┼─┼");
            //    Console.WriteLine("│ │ │ │ │ │ │");
            //    Console.WriteLine("┼─┼─┼─┼─┼─┼─┼");
            //    Console.WriteLine("│ │ │ │ │ │ │");
            //    Console.WriteLine("┼─┼─┼─┼─┼─┼─┼");
            //    Console.WriteLine("│ │ │ │ │ │ │");
            //    Console.WriteLine("┴─┴─┴─┴─┴─┴─┴");
            //}
            #endregion

        }

        private void PrintWin(IActionable a)
        {

            Console.SetCursorPosition(30, 7);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("End Game");


            if (a.IsMove)
            {

                Console.SetCursorPosition(30, 8);
                Console.WriteLine("X Win");
            }
            else
            {
                if (!a.IsMove)
                {

                    Console.SetCursorPosition(30, 8);
                    Console.WriteLine("O Win");
                }

            }
            Console.SetCursorPosition(30, 9);
            Console.WriteLine("Press Key");
        }


        public void ShowModel(Field f)
        {

            for (int i = 0; i < f._cells.GetLength(0); i++)
            {
                for (int j = 0; j < f._cells.GetLength(1); j++)
                {
                    char ch = ' ';           // Отрисовка пустой ячейки

                    if (f._cells[i, j] is XCell)
                    {
                        ch = 'X';                // Отрисовка Х
                    }
                    else
                    {
                        if (f._cells[i, j] is OCell)
                        {

                            ch = 'O';              // Отрисовка О
                        }
                    }

                    Console.SetCursorPosition(i * 2 + 1, j * 2 + 1);
                    Console.Write(ch);
                }

            }

            Console.SetCursorPosition(f._posX * 2 + 1, f._posY * 2 + 1);

        }

        #region Private

        private static IActionable act = null;


        #endregion
    }
}
