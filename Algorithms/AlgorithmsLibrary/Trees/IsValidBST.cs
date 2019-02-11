using AlgorithmsLibrary.DataStructures;
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
