namespace LeetCodeTasks.BinaryTrees
{
    /*
     * TASK: 226
     *
     * Invert a binary tree.
     */
    
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root) {
            if (root == null) {
                return null;
            }
        
            var left = InvertTree(root.left);
            var right = InvertTree(root.right);
        
            root.left = right;
            root.right = left;
        
            return root;
        }
    }
}