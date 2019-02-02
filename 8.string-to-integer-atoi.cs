/*
 * @lc app=leetcode id=8 lang=csharp
 *
 * [8] String to Integer (atoi)
 *
 * https://leetcode.com/problems/string-to-integer-atoi/description/
 *
 * algorithms
 * Medium (14.39%)
 * Total Accepted:    315.1K
 * Total Submissions: 2.2M
 * Testcase Example:  '"42"'
 *
 * Implement atoi which converts a string to an integer.
 * 
 * The function first discards as many whitespace characters as necessary until
 * the first non-whitespace character is found. Then, starting from this
 * character, takes an optional initial plus or minus sign followed by as many
 * numerical digits as possible, and interprets them as a numerical value.
 * 
 * The string can contain additional characters after those that form the
 * integral number, which are ignored and have no effect on the behavior of
 * this function.
 * 
 * If the first sequence of non-whitespace characters in str is not a valid
 * integral number, or if no such sequence exists because either str is empty
 * or it contains only whitespace characters, no conversion is performed.
 * 
 * If no valid conversion could be performed, a zero value is returned.
 * 
 * Note:
 * 
 * 
 * Only the space character ' ' is considered as whitespace character.
 * Assume we are dealing with an environment which could only store integers
 * within the 32-bit signed integer range: [−231,  231 − 1]. If the numerical
 * value is out of the range of representable values, INT_MAX (231 − 1) or
 * INT_MIN (−231) is returned.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: "42"
 * Output: 42
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: "   -42"
 * Output: -42
 * Explanation: The first non-whitespace character is '-', which is the minus
 * sign.
 * Then take as many numerical digits as possible, which gets 42.
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: "4193 with words"
 * Output: 4193
 * Explanation: Conversion stops at digit '3' as the next character is not a
 * numerical digit.
 * 
 * 
 * Example 4:
 * 
 * 
 * Input: "words and 987"
 * Output: 0
* Explanation: The first non-whitespace character is 'w', which is not a
* numerical 
* digit or a +/- sign. Therefore no valid conversion could be performed.
* 
* Example 5:
* 
* 
* Input: "-91283472332"
* Output: -2147483648
* Explanation: The number "-91283472332" is out of the range of a 32-bit
* signed integer.
* Thefore INT_MIN (−231) is returned.
* 
*/
public class Solution {
    public int MyAtoi(string str) {
       str = str.Trim();
        var x = str.Length;
        var output = 0; 
        var isNegative = false;
        var symbolHitOnce = false;
        var processingStarted = false;
        if (x==0) {
            return 0;
        }
        var firstChar= (int)str[0];
        // space or minus or plus
        var i = 1;
        if(firstChar==45||firstChar==43 || firstChar >=48 && firstChar<=57) {
            isNegative = firstChar == 45;
            if(firstChar >=48 && firstChar<=57)
                i = 0;
        }
        else
            return 0;

        while(i<x) {
            var cc = (int)str[i];
            i++;
            if(cc >=48 && cc<=57) {
                try{
                    processingStarted = true;
                    output = checked(output*10+(cc-48));
                    continue;
                }
                catch(OverflowException) {
                    return isNegative ? int.MinValue : int.MaxValue;
                }
            }
            break;
        }
        return isNegative ? output*-1 : output;
    }
}
