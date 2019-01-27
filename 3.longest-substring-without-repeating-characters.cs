/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 *
 * https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
 *
 * algorithms
 * Medium (25.84%)
 * Total Accepted:    704.4K
 * Total Submissions: 2.7M
 * Testcase Example:  '"abcabcbb"'
 *
 * Given a string, find the length of the longest substring without repeating
 * characters.
 * 
 * 
 * Example 1:
 * 
 * 
 * Input: "abcabcbb"
 * Output: 3 
 * Explanation: The answer is "abc", with the length of 3. 
 * 
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: "bbbbb"
 * Output: 1
 * Explanation: The answer is "b", with the length of 1.
 * 
 * 
 * 
 * Example 3:
 * 
 * 
 * Input: "pwwkew"
 * Output: 3
 * Explanation: The answer is "wke", with the length of 3. 
 * ⁠            Note that the answer must be a substring, "pwke" is a
 * subsequence and not a substring.
 * 
 * 
 * 
 * 
 * 
 */
public class Solution {
    private List<string> filterStringsWithOnlyUnique(List<string> input) {
        var results = new List<string>();
        foreach(var str in input){
            if(isStringMadeOfUniqueChars(str))
                results.Add(str);
        }
        return results;
    }
    private bool isStringMadeOfUniqueChars(string s) {
        var i=0;
        while(i<s.Length){
            var j=i+1;
            while(j<s.Length){
                if(s[i]==s[j]){
                    return false;
                }
                j++;
            }
            i++;
        }
        return true;
    }
    private string getSubstring(string s,int startIndex,int len){
        var start = startIndex;
        var end = startIndex+len;
        var output = "";
        while(start<end && start<s.Length) {
            output+=s[start];
            start++;
        }
        return output;
    }

    private List<string> getAllSubstringsOfLength(string s,int len){
        var start=0;
        var results=new List<string>();
        while(start<s.Length) {
            results.Add(getSubstring(s,start,len));
            start++;
        }
        return results;
    }

    private int getMaxLength(string input,int currentPass,int lastMax){
        var allSubstrings= getAllSubstringsOfLength(input,currentPass);
        var filteredSubstrings = filterStringsWithOnlyUnique(allSubstrings);
        foreach(var str in filteredSubstrings){
            // Console.WriteLine(str);
            if(str.Length>lastMax)
                return str.Length;
        }
        return lastMax;

    }
    public int LengthOfLongestSubstring(string s) {
        if(s.Length==0)
            return 0;
        var i=1;
        var max=1;
        while(i<=s.Length){
            max= getMaxLength(s,i,max);
            i++;

        }
        return max;

    }
}

