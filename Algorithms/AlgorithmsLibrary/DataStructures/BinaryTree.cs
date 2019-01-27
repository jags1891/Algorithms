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

        public TreeNode Insert(int val)
        {
            if (root == null)
            {
                root = new TreeNode
                {
                    value = val
                };
            }
           
            return Insert(root,val);
        }

        private TreeNode Insert(TreeNode node, int val)
        {
            if (val < node.value)
                node.left = Insert(node.left, val);
            else
                node.right = Insert(node.right, val);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        public BinaryTree(int key)
        {
            root = new TreeNode(key);
        }

        /// <summary>
        /// 
        /// </summary>
        public BinaryTree()
        {
            root = null;
        }
    }
}
