//-----------------------------------------------------------------------------
// Runtime: 79ms
// Memory Usage: 37.4 MB
// Link: https://leetcode.com/submissions/detail/821534951/
//-----------------------------------------------------------------------------
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        var fast = head;
        var slow = head;

        while (fast?.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        return slow;
    }
}
