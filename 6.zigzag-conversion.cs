/*
 * @lc app=leetcode id=6 lang=csharp
 *
 * [6] ZigZag Conversion
 *
 * https://leetcode.com/problems/zigzag-conversion/description/
 *
 * algorithms
 * Medium (30.04%)
 * Total Accepted:    275.9K
 * Total Submissions: 914.2K
 * Testcase Example:  '"PAYPALISHIRING"\n3'
 *
 * The string "PAYPALISHIRING" is written in a zigzag pattern on a given number
 * of rows like this: (you may want to display this pattern in a fixed font for
 * better legibility)
 * 
 * 
 * P   A   H   N
 * A P L S I I G
 * Y   I   R
 * 
 * 
 * And then read line by line: "PAHNAPLSIIGYIR"
 * 
 * Write the code that will take a string and make this conversion given a
 * number of rows:
 * 
 * 
 * string convert(string s, int numRows);
 * 
 * Example 1:
 * 
 * 
 * Input: s = "PAYPALISHIRING", numRows = 3
 * Output: "PAHNAPLSIIGYIR"
 * 
 * 
 * Example 2:
 * 
 * 
 * Input: s = "PAYPALISHIRING", numRows = 4
 * Output: "PINALSIGYAHRPI"
 * Explanation:
 * 
 * P     I    N
 * A   L S  I G
 * Y A   H R
 * P     I
 * 
 */
public class Solution {
    public string Convert(string input, int numRows) {
        if(numRows==1)
            return input;
        var exception = numRows%2 ==0 ? numRows : numRows-1;
        var n = input.Length;
        var pass = 0;
        var character = 0;
        var looper =0;
        var totalJump = 2*numRows-2;
        var output = new char[n];
        while (looper<n){
            output[looper] = input[character];
            // Console.WriteLine(character);
            if(pass%(numRows-1)!=0){
                if(character+exception<n-1 && looper<n-1) {
                    looper++;
                    //Console.WriteLine(character);
                    //Console.WriteLine(exception);
                    // Console.WriteLine("reading and adding from exception");
                    // Console.WriteLine(character+exception);
                    // Console.WriteLine("----------------");
                    //Console.WriteLine(new string(output));
                    output[looper]=input[character+exception];
                }
            }
            else {
                pass = 0;
                exception = numRows%2 ==0 ? numRows : numRows-1;
            }
            character += totalJump;
            if(character > n-1) {
                // Console.WriteLine("Pass changing");
                // Console.WriteLine("Current Pass");
                // Console.WriteLine(pass);
                pass++;
                // Console.WriteLine("New Pass");
                // Console.WriteLine(pass);
                character = pass;
                if(pass>1)
                    exception = exception/2;
            }
            looper++;
        }
        return new string(output);

    }
}
