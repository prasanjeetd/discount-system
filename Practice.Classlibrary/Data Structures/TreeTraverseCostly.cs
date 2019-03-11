using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Data_Structures
{
    public class TreeTraverseCostly
    {
        public void TraverseByBreadth(Tree tree, int level = 0)
        {
            if (tree != null)
            {
                Console.WriteLine(tree.value);
            }

            if (tree.left != null)
            {
                Console.WriteLine(tree.left.value);
            }

            if (tree.right != null)
            {
                Console.WriteLine(tree.right.value);
            }
        }

        public void Print(Tree tree)
        {

            Console.WriteLine("Printing a tree:");

            int height = CalculateHeight(tree);
            Console.WriteLine("Tree height:" + height);

            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Processing height:" + i);
                PrintLevel(tree, i);
            }
        }

        public int CalculateHeight(Tree tree)
        {
            if (tree == null)
            {
                Console.WriteLine("Root tree:" + 0);

                return 0;
            }
            else
            {
                int lHeight = CalculateHeight(tree.left);
                int rHeight = CalculateHeight(tree.right);

                Console.WriteLine("--------------------------");
                Console.WriteLine("Tree Lheight:" + lHeight);
                Console.WriteLine("Tree Rheight:" + rHeight);
                if (lHeight > rHeight)
                {
                    return lHeight + 1;
                }
                else
                {
                    return rHeight + 1;
                }
            }

        }

        public void PrintLevel(Tree tree, int level)
        {

            if (tree == null)
            {
                return;
            }
            if (level == 1)
            {
                Console.WriteLine("Node value: " + tree.value);
            }
            else
            {
                Console.WriteLine("Skipping level:" + level);
                Console.WriteLine("Next level:" + (level - 1));

                PrintLevel(tree.left, level - 1);
                PrintLevel(tree.right, level - 1);
            }

        }
    }
}
