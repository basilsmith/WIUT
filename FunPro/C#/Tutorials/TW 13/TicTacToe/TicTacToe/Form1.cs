using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private enum Players
        {
            None,
            Player1,
            Player2,
            Tie
        }

        private Players[,] cells = new Players[3,3];

        private void pnl_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.DrawLine(Pens.Black, 70, 1, 70, 210);
            g.DrawLine(Pens.Black, 140, 1, 140, 210);
            g.DrawLine(Pens.Black, 1, 70, 210, 70);
            g.DrawLine(Pens.Black, 1, 140, 210, 140);

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var cellCoordinates = new Rectangle(i * 70 + 1, j * 70 + 1, 69, 69);
                    if (cells[i, j] == Players.Player1)
                        g.FillRegion(Brushes.Blue, new Region(cellCoordinates));
                    else if (cells[i, j] == Players.Player2)
                        g.FillRegion(Brushes.Red, new Region(cellCoordinates));
                }
            }
        }

        private void pnl_MouseClick(object sender, MouseEventArgs e)
        {
            var isMove = false;
            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    var cellCoordinates = new Rectangle(i * 70 + 1, j * 70 + 1, 69, 69);
                    if (cellCoordinates.Contains(e.Location.X, e.Location.Y))
                    {
                        //check that it's not already occupied
                        if (cells[i, j] == Players.None)
                        {
                            isMove = true;
                            cells[i, j] = Players.Player1;
                        }
                    }
                }
            }

            if (isMove)
            {
                //redraw
                pnl.Invalidate();

                //check winner
                var winner = CheckWinner();

                if (winner == Players.Tie)
                {
                    MessageBox.Show("It's a tie");
                    ResetGame();
                }
                else if (winner == Players.Player1)
                {
                    MessageBox.Show("Player 1 wins");
                    ResetGame();
                }
                else //go on with current game - AI move
                {
                    MakeAIMove();

                    //check if AI won
                    if (CheckWinner() == Players.Player2)
                    {
                        MessageBox.Show("Player 2 wins");
                        ResetGame();
                    }
                    else //we go on - redraw
                        pnl.Invalidate();
                }
            }
        }

        private void MakeAIMove()
        {
            var r = new Random();

            //try center first
            var row = 1;
            var column = 1;
            while (cells[row, column] != Players.None) //keep trying until you find a free spot
            {
                row = r.Next(0, 3);
                column = r.Next(0, 3);
            }

            //if we are here - move was done
            cells[row, column] = Players.Player2;
            pnl.Invalidate();
        }

        private Players CheckWinner()
        {
            //check verticals
            for (var i = 0; i < 3; i++)
                if (cells[i, 0] != Players.None && cells[i, 0] == cells[i, 1] && cells[i, 0] == cells[i, 2])
                    return cells[i, 0];

            //check horizontals
            for (var i = 0; i < 3; i++)
                if (cells[0, i] != Players.None && cells[0, i] == cells[1, i] && cells[0, i] == cells[2, i])
                    return cells[0, i];

            //check diagonals
            if (cells[0, 0] != Players.None && cells[0, 0] == cells[1, 1] && cells[0, 0] == cells[2, 2])
                return cells[1, 1];

            if (cells[2, 0] != Players.None && cells[2, 0] == cells[1, 1] && cells[2, 0] == cells[0, 2])
                return cells[1, 1];

            //check tie
            var isTie = true;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (cells[i, j] == Players.None)
                        isTie = false;
            if (isTie)
                return Players.Tie;

            //if we are here - no winner yet
            return Players.None;
        }

        private void ResetGame()
        {
            //clear the cells
            cells = new Players[3,3];
            
            //redraw
            pnl.Invalidate();
        }
    }
}
