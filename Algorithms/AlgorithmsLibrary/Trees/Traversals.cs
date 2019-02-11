using System;
using AlgorithmsLibrary.DataStructures;

namespace AlgorithmsLibrary.Trees
{
    /// <summary>
    /// Tree Traversals
    ///       1
    ///      / \
    ///     2   3
    ///    / \
    ///  4    5
    ///  Depth First Traversals:     
    ///  (a) Inorder (Left, Root, Right) : 4 2 5 1 3
    ///  (b) Preorder (Root, Left, Right) : 1 2 4 5 3
    ///  (c) Postorder (Left, Right, Root) : 4 5 2 3 1
    ///  
    ///  Breadth First or Level Order Traversal : 1 2 3 4 5
    /// </summary>
    public class Traversals
    {
        /// <summary>
        /// Inorder (Left, Root, Right) 
        /// </summary>
        /// <param name="root"></param>
        public void printInorder(TreeNode root)
        {
            if (root == null)
                return;

            printInorder(root.left);
            Console.Write(root.value + " ");
            printInorder(root.right);
        }

        /// <summary>
        /// Preorder (Root, Left, Right)
        /// </summary>
        /// <param name="root"></param>
        public void printPreorder(TreeNode root)
        {
            if (root == null)
                return;

            Console.Write(root.value + " ");
            printPreorder(root.left);
            printPreorder(root.right);
        }

        /// <summary>
        /// Postorder (Left, Right, Root)
        /// </summary>
        /// <param name="root"></param>
        public void printPostOrder(TreeNode root)
        {
            if (root == null)
                return;

            printPostOrder(root.left);
            printPostOrder(root.right);
            Console.Write(root.value + " ");
        }

    }
}
