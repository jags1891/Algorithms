using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLibrary.DataStructures
{
    /// <summary>
    /// Tree Node
    /// </summary>
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val)
        {
            this.value = val;
            left = right = null;
        }

        public TreeNode()
        {

        }
    }

    /// <summary>
    /// Binary Search Tree BST
    /// </summary>
    public class BinarySearchTree
    {
        public TreeNode root;

        public TreeNode insert(int val)
        {
            if (root == null)
            {
                root = new TreeNode();
                root.value = val;
            }
           
            return insert(root,val);
        }

        private TreeNode insert(TreeNode node, int val)
        {
            if (val < node.value)
                node.left = insert(node.left, val);
            else
                node.right = insert(node.right, val);
            return node;
        }

    }

    /// <summary>
    /// --------------------------------------------------
    /// Binary Tree
    /// --------------------------------------------------
    /// Example of the usage: 
    /// 
    /// BinaryTree tree = new BinaryTree();
    /// tree.root = new TreeNode(1);
    /// tree.root.left = new Node(2)
    /// tree.root.right = new Node(3); 
    /// 1 will be the root
    /// 2 and 3 become left and right children of 1 
    ///           1 
    ///         /   \ 
    ///        2     3
    ///       /        \
    ///      null      null
    /// </summary>
    public class BinaryTree
    {
        public TreeNode root;

        BinaryTree(int key)
        {
            root = new TreeNode(key);
        }

        BinaryTree()
        {
            root = null;
        }
    }
}
