/*
 * @lc app=leetcode id=17 lang=csharp
 *
 * [17] Letter Combinations of a Phone Number
 *
 * https://leetcode.com/problems/letter-combinations-of-a-phone-number/description/
 *
 * algorithms
 * Medium (40.02%)
 * Total Accepted:    337.1K
 * Total Submissions: 842.2K
 * Testcase Example:  '"23"'
 *
 * Given a string containing digits from 2-9 inclusive, return all possible
 * letter combinations that the number could represent.
 * 
 * A mapping of digit to letters (just like on the telephone buttons) is given
 * below. Note that 1 does not map to any letters.
 * 
 * 
 * 
 * Example:
 * 
 * 
 * Input: "23"
 * Output: ["ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf"].
 * 
 * 
 * Note:
 * 
 * Although the above answer is in lexicographical order, your answer could be
 * in any order you want.
 * 
 */
public class Solution {
    private List<string> result = new List<string>();
    private Dictionary<char,List<char>> map = new Dictionary<char,List<char>>() {
            {'2', new List<char>() {'a','b','c'}},
            {'3', new List<char>() {'d','e','f'}},
            {'4', new List<char>() {'g','h','i'}},
            {'5', new List<char>() {'j','k','l'}},
            {'6', new List<char>() {'m','n','o'}},
            {'7', new List<char>() {'p','q','r','s'}},
            {'8', new List<char>() {'t','u','v'}},
            {'9', new List<char>() {'w','x','y', 'z'}},
        };

    public IList<string> LetterCombinations(string digits) {
        return  LetterCombinationsBruteForce(digits);
    }

    private IList<string> LetterCombinationsBruteForce(string digits) {
        // this uses memoization
        var i =0; 
        var allCombos = new List<String>();
        while(i<digits.Length) {
            allCombos = getAllCombos(allCombos,map[digits[i]]);
            i++;
        }
        return allCombos;
    }

    private List<string> getAllCombos(List<string> allCombos,List<char> newcharcters) {
        if(allCombos.Count ==0) {
            return newcharcters.Select(i=>i.ToString()).ToList(); 
        }

        var newCombos = new List<String>();
        foreach(var str in allCombos) {
            foreach(var newchar in newcharcters) {
                newCombos.Add(str+newchar.ToString());
            }
        }
        return newCombos;
    } 
}