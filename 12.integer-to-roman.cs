/*
 * @lc app=leetcode id=12 lang=csharp
 *
 * [12] Integer to Roman
 *
 * https://leetcode.com/problems/integer-to-roman/description/
 *
 * algorithms
 * Medium (49.41%)
 * Total Accepted:    197.3K
 * Total Submissions: 399.2K
 * Testcase Example:  '3'
 *
 * Roman numerals are represented by seven different symbols: I, V, X, L, C, D
 * and M.
 * 
 * 
 * Symbol       Value
 * I             1
 * V             5
 * X             10
 * L             50
 * C             100
 * D             500
 * M             1000
 * 
 * For example, two is written as II in Roman numeral, just two one's added
 * together. Twelve is written as, XII, which is simply X + II. The number
 * twenty seven is written as XXVII, which is XX + V + II.
 * 
 * Roman numerals are usually written largest to smallest from left to right.
 * However, the numeral for four is not IIII. Instead, the number four is
 * written as IV. Because the one is before the five we subtract it making
 * four. The same principle applies to the number nine, which is written as IX.
 * There are six instances where subtraction is used:
 * 
 * 
 * I can be placed before V (5) and X (10) to make 4 and 9. 
 * X can be placed before L (50) and C (100) to make 40 and 90. 
 * C can be placed before D (500) and M (1000) to make 400 and 900.
 * 
 * 
 * Given an integer, convert it to a roman numeral. Input is guaranteed to be
 * within the range from 1 to 3999.
 * 
 * Example 1:
 * 
 * 
 * Input: 3
 * Output: "III"
 * 
 * Example 2:
 * 
 * 
 * Input: 4
 * Output: "IV"
 * 
 * Example 3:
 * 
 * 
 * Input: 9
 * Output: "IX"
 * 
 * Example 4:
 * 
 * 
 * Input: 58
 * Output: "LVIII"
 * Explanation: L = 50, V = 5, III = 3.
 * 
 * 
 * Example 5:
 * 
 * 
 * Input: 1994
 * Output: "MCMXCIV"
 * Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 * 
 */
public class Solution {
    public string IntToRoman(int num) 
    {
        return IntToRomanFlat(num);

    }


    private string IntToRomanFlat(int n) {
        var M = new string[] {"", "M", "MM", "MMM"};											// ["", 1000, 2000, 3000]
        var C = new string[] {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};		// ["", 100, 200, 300, 400, 500, 600, 700, 800, 900]
        var X = new string[] {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};		// ["", 10, 20, 30, 40, 50, 60, 70, 80, 90]
        var I = new string[] {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};		// ["", 1, 2, 3, 4, 5, 6, 7, 8, 9]
        return M[n / 1000] + C[(n % 1000) / 100] + X[(n % 100) / 10] + I[n % 10];
    }
    private string IntToRomanLoop(int num) {
        var values = new List<int>() {
            1,
            2,
            3,
                4,
                5,
                6,
                7,
                8,
                9,
                10,
                40,
                50,
                90,
                100,
                400,
                500,
                900,
                1000,

        };
        var charcters = new List<string>() {
            "I",
            "II",
            "III",
                "IV",
                "V",
                "VI",
                "VII",
                "VIII",
                "IX",
                "X",
                "XL",
                "L",
                "XC",
                "C",
                "CD",
                "D",
                "CM",
                "M",
        };

        var temp = num;
        var result = "";
        var index=values.Count-1;
        var qt=0;
        while(temp !=0) {
            qt=0;
            while(qt<=0) {
                qt = temp/values[index];
                index--;
            }
            index++;
            result += charcters[index];
            temp = temp - values[index];

        }
        return result;

    }
}
