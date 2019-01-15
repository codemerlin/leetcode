/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 *
 * https://leetcode.com/problems/add-two-numbers/description/
 *
 * algorithms
 * Medium (30.14%)
 * Total Accepted:    712.7K
 * Total Submissions: 2.4M * Testcase Example:  '[2,4,3]\n[5,6,4]'
 *
 * You are given two non-empty linked lists representing two non-negative
 * integers. The digits are stored in reverse order and each of their nodes
 * contain a single digit. Add the two numbers and return it as a linked list.
 * 
 * You may assume the two numbers do not contain any leading zero, except the
 * number 0 itself.
 * 
 * Example:
 * 
 * 
 * Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
 * Output: 7 -> 0 -> 8
 * Explanation: 342 + 465 = 807.
 * 
 * 
 */
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var l1Ptr = l1;
        var l2Ptr = l2;
        var carry = 0;
        ListNode resultHead = null;
        ListNode resultCurrent = null;
        while(l1Ptr!=null || l2Ptr!=null) {
            var tempValue = 0;
            if(l1Ptr == null && l2Ptr !=null) {
                tempValue = l2Ptr.val+carry;
                l2Ptr = l2Ptr.next;
            }
            if(l2Ptr == null && l1Ptr !=null) {
                tempValue = l1Ptr.val+carry;
                l1Ptr = l1Ptr.next;
            }
            if(l2Ptr != null && l1Ptr !=null) {
                tempValue = l2Ptr.val + l1Ptr.val+carry;
                l1Ptr = l1Ptr.next;
                l2Ptr = l2Ptr.next;
            }
            carry = tempValue/10;
            var currentSum = new ListNode(tempValue%10);
            if(resultHead==null) {
                resultHead = currentSum;
                resultCurrent = resultHead;
            }
            else {
                resultCurrent.next = currentSum;
                resultCurrent = currentSum;
            }

        }
        if(carry!=0 && l1Ptr == null && l2Ptr == null) {
            var currentSum = new ListNode(carry);
            resultCurrent.next = currentSum;
            resultCurrent = currentSum;
        }

        return resultHead;

    }
}
