using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
namespace WinFormTicTacToe
{
  

    partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
        }

        private void btClick(object sender, EventArgs e)
        {
           

            Button b = sender as Button;

            Walk();

            ShowM(b);

            b.Enabled = false;

            CheckWin();

        }

      

        private void Walk()
        {
            for (int i = 0; i < _f._cells.GetLength(0); i++)
            {

                for (int j = 0; j < _f._cells.GetLength(1); j++)
                {
                    
                        if (_isXMove)
                        {
                            _f._cells[i, j] = new OCell();
                            _isXMove = false;
                        }
                        else
                        {
                            _f._cells[i, j] = new XCell();
                            _isXMove = true;
                        }  
                    }
                }
            }

        public void CheckWin()
        {
           
            bool isWin = false;

            #region Horizontal

            //Horizontal
            if ((btOne.Text == btTwo.Text) && (btTwo.Text == btThree.Text) && (!btOne.Enabled))
            {
                isWin = true;
            }
            else if ((btFour.Text == btFive.Text) && (btFive.Text == btSix.Text) && (!btFour.Enabled))
            {
                isWin = true;
            }
            else if ((btSeven.Text == btEight.Text) && (btEight.Text == btNine.Text) && (!btSeven.Enabled))
            {
                isWin = true;
            }

            #endregion

            #region Vertical

            //Vertical
            if ((btOne.Text == btFour.Text) && (btFour.Text == btSeven.Text) && (!btOne.Enabled))
            {
                isWin = true;
            }
            else if ((btTwo.Text == btFive.Text) && (btFive.Text == btEight.Text) && (!btTwo.Enabled))
            {
                isWin = true;
            }
            else if ((btThree.Text == btSix.Text) && (btSix.Text == btNine.Text) && (!btThree.Enabled))
            {
                isWin = true;
            }

            #endregion

            #region Diagonal

            //Diagonal
            if ((btOne.Text == btFive.Text) && (btFive.Text == btNine.Text) && (!btOne.Enabled))
            {
                isWin = true;
            }
            else if ((btThree.Text == btFive.Text) && (btFive.Text == btSeven.Text) && (!btThree.Enabled))
            {
                isWin = true;
            }

            #endregion 

            #region Draw
            else if (!btOne.Enabled && !btTwo.Enabled && !btThree.Enabled && !btFour.Enabled &&
                !btFive.Enabled && !btSix.Enabled && !btSeven.Enabled && !btEight.Enabled &&
                !btNine.Enabled)
            {
                // disableButtom();
                MessageBox.Show("Draw");
            }
            #endregion

          

            if (isWin)
            {
                disableButtom();
                if (_isXMove)
                {
                    MessageBox.Show("X Win");
                }
                else
                {
                    MessageBox.Show("O Win");
                }
               
            }

           
        }

        private void disableButtom()
        {
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = c as Button;
                    b.Enabled = false;
                }
                catch(Exception e)
                {
                  
                }
            }
        }

        private void ShowM(Button b)
        {

            for (int i = 0; i < _f._cells.GetLength(0); i++)
            {
                for (int j = 0; j < _f._cells.GetLength(1); j++)
                {

                    if (_f._cells[i, j] is XCell)
                    {
                        b.Text = "X";                // Отрисовка Х

                    }
                    else
                    {
                        if (_f._cells[i, j] is OCell)
                        {

                            b.Text = "O";              // Отрисовка О
                        }
                    }
                }
            }
        }
        
        #region Private

        private Field _f = new Field(_capacity, _capacity);
        private static int _capacity = 3; // Размер игрового поля
        public bool _isXMove = false; //Ход игрока fasle - X   ,  true - O

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rulesOfTheGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region

            MessageBox.Show
            ("The object of Tic Tac Toe is to get three in a row. " +
             "You play on a three by three game board. " +
             "he first player is known as X and the second is O. " +
             "Players alternate placing Xs and Os on the game board until either oppent has three in a row or all nine squares are filled." +
             "X always goes first, and in the event that no one has three in a row, the stalemate is called a draw game.", "Tic-Tac-Toe Rules", MessageBoxButtons.OK);

            #endregion
        }

        #endregion

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isXMove = false;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = c as Button;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch (Exception ex)
                {

                }
            }
        }

    }
}
