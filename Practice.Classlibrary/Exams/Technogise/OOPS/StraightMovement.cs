using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams.Technogise.OOPS
{
    public class StraightMovement : Movement
    {
        public StraightMovement(List<Direction> directions, int stepCount)
            : base(directions, stepCount)
        {
        }

        public override string GetMoves(string[,] chessBoard, int row, int col)
        {
            //Top
            string topMove = "";
            //Left
            string leftMove = "";
            //Right
            string rightMove = "";
            //Down
            string downMove = "";

            foreach (var direction in this.directions)
            {
                switch (direction)
                {
                    case Direction.Top:
                        topMove = getTopMove(chessBoard, row, col);
                        break;
                    case Direction.Down:
                        downMove = getDownMove(chessBoard, row, col);
                        break;
                    case Direction.Left:
                        leftMove = getLeftMove(chessBoard, row, col);
                        break;
                    case Direction.Right:
                        rightMove = getRightMove(chessBoard, row, col);
                        break;
                }

            }

            string moves = $"{leftMove} { topMove}  "
                          + $"{rightMove} {downMove}";

            return moves;

        }

        private string getTopMove(string[,] chessBoard, int row, int col)
        {
            string move = "";

            int stepCnt = 1;

            if (row > 0)
            {

                for (int r = row - 1; r >= 0 && stepCnt <= stepCount; r--, stepCnt++)
                {
                    move = move + " " + chessBoard[r, col];
                }

            }

            return move;
        }

        private string getLeftMove(string[,] chessBoard, int row, int col)
        {

            string move = "";

            int stepCnt = 1;

            if (col > 0)
            {

                for (int c = col - 1; c >= 0 && stepCnt <= this.stepCount; c--, stepCnt++)
                {
                    move = move + " " + chessBoard[row, c];
                }

            }

            return move;
        }

        private string getRightMove(string[,] chessBoard, int row, int col)
        {
            string move = "";

            int stepCnt = 1;

            if (col < 7)
            {

                for (int c = col + 1; c <= 7 && stepCnt <= this.stepCount; c++, stepCnt++)
                {
                    move = move + " " + chessBoard[row, c];
                }

            }

            return move;
        }

        private string getDownMove(string[,] chessBoard, int row, int col)
        {
            string move = "";

            int stepCnt = 1;

            if (row < 7)
            {

                for (int r = row + 1; r <= 7 && stepCnt <= this.stepCount; r++, stepCnt++)
                {
                    move = move + " " + chessBoard[r, col];
                }

            }

            return move;
        }
    }
}
