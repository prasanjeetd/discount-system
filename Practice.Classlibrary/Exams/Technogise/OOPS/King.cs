using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams.Technogise.OOPS
{
    public class King : Warrior
    {
        public King() :
            base(new List<Movement> {
                new StraightMovement(
                    new List<Direction> {
                            Direction.Top,
                            Direction.Left,
                            Direction.Right,
                            Direction.Down,
                     },1),
                new DiagonalMovement( 
                    new List<Direction> {
                            Direction.TopLeft,
                            Direction.TopRight,
                            Direction.DownLeft,
                            Direction.DownRight,
                     },1)
            })
        {
        }
    }
}
