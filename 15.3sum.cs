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
    public IList<IList<int>> ThreeSum(int[] nums) {
        //  return ThreeSumBruteForce(nums);
        return ThreeSumImproved(nums);
    }


    private IList<IList<int>> ThreeSumImproved(int[] num) {
        // this is based on 
        //https://leetcode.com/problems/3sum/discuss/7380/Concise-O(N2)-Java-solution 
        // and https://leetcode.com/problems/3sum/discuss/7380/Concise-O(N2)-Java-solution/209811
        var sorted = num.ToList();
        sorted.Sort();
        num = sorted.ToArray();
        IList<IList<int>> output = new List<IList<int>>();
        for (int i = 0; i < num.Length-2 && num[i]<=0; i++) {
            if (i == 0 ||  num[i] != num[i-1]) {
                if (num[i] + num[i+1] + num[i+2] > 0) break;
                var lo = i+1;
                var hi = num.Length-1;
                while (lo < hi) {
                    int sum = num[i] + num[lo] + num[hi];
                    if(sum<0) {
                        lo++;
                    }
                    else if (sum>0) {
                        hi--;
                    }
                    else if (sum ==0 ) {
                        output.Add(new List<int>(){num[i], num[lo], num[hi]});
                        while (lo < hi && num[lo] == num[lo+1]) lo++;
                        while (lo < hi && num[hi] == num[hi-1]) hi--;
                        lo++; 
                        hi--;
                    }
                }
            }
        }
        return output;
    }

    private string GetBasicHash(List<int> combo) {
        var output = "";
        foreach(var s in combo) {
            output+=s.ToString();
        }
        return output;
    }
    private IList<IList<int>> ThreeSumBruteForce(int[] nums) {
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
