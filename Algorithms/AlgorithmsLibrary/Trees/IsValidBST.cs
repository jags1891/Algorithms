using AlgorithmsLibrary.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsLibrary.Trees
{
    /// <summary>
    /// 
    /// </summary>
    public class IsValidBST
    {
        /// <summary>
        /// isValidBST
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool isValidBST(TreeNode root)
        {
            return root == null || isValidBST(root, Int64.MinValue, Int64.MaxValue);
        }

        private bool isValidBST(TreeNode node, long min, long max)
        {
            if (node == null)
                return true;

            if (min >= node.value || node.value >= max)
                return false;

            return isValidBST(node.left, min, node.value) &&
                isValidBST(node.right, node.value, max);
        }


        /// <summary>
        /// Find if the tree is valid BST by simple inorder traversal
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public bool isValidBST_v1(TreeNode root)
        {
            List<int> inorderL = new List<int>();
            Traversals t = new Traversals();
            t.Inorder(root, inorderL);
            var expected = inorderL.Distinct().OrderBy(x => x);
            return inorderL.SequenceEqual(expected);
        }
    }
}
