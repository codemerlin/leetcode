/*
 * @lc app=leetcode id=136 lang=csharp
 *
 * [136] Single Number
 *
 * https://leetcode.com/problems/single-number/description/
 *
 * algorithms
 * Easy (60.33%)
 * Total Accepted:    470.4K
 * Total Submissions: 779.7K
 * Testcase Example:  '[2,2,1]'
 *
 * Given a non-empty array of integers, every element appears twice except for
 * one. Find that single one.
 * 
 * Note:
 * 
 * Your algorithm should have a linear runtime complexity. Could you implement
 * it without using extra memory?
 * 
 * Example 1:
 * 
 * 
 * Input: [2,2,1]
 * Output: 1
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: [4,1,2,1,2]
 * Output: 4
 * 
 * 
 */
public class Solution {
    public int SingleNumber(int[] nums) {
        int ans = 0;
        foreach (int num in nums) {
            ans ^= num;
        }
        return ans;       
    }
}
