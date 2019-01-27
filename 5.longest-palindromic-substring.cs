/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 *
 * https://leetcode.com/problems/longest-palindromic-substring/description/
 *
 * algorithms
 * Medium (26.06%)
 * Total Accepted:    451.9K
 * Total Submissions: 1.7M
 * Testcase Example:  '"babad"'
 *
 * Given a string s, find the longest palindromic substring in s. You may
 * assume that the maximum length of s is 1000.
 * 
 * Example 1:
 * 
 * 
 * Input: "babad"
 * Output: "bab"
 * Note: "aba" is also a valid answer.
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: "cbbd"
 * Output: "bb"
 * 
 * 
 */
public class Solution {
    // this is a Dynamic programming solution
    // memoize the base case and then expand
    public string LongestPalindrome(string s) {
        if(s.Length==0)
            return s;

        if(s.Length==1)
            return s;
        var n = s.Length;
        //mac number of combinations is 1000*1000
        var palMarker = new bool[1000][];
        var startingIndex = 0;
        var maxLength = 1;
        // all one characters are palindromes
        for(int i=0;i<n;i++) {
            palMarker[i]=new bool[1000];
            palMarker[i][i]=true;
        }
        //two characters are palindrome if they are equal
        for(int i=0;i<n-1;i++){
            if(s[i]==s[i+1]){
                palMarker[i][i+1]=true;
                startingIndex = i;
                maxLength=2;
            }
        }
        //now mark all other case 2+
        //first len 3 then 4 then 5
        for(int len=3;len<=n;len++) {
            //start from 0, base case of 1, and 2 should already be marked
            for(int i=0;i<n-len+1;i++){
                //charcter from other side
                var j = i+len-1;
                if(s[i]==s[j] && palMarker[i+1][j-1]){
                    palMarker[i][j]=true;
                    startingIndex = i;
                    maxLength=len;
                }
            }

        }

        Console.WriteLine(s);
        Console.WriteLine(startingIndex);
        Console.WriteLine(maxLength);
        return s.Substring(startingIndex,maxLength);

    }
}
