/*
 * @lc app=leetcode id=10 lang=csharp
 *
 * [10] Regular Expression Matching
 *
 * https://leetcode.com/problems/regular-expression-matching/description/
 *
 * algorithms
 * Hard (24.83%)
 * Total Accepted:    268.1K
 * Total Submissions: 1.1M
 * Testcase Example:  '"aa"\n"a"'
 *
 * Given an input string (s) and a pattern (p), implement regular expression
 * matching with support for '.' and '*'.
 * 
 * 
 * '.' Matches any single character.
 * '*' Matches zero or more of the preceding element.
 * 
 * 
 * The matching should cover the entire input string (not partial).
 * 
 * Note:
 * 
 * 
 * s could be empty and contains only lowercase letters a-z.
 * p could be empty and contains only lowercase letters a-z, and characters
 * like . or *.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input:
 * s = "aa"
 * p = "a"
 * Output: false
 * Explanation: "a" does not match the entire string "aa".
 * 
 * 
 * Example 2:
 * 
 * 
 * Input:
 * s = "aa"
 * p = "a*"
 * Output: true
 * Explanation: '*' means zero or more of the precedeng element, 'a'.
 * Therefore, by repeating 'a' once, it becomes "aa".
 * 
 * 
 * Example 3:
 * 
 * 
 * Input:
 * s = "ab"
 * p = ".*"
 * Output: true
 * Explanation: ".*" means "zero or more (*) of any character (.)".
 * 
 * 
 * Example 4:
 * 
 * 
 * Input:
 * s = "aab"
 * p = "c*a*b"
 * Output: true
 * Explanation: c can be repeated 0 times, a can be repeated 1 time. Therefore
 * it matches "aab".
 * 
 * 
 * Example 5:
 * 
 * 
 * Input:
 * s = "mississippi"
 * p = "mis*is*p*."
 * Output: false
 * 
 * 
 */
public class Solution {
    public bool IsMatch(string s, string p) {
        
        return this.IsMatchDp(s,p);
        
    }
    
    private bool IsMatchDp(string s, string p) {
      var dp = new bool[s.Length+1,p.Length+1];
      dp[s.Length,p.Length] = true;

      for(int i=s.Length; i>=0; i--) {
          for(int j=p.Length; j>=0; j--) {
              var firstMatch = i < s.Length && 
                                (p[j] == s[i] || p[i] =='.');
              if(j=1 < p.Length && p[j+1] == '*') {
                  dp[i,j] = dp[i,j+2] || firstMatch && dp[i+1,j];
              } else {
                  dp[i,j] = firstMatch && dp[i+1,j+1];
              } 

          }
      }

      return dp[0][0];

    }

    // basically a pattern matches if substings match
    private bool IsMatchRecursive(string s, string p) {
        if (string.IsNullOrEmpty(p)) return string.IsNullOrEmpty(s);
        var firstMatch = (!string.IsNullOrEmpty(s) && 
                        (p[0] == s[0] || p[0] == '.'));
        if(p.Length >=2 && p[1] == '*') {
            return this.IsMatchRecursive(s,p.Substring(2)) 
                || (firstMatch && this.IsMatchRecursive(s.Substring(1),p));
        

        }
        else {
            return firstMatch && this.IsMatchRecursive(s.Substring(1),p.Substring(1));
        }
    }
}
