using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams.Technogise
{
    public class Warrior
    {
        List<Movement> movements;

        public Warrior(List<Movement> movements)
        {
            this.movements = movements;
        }

        public virtual string GetMoves(string[,] chessBoard, string input)
        {
            int col = (int)input[0] - 65;
            int row = 8 - Convert.ToInt32(input[1].ToString());

            string moves = "";

            foreach (var movement in this.movements)
            {
                moves = moves + movement.GetMoves(chessBoard, row, col);
            }

            return moves;
        }
    }
}
