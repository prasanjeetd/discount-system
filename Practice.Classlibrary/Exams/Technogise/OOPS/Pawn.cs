using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Exams.Technogise.OOPS
{
    public class Pawn : Warrior
    {
        public Pawn() :
            base(new List<Movement> {
                new StraightMovement(
                    new List<Direction> {
                            Direction.Top,
                     },1),
                new DiagonalMovement(
                    new List<Direction> {
                            Direction.TopLeft,
                            Direction.TopRight,
                     },1)
            })
        {
        }
    }
}
