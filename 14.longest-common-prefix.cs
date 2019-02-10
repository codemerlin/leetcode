/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 *
 * https://leetcode.com/problems/longest-common-prefix/description/
 *
 * algorithms
 * Easy (32.83%)
 * Total Accepted:    397.9K
 * Total Submissions: 1.2M
 * Testcase Example:  '["flower","flow","flight"]'
 *
 * Write a function to find the longest common prefix string amongst an array
 * of strings.
 * 
 * If there is no common prefix, return an empty string "".
 * 
 * Example 1:
 * 
 * 
 * Input: ["flower","flow","flight"]
 * Output: "fl"
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: ["dog","racecar","car"]
 * Output: ""
 * Explanation: There is no common prefix among the input strings.
 * 
 * 
 * Note:
 * 
 * All given inputs are in lowercase letters a-z.
 * 
 */
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length ==0) {
            return "";
        }
        // calculate min length to loop on
        var min= strs[0].Length;
        foreach(var s in strs) {
            min = min < s.Length ? min : s.Length;
        }
        var j=0;
        while(j<min) {
         var charAtJMatchs = true;
         var nextChar=strs[0][j];
         foreach(var s in strs) {
             if(!charAtJMatchs)
                 break;
             charAtJMatchs = charAtJMatchs && nextChar == s[j];
         }
         if(!charAtJMatchs)
             return strs[0].Substring(0,j);
         j++;
        }
        return strs[0].Substring(0,j);
        
    }
}
