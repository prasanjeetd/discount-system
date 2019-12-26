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
            tree.right.left = new Tree(6);
            tree.right.right = new Tree(7);

            //TreeTraverseCostly traverse = new TreeTraverseCostly();
            //int height = traverse.CalculateHeight(tree);
            //traverse.Print(tree);

            //TreeTraverseEfficient tEfficient = new TreeTraverseEfficient();
            //tEfficient.Traverse(tree);

            TreeTraversalOrder treeOrder = new TreeTraversalOrder();
            Console.WriteLine("\n Inorder tree");
            treeOrder.InOrder(tree);
            treeOrder.Print();

            Console.WriteLine("\n Preorder tree");
            treeOrder.treeData.Clear();
            treeOrder.PreOrder(tree);
            treeOrder.Print();

            Console.WriteLine("\n Level order tree");
            treeOrder.PrintLevelOrder(tree);

            Console.WriteLine("\n Inorder tree");
            treeOrder.PrintInorder(tree);

        }
    }
}
