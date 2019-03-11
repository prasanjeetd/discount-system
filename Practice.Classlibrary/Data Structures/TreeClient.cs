using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Data_Structures
{
    public class TreeClient
    {
        public void Call()
        {
            Tree tree = new Tree(1);
            tree.left = new Tree(2);
            tree.right = new Tree(3);
            tree.left.left = new Tree(4);
            tree.left.right = new Tree(5);

            TreeTraverse traverse = new TreeTraverse();
            //int height = traverse.CalculateHeight(tree);
            traverse.Print(tree);
        }
    }
}
