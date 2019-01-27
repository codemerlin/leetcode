/*
 * @lc app=leetcode id=4 lang=csharp
 *
 * [4] Median of Two Sorted Arrays
 *
 * https://leetcode.com/problems/median-of-two-sorted-arrays/description/
 *
 * algorithms
 * Hard (25.07%)
 * Total Accepted:    366.4K
 * Total Submissions: 1.5M
 * Testcase Example:  '[1,3]\n[2]'
 *
 * There are two sorted arrays nums1 and nums2 of size m and n respectively.
 * 
 * Find the median of the two sorted arrays. The overall run time complexity
 * should be O(log (m+n)).
 * 
 * You may assume nums1 and nums2 cannot be both empty.
 * 
 * Example 1:
 * 
 * 
 * nums1 = [1, 3]
 * nums2 = [2]
 * 
 * The median is 2.0
 * 
 * 
 * Example 2:
 * 
 * 
 * nums1 = [1, 2]
 * nums2 = [3, 4]
 * 
 * The median is (2 + 3)/2 = 2.5
 * 
 * 
 */
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var i=0;
        var j=0;
        var k=0;
        var output = new int[nums1.Length+nums2.Length];
        while(i<nums1.Length && j<nums2.Length) {
            if(nums1[i]<nums2[j]){
                output[k]=nums1[i];
                k++;
                i++;
            }
            else {
                if(nums1[i]>nums2[j]){
                    output[k]=nums2[j];
                    k++;
                    j++;
                }
                else {
                    output[k]=nums1[i];
                    k++;
                    output[k]=nums2[j];
                    k++;
                    i++;
                    j++;
                }

            }
            if (k==((nums1.Length+nums2.Length)/2)+1) {
                break; 
            }


        }
        while(j==nums2.Length && i<nums1.Length){
            output[k]=nums1[i];
            k++;
            i++;
            if (k==((nums1.Length+nums2.Length)/2)+1) {
                break; 
            }
        }
        while(i==nums1.Length && j<nums2.Length){
            output[k]=nums2[j];
            k++;
            j++;
            if (k==((nums1.Length+nums2.Length)/2)+1) {
                break;
            }
        }
        var medianIndex =(nums1.Length+nums2.Length)/2;
        if((nums1.Length+nums2.Length)%2==0){
            return (output[medianIndex-1]+output[medianIndex])/2.0;
        }
        else {
            return Convert.ToDouble(output[medianIndex]);
        }

        return 0;

    }
}
