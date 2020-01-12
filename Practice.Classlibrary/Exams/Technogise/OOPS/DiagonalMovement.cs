using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams.Technogise.OOPS
{
    public class DiagonalMovement : Movement
    {
        public DiagonalMovement(List<Direction> directions, int stepCount)
            : base(directions, stepCount)
        {
        }

        public override string GetMoves(string[,] chessBoard, int row, int col)
        {

            //Diagonal Top Left
            string topLeftMove = "";
            //Diagonal Top Right
            string topRightMove = "";
            //Diagonal Down Left
            string downLeftMove = "";
            //Diagonal Down Right
            string downRightMove = "";

            foreach (var direction in this.directions)
            {
                switch (direction)
                {
                    case Direction.TopLeft:
                        topLeftMove = getTopLeftMove(chessBoard, row, col);
                        break;
                    case Direction.DownLeft:
                        downLeftMove = getDownLeftMove(chessBoard, row, col);
                        break;
                    case Direction.TopRight:
                        topRightMove = getTopRightMove(chessBoard, row, col);
                        break;
                    case Direction.DownRight:
                        downRightMove = getDownRightMove(chessBoard, row, col);
                        break;
                }

            }

            string moves = $"{topLeftMove}  {topRightMove} " +
                         $"{downLeftMove}  {downRightMove}";


            return moves;
        }

        private string getTopLeftMove(string[,] chessBoard, int row, int col)
        {
            string move = "";

            int stepCnt = 1;

            if (row > 0 && col > 0)
            {
                int r = row - 1;
                int c = col - 1;

                for (; r >= 0 && c >= 0 && stepCnt <= this.stepCount; r--, c--, stepCnt++)
                {
                    move = move + " " + chessBoard[r, c];
                }

            }

            return move;
        }

        private string getDownLeftMove(string[,] chessBoard, int row, int col)
        {
            string move = "";

            int stepCnt = 1;

            if (row < 7 && col > 0)
            {
                int r = row + 1;
                int c = col - 1;

                for (; r <= 7 && c >= 0 && stepCnt <= this.stepCount; r++, c--, stepCnt++)
                {
                    move = move + " " + chessBoard[r, c];
                }

            }

            return move;
        }

        private string getTopRightMove(string[,] chessBoard, int row, int col)
        {
            string move = "";

            int stepCnt = 1;

            if (row > 0 && col < 7)
            {
                int r = row - 1;
                int c = col + 1;

                for (; r >= 0 && c <= 7 && stepCnt <= this.stepCount; r--, c++, stepCnt++)
                {
                    move = move + " " + chessBoard[r, c];
                }

            }

            return move;
        }

        private string getDownRightMove(string[,] chessBoard, int row, int col)
        {
            string move = "";

            int stepCnt = 1;

            if (row < 7 && col < 7)
            {
                int r = row + 1;
                int c = col + 1;

                for (; r <= 7 && c <= 7 && stepCnt <= this.stepCount; r++, c++, stepCnt++)
                {
                    move = move + " " + chessBoard[r, c];
                }

            }

            return move;
        }
    }
}
