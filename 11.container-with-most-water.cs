/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 *
 * https://leetcode.com/problems/container-with-most-water/description/
 *
 * algorithms
 * Medium (41.88%)
 * Total Accepted:    304.7K
 * Total Submissions: 727.4K
 * Testcase Example:  '[1,8,6,2,5,4,8,3,7]'
 *
 * Given n non-negative integers a1, a2, ..., an , where each represents a
 * point at coordinate (i, ai). n vertical lines are drawn such that the two
 * endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together
 * with x-axis forms a container, such that the container contains the most
 * water.
 * 
 * Note: You may not slant the container and n is at least 2.
 * 
 * 
 * 
 * 
 * 
 * The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In
 * this case, the max area of water (blue section) the container can contain is
 * 49. 
 * 
 * 
 * 
 * Example:
 * 
 * 
 * Input: [1,8,6,2,5,4,8,3,7]
 * Output: 49
 * 
 */
public class Solution {
    public int MaxArea(int[] height) {
        return MaxAreaBruteForce(height);
    }

    private int MaxAreaBruteForce(int[] height) {

        var currentMax = 0;
        for(int i=0;i<height.Length;i++) {
            for(int j=i+1;j<height.Length;j++) {
                var newArea = ((height[i] < height[j]) ? height[i] : height[j]) * (j-i);
                currentMax = (currentMax < newArea) ? newArea : currentMax;


            }
        }
       return currentMax; 
    }
}
