using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Data_Structures
{
    //https://www.geeksforgeeks.org/level-order-tree-traversal/
    public class TreeTraverseEfficient
    {

        public void Traverse(Tree tree)
        {
            Queue<Tree> Q = new Queue<Tree>();

            Q.Enqueue(tree);

            int h = 0;

            Queue<int> values = new Queue<int>();

            while (Q.Count != 0)
            {

                Tree node = Q.Dequeue();

                Console.WriteLine("Tree value ->" + node.value);

                //values.Enqueue(node.value);

                //h++;

                if (node.left != null)
                {
                    Q.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    Q.Enqueue(node.right);
                }
            }

        }

        void PrintTree(Queue<int> treeVals, int h)
        {

        }
    }
}
