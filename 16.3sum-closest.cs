/*
 * @lc app=leetcode id=16 lang=csharp
 *
 * [16] 3Sum Closest
 *
 * https://leetcode.com/problems/3sum-closest/description/
 *
 * algorithms
 * Medium (33.86%)
 * Total Accepted:    233.9K
 * Total Submissions: 690.6K
 * Testcase Example:  '[-1,2,1,-4]\n1'
 *
 * Given an array nums of n integers and an integer target, find three integers
 * in nums such that the sum is closest to target. Return the sum of the three
 * integers. You may assume that each input would have exactly one solution.
 * 
 * Example:
 * 
 * 
 * Given array nums = [-1, 2, 1, -4], and target = 1.
 * 
 * The sum that is closest to the target is 2. (-1 + 2 + 1 = 2).
 * 
 * 
 */
public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        return ThreeSumImproved(nums,target);

    }
    private int ThreeSumImproved(int[] num, int target) {
        // this is based on 
        //https://leetcode.com/problems/3sum/discuss/7380/Concise-O(N2)-Java-solution 
        // and https://leetcode.com/problems/3sum/discuss/7380/Concise-O(N2)-Java-solution/209811
        int result = num[0] + num[1] + num[num.Length -1 ];
        var sorted = num.ToList();
        sorted.Sort();
        num = sorted.ToArray();
        for (int i =0; i< num.Length - 2; i++) {
            var lo = i +1;
            var hi = num.Length -1 ;
            while(lo<hi) {
                var sum =num[i]+num[lo]+num[hi];
                if(sum <= target) {
                    lo++;
                }
                else {
                    hi--;
                }
                if(Math.Abs(sum-target) < Math.Abs(result-target)) {
                    result = sum;
                }
           }
        }
        return result;
    }
}
