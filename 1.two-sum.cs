/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 *
 * https://leetcode.com/problems/two-sum/description/
 *
 * algorithms
 * Easy (39.85%)
 * Total Accepted:    1.3M
 * Total Submissions: 3.3M
 * Testcase Example:  '[2,7,11,15]\n9'
 *
 * Given an array of integers, return indices of the two numbers such that they
 * add up to a specific target.
 * 
 * You may assume that each input would have exactly one solution, and you may
 * not use the same element twice.
 * 
 * Example:
 * 
 * 
 * Given nums = [2, 7, 11, 15], target = 9,
 * 
 * Because nums[0] + nums[1] = 2 + 7 = 9,
 * return [0, 1].
 * 
 * 
 * 
 * 
 */
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var i =0;
        var indexVal = new Dictionary<int,int>();
        while(i<nums.Length) {
            int complement = target-nums[i];
            if(indexVal.ContainsKey(complement))
                return new int[] {indexVal[complement],i};
            if(indexVal.ContainsKey(nums[i]))
                indexVal[nums[i]]=i;
            else
                indexVal.Add(nums[i],i);
            i++;
        }
        return null;


    }
}
