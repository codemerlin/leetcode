/*
 * @lc app=leetcode id=113 lang=csharp
 *
 * [113] Path Sum II
 *
 * https://leetcode.com/problems/path-sum-ii/description/
 *
 * algorithms
 * Medium (40.84%)
 * Total Accepted:    274.3K
 * Total Submissions: 634.4K
 * Testcase Example:  '[5,4,8,11,null,13,4,7,2,null,null,5,1]\n22'
 *
 * Given a binary tree and a sum, find all root-to-leaf paths where each path's
 * sum equals the given sum.
 * 
 * Note: A leaf is a node with no children.
 * 
 * Example:
 * 
 * Given the below binary tree and sum = 22,
 * 
 * 
 * ⁠     5
 * ⁠    / \
 * ⁠   4   8
 * ⁠  /   / \
 * ⁠ 11  13  4
 * ⁠/  \    / \
 * 7    2  5   1
 * 
 * 
 * Return:
 * 
 * 
 * [
 * ⁠  [5,4,11,2],
 * ⁠  [5,8,4,5]
 * ]
 * 
 * 
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        var output = TraverseTree(root);
        foreach(var v in output) {
            foreach(var k in v) {
                Console.Write(k)
                Console.Write("-")
            }
            Console.WriteLine();
        }

    }

    public IList<IList<int>> TraverseTree(TreeNode root){
        if(root.left==null && root.right==null) {
            return new List<List<int>>() {
                new List<int> {root}
            }
        }
        if(root.left!=null) {
            var leftPaths = TraverseTree(root.left);
            foreach(var l in leftPaths) {
                l.Insert(0,root);
            }
        }
        if(root.right!=null) {
            var rightPaths = TraverseTree(root.right);
            foreach(var r in rightPaths) {
                r.Insert(0,root);
            }
        }
        var allPaths = new List<List<int>>();
        allPaths.AddRange(leftPaths);
        allPaths.AddRange(rightPaths);
        return allPaths
    }
}
