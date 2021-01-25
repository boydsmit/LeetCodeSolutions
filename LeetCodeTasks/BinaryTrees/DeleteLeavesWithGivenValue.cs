namespace LeetCodeTasks.BinaryTrees
{
    /*
     * TASK: 1325
     *
     * Given a binary tree root and an integer target, delete all the leaf nodes with value target.
     *
     * Note that once you delete a leaf node with value target, if it's parent node becomes a leaf node and has the value
     * target, it should also be deleted (you need to continue doing that until you can't).
     */
    
    public class DeleteLeavesWithGivenValue
    {
        public TreeNode RemoveLeafNodes(TreeNode root, int target) {
            if(root == null) {
                return null;
            }
        
            root.left = RemoveLeafNodes(root.left, target);
            root.right = RemoveLeafNodes(root.right, target);
        
            if(root.left == null && root.right == null && root.val == target) {
                return null;
            }
            return root;
        }
    }
}