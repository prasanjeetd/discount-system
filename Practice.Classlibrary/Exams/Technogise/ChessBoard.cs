using Practice.Classlibrary.Exams.Technogise;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams
{
    public class ChessBoard
    {
        public void Play()
        {

            string[,] chessBoard = initializeBoard();

            string input = "F1";

            Console.WriteLine("Chessboard inputs:" + input);

            //string moves = new Pawn().GetMoves(chessBoard, input);
            //Console.WriteLine(moves);

            //string moves = new King().GetMoves(chessBoard, input);
            //Console.WriteLine(moves);

            string moves = new Queen().GetMoves(chessBoard, input);
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


}
