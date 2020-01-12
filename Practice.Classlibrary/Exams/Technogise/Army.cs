using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams.Technogise
{
    public class Army
    {
        int stepCount = 1;

        List<Direction> directions;

        public Army(List<Direction> directions, int stepCount)
        {
            this.stepCount = stepCount;
            this.directions = directions;
        }

        public virtual string GetMoves(string[,] chessBoard, string input)
        {
            //Pawn

            int col = (int)input[0] - 65;
            int row = 8 - Convert.ToInt32(input[1].ToString());

            //Top
            string topMove = "";
            //Left
            string leftMove = "";
            //Right
            string rightMove = "";
            //Diagonal Top Left
            string topLeftMove = "";
            //Diagonal Top Right
            string topRightMove = "";
            //Down
            string downMove = "";
            //Diagonal Down Left
            string downLeftMove = "";
            //Diagonal Down Right
            string downRightMove = "";

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

            string moves = $"{topLeftMove} { topMove} {topRightMove} "
                          + $"{leftMove} {rightMove} " +
                         $"{downLeftMove} {downMove} {downRightMove}";


            return moves;
        }

        private string getTopMove(string[,] chessBoard, int row, int col)
        {
            string move = "";

            int stepCnt = 1;

            if (row > 0)
            {

                for (int r = row - 1; r >= 0 && stepCnt <= this.stepCount; r--, stepCnt++)
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

                for (int r = row + 1; r <= 7 && stepCnt <= this.stepCount; r--, stepCnt++)
                {
                    move = move + " " + chessBoard[r, col];
                }

            }

            return move;
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
