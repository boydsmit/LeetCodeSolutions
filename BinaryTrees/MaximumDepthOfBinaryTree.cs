using System;

namespace LeetCodeTasks.BinaryTrees
{
    /*
     * TASK: 104
     *
     * Given the root of a binary tree, return its maximum depth.
     *
     * A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the
     * farthest leaf node.
     */
    
    public class MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root) {
            if(root == null){
                return 0;
            }
        
            var left = MaxDepth(root.left);
            var right = MaxDepth(root.right);
        
            return Math.Max(left,right) + 1;
        }
    }
}