/* Two Sum
 * 
 * [Easy] [AC:39.8% 1.3M of 3.3M] [filetype:csharp]
 * 
 * Given an array of integers, return indices of the two numbers
 * such that they add up to a specific target.
 * 
 * You may assume that each input would have exactly one solution,
 * and you may not use the same element twice.
 * 
 * Example:
 * 
 * Given nums = [2, 7, 11, 15], target = 9,
 * 
 * Because nums[0] + nums[1] = 2 + 7 = 9,
 * 
 * return [0, 1].
 * 
 * [End of Description] */
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var i =0;
        while(i<nums.Length) {
            var j=i+1;
            while(j<nums.Length) {
                if(nums[i]+nums[j]==target)
                    return new int[] {i,j};
                j++;
            }
            i++;
        }
        return null;


    }
}
