using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams.Technogise.OOPS
{
    public class Queen : Warrior
    {
        public Queen() :
            base(new List<Movement> {
                new StraightMovement(
                    new List<Direction> {
                            Direction.Top,
                            Direction.Left,
                            Direction.Right,
                            Direction.Down,
                     },StepCount.Max),
                new DiagonalMovement(
                    new List<Direction> {
                            Direction.TopLeft,
                            Direction.TopRight,
                            Direction.DownLeft,
                            Direction.DownRight,
                     },StepCount.Max)
            })
        {
        }
    }
}
