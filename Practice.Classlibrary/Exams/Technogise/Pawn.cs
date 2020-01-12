using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams.Technogise
{
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
}
