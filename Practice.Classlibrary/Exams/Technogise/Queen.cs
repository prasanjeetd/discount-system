using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams.Technogise
{
    public class Queen : Army
    {
        public Queen()
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
}
