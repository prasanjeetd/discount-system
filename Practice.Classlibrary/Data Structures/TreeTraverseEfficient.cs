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

            while (Q.Count != 0)
            {

                Tree node = Q.Dequeue();

                Console.WriteLine("Tree value ->" + node.value);

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
    }
}
