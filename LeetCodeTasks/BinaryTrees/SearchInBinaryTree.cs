namespace LeetCodeTasks.BinaryTrees
{
    /*
     * TASK: 700
     *
     * You are given the root of a binary search tree (BST) and an integer val.
     *
     * Find the node in the BST that the node's value equals val and return the subtree rooted with that node.
     * If such a node does not exist, return null.
     */
    
    public class SearchInBinaryTree
    {
        public TreeNode SearchBST(TreeNode root, int val) {
            if(root == null){
                return null;
            }
       
            if(val == root.val) {
                return root;
            } else if(val < root.val) {
                return SearchBST(root.left, val);
            } else {
                return SearchBST(root.right, val);
            }
        }
    }
}