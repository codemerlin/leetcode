/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 *
 * https://leetcode.com/problems/palindrome-number/description/
 *
 * algorithms
 * Easy (41.38%)
 * Total Accepted:    490.4K
 * Total Submissions: 1.2M
 * Testcase Example:  '121'
 *
 * Determine whether an integer is a palindrome. An integer is a palindrome
 * when it reads the same backward as forward.
 * 
 * Example 1:
 * 
 * 
 * Input: 121
 * Output: true
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: -121
 * Output: false
 * Explanation: From left to right, it reads -121. From right to left, it
 * becomes 121-. Therefore it is not a palindrome.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: 10
 * Output: false
 * Explanation: Reads 01 from right to left. Therefore it is not a
 * palindrome.
 * 
 * 
 * Follow up:
 * 
 * Coud you solve it without converting the integer to a string?
 * 
 */
public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
            return false;

        //reverse number and then compare it 


            int reverse = 0;
            var temp = x;
            while(temp!=0) {
                var digit = temp % 10;
                reverse = reverse*10 + digit;
                temp = temp/10;
            }

            return reverse == x;



    }


}
