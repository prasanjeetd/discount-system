using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams.Technogise
{
    public abstract class Movement
    {
        protected List<Direction> directions;

        protected int stepCount;

        public Movement(List<Direction> directions, int stepCount)
        {
            this.directions = directions;
            this.stepCount = stepCount;
        }

        public abstract string GetMoves(string[,] chessBoard, int row, int col);

    }
    

}
