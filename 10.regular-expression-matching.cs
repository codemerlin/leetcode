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
        if(s.Length==0 && p.Length==0)
            return true;
        if(s.Length!=0 && p.Length==0)
            return false;
        if(s.Length==1 && p.Length==1 && (p[0]==s[0] || p[0]=='.'))
            return true;
        if(p.Length==1 && p[0]=='*' && s.Length==0)
            return true;

        var si = 0;
        var pi = 0;
        char? prevChar = null;
        var patternMatched = false;
        var starProcessing = false;

        while(si<s.Length || pi<p.Length) {
            if(pi>1 && p[pi]=='*') 
                prevChar = p[pi-1];
            // both match or pattern is a .
            if(s[si]==p[pi] || p[pi]=='.') {
                si++;
                pi++;
                patternMatched = true;
            }
            if(p[pi]=='*') {
                if(prevChar ==null)
                    return false;

                if(prevChar == '.'){
                    si++;
                    patternMatched = true;
                }
                else {
                    if(prevChar == s[si]) {
                        si++;
                        patternMatched = true;
                        starProcessing = true;
                    }
                    else {
                        if (starProcessing) {
                            pi++;
                            starProcessing = false;
                            prevChar = null;
                        }
                        else {
                            pi++;
                            prevChar = null;
                            return false;
                        }
                        
                    }

                }

            }
            else {
                return false;
            }

        }


        return patternMatched;

        
        
    }
}
