using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams
{
    public class Technogise
    {
        public void PlayChess()
        {

            string[,] chessBoard = initializeBoard();

            string input = "F1";

            Console.WriteLine("Chessboard inputs:" + input);

            //string moves = new Pawn().GetMoves(chessBoard, input);
            //Console.WriteLine(moves);

            string moves = new King().GetMoves(chessBoard, input);
            Console.WriteLine(moves);

        }

        private string[,] initializeBoard()
        {
            string[,] chessBoard = new string[8, 8];

            for (int i = 7; i >= 0; i--)
            {
                int asciKey = 65;

                for (int j = 0; j < 8; j++)
                {
                    char letter = (char)asciKey;
                    int col = 7 - i + 1;

                    chessBoard[i, j] = letter.ToString() + col;

                    asciKey++;
                }
            }

            return chessBoard;
        }

    }

    public class Pawn : Army
    {
        public Pawn()
            : base(new List<Direction> {
                Direction.Top,
                Direction.TopLeft,
                Direction.TopRight
            }, 1)
        {

        }
    }

    public class King : Army
    {
        public King()
           : base(new List<Direction> {
                Direction.Top,
                Direction.Left,
                Direction.Right,
                Direction.TopLeft,
                Direction.TopRight,
                Direction.Down,
                Direction.DownLeft,
                Direction.DownRight,
           }, 7)
        {
        }
    }

    public enum Direction
    {
        Top,
        Left,
        Right,
        Down,
        TopLeft,
        TopRight,
        DownLeft,
        DownRight
    }

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
                        //if (row > 0)
                        //{
                        //    int topR = row - 1;
                        //    topMove = chessBoard[topR, col];
                        //}
                        topMove = getTopMove(chessBoard, row, col);
                        break;
                    case Direction.Down:
                        if (row < 7)
                        {
                            int topD = row + 1;
                            downMove = chessBoard[topD, col];
                        }
                        break;
                    case Direction.Left:
                        //if (col > 0)
                        //{
                        //    int colL = col - 1;
                        //    leftMove = chessBoard[row, colL];
                        //}
                        leftMove = getLeftMove(chessBoard, row, col);
                        break;
                    case Direction.Right:

                        if (col < 7)
                        {
                            int colR = col + 1;
                            rightMove = chessBoard[row, colR];
                        }
                        break;
                    case Direction.TopLeft:
                        if (row > 0 && col > 0)
                        {
                            int rowTL = row - 1;
                            int colTL = col - 1;

                            topLeftMove = chessBoard[rowTL, colTL];
                        }
                        break;
                    case Direction.DownLeft:
                        if (row < 7 && col > 0)
                        {
                            int rowDL = row + 1;
                            int colDL = col - 1;

                            downLeftMove = chessBoard[rowDL, colDL];
                        }
                        break;
                    case Direction.TopRight:

                        if (row > 0 && col < 7)
                        {
                            int rowTR = row - 1;
                            int colTR = col + 1;

                            topRightMove = chessBoard[rowTR, colTR];
                        }
                        break;
                    case Direction.DownRight:

                        if (row < 7 && col < 7)
                        {
                            int rowDR = row + 1;
                            int colDR = col + 1;

                            downRightMove = chessBoard[rowDR, colDR];
                        }
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
            string topMove = "";

            int stepCnt = 1;

            if (row > 0)
            {

                for (int r = row - 1; r >= 0 && stepCnt <= this.stepCount; r--, stepCnt++)
                {
                    topMove = topMove + " " + chessBoard[r, col];
                }

            }

            return topMove;
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
    }


}
