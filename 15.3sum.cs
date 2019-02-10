/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 *
 * https://leetcode.com/problems/3sum/description/
 *
 * algorithms
 * Medium (23.05%)
 * Total Accepted:    468.3K
 * Total Submissions: 2M
 * Testcase Example:  '[-1,0,1,2,-1,-4]'
 *
 * Given an array nums of n integers, are there elements a, b, c in nums such
 * that a + b + c = 0? Find all unique triplets in the array which gives the
 * sum of zero.
 * 
 * Note:
 * 
 * The solution set must not contain duplicate triplets.
 * 
 * Example:
 * 
 * 
 * Given array nums = [-1, 0, 1, 2, -1, -4],
 * 
 * A solution set is:
 * [
 * ⁠ [-1, 0, 1],
 * ⁠ [-1, -1, 2]
 * ]
 * 
 * 
 */
public class Solution {
    private string GetBasicHash(List<int> combo) {
        var output = "";
        foreach(var s in combo) {
            output+=s.ToString();
        }
        return output;
    }
    public IList<IList<int>> ThreeSum(int[] nums) {
        var unique =new List<string>();

        IList<IList<int>> output = new List<IList<int>>();

        for(var i=nums.Length-1; i>=0 ;i--) {
            for(var j=i-1; j>=0 ;j--) {
                for(var k=j-1; k>=0 ;k--) {
                    if(nums[i]+nums[j]+nums[k] ==0) {
                        var smallest = new List<int>() {nums[i],nums[j],nums[k]};
                        smallest.Sort();
                        var uniqueHash = GetBasicHash(smallest);
                        if(!unique.Contains(uniqueHash)) {
                            unique.Add(uniqueHash);
                            output.Add(smallest);
                        }
                    }
                }
            }
        }

        return output;
    }
}
