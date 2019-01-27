/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 *
 * https://leetcode.com/problems/reverse-integer/description/
 *
 * algorithms
 * Easy (24.96%)
 * Total Accepted:    581.2K
 * Total Submissions: 2.3M
 * Testcase Example:  '123'
 *
 * Given a 32-bit signed integer, reverse digits of an integer.
 * 
 * Example 1:
 * 
 * 
 * Input: 123
 * Output: 321
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: -123
 * Output: -321
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: 120
 * Output: 21
 * 
 * 
 * Note:
 * Assume we are dealing with an environment which could only store integers
 * within the 32-bit signed integer range: [−231,  231 − 1]. For the purpose of
 * this problem, assume that your function returns 0 when the reversed integer
 * overflows.
 * 
 */
public class Solution {
    public int Reverse(int x) {
        var temp =x;
        var output = 0;
        while(temp!=0){
            var digit = temp%10;
            try{
                output = checked((output*10)+digit);
            }
            catch(OverflowException e) {
                return 0;
            }
            temp = temp/10;
        }
        return output;
    }
}
