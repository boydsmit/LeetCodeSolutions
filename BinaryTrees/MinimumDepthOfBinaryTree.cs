using System;

namespace LeetCodeTasks.BinaryTrees
{
    /*
     * TASK: 111
     *
     * Given a binary tree, find its minimum depth.
     *
     * The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.
     *
     * Note: A leaf is a node with no children.
     */
    
    public class MinimumDepthOfBinaryTree
    {
        public int MinDepth(TreeNode root) {
            if(root == null){
                return 0;
            }
            else if(root.left == null){
                return MinDepth(root.right) + 1;
            } else if(root.right == null)  {
                return MinDepth(root.left) + 1;
            } else {        
                return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;
            }
        }
    }
}