using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Data_Structures
{
    public class Tree
    {
        public int value { get; set; }

        public Tree left { get; set; }

        public Tree right { get; set; }

        public Tree(int value,Tree left, Tree right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        public Tree(int value)
        {
            this.value = value;
        }
    }
}
