/*
 * @lc app=leetcode id=231 lang=csharp
 *
 * [231] Power of Two
 *
 * https://leetcode.com/problems/power-of-two/description/
 *
 * algorithms
 * Easy (42.00%)
 * Total Accepted:    230.8K
 * Total Submissions: 549.5K
 * Testcase Example:  '1'
 *
 * Given an integer, write a function to determine if it is a power of two.
 * 
 * Example 1:
 * 
 * 
 * Input: 1
 * Output: true 
 * Explanation: 20 = 1
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: 16
 * Output: true
 * Explanation: 24 = 16
 * 
 * Example 3:
 * 
 * 
 * Input: 218
 * Output: false
 * 
 */
public class Solution {
  public bool IsPowerOfTwo(int n) {
        if (n <= 0) return false;  // 2^n is always positive. 
        return (n & (n - 1) )== 0;  // bit manipulation trick
    }}
