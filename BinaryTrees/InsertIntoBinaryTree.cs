namespace LeetCodeTasks.BinaryTrees
{
    /*
     * TASK: 7O1
     *
     * You are given the root node of a binary search tree (BST) and a value to insert into the tree. Return the root
     * node of the BST after the insertion. It is guaranteed that the new value does not exist in the original BST.
     *
     * Notice that there may exist multiple valid ways for the insertion, as long as the tree remains a BST after
     * insertion. You can return any of them.
     */
    
    public class InsertIntoBinaryTree
    {
        public TreeNode InsertIntoBST(TreeNode root, int val) {
            if(root == null) {
                return new TreeNode(val);
            }
    
            if(root.val > val) {
                root.left = InsertIntoBST(root.left, val);
        
            } else {
                root.right = InsertIntoBST(root.right, val);
            }
            return root;
        }
    }
}