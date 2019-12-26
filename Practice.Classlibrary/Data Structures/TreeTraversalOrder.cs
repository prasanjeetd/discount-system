using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Classlibrary.Data_Structures
{
    public class TreeTraversalOrder
    {
        public SortedList<int, Queue<int>> treeData = new SortedList<int, Queue<int>>();

        public void InOrder(Tree tree, int h = 0)
        {
            if (tree == null)
            {
                return;
            }

            int level = h + 1;

            if (tree.left != null)
            {
                InOrder(tree.left, level);
            }

            Console.Write(tree.value + " ");

            if (treeData.ContainsKey(h))
            {
                treeData[h].Enqueue(tree.value);
            }
            else
            {
                treeData.Add(h, new Queue<int>(new[] { tree.value }));
            }

            if (tree.right != null)
            {
                InOrder(tree.right, level);
            }
        }

        public void PreOrder(Tree tree, int h = 0)
        {
            if (tree == null)
            {
                return;
            }

            int level = h + 1;

            Console.Write(tree.value + " ");

            if (treeData.ContainsKey(h))
            {
                treeData[h].Enqueue(tree.value);
            }
            else
            {
                treeData.Add(h, new Queue<int>(new[] { tree.value }));
            }

            if (tree.left != null)
            {
                PreOrder(tree.left, level);
            }

            if (tree.right != null)
            {
                PreOrder(tree.right, level);
            }
        }

        public void Print()
        {
            Console.WriteLine("\n--------------Printing tree-----------------------");

            foreach (var node in treeData)
            {

                Queue<int> data = node.Value;

                for (int i = treeData.Count - node.Key - 1; i > 0; i--)
                {
                    Console.Write(" ");
                }


                while (data.Count > 0)
                {
                    int val = data.Dequeue();
                    Console.Write(val + " ");
                }

                Console.WriteLine();

            }
        }

        public void PrintLevelOrder(Tree tree)
        {
            if (tree == null)
            {
                return;
            }

            Queue<Tree> nodes = new Queue<Tree>();
            nodes.Enqueue(tree);

            while (true)
            {
                int count = nodes.Count;

                if (count == 0)
                {
                    break;
                }

                while (count > 0)
                {
                    Tree node = nodes.Dequeue();

                    Console.Write(node.value + "");

                    if (node.left != null)
                    {
                        nodes.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        nodes.Enqueue(node.right);
                    }

                    count--;
                }

                Console.WriteLine("");
            }
        }

        public void PrintInorder(Tree tree)
        {
            if (tree == null)
            {
                return;
            }

            Stack<Tree> s = new Stack<Tree>();
            Tree curr = tree;

            while (curr != null || s.Count > 0)
            {

                while (curr != null)
                {
                    s.Push(curr);
                    curr = curr.left;
                }

                curr = s.Pop();
                Console.Write(curr.value + " ");

                curr = curr.right;

            }


        }
    }
}
