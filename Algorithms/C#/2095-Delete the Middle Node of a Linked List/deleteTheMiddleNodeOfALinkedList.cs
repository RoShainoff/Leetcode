//-----------------------------------------------------------------------------
// Runtime: 735ms
// Memory Usage: 53.1 MB
// Link: https://leetcode.com/submissions/detail/822319420/
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
    public ListNode DeleteMiddle(ListNode head) {
        
        if(head?.next == null){
            return null;
        }
        
        var count = 0;
        
        var slow = head;
        var fast = head;
        
        while(fast?.next != null){
            count++;
            fast = fast.next.next;
            slow = slow.next;
        }
        
        var dummyHead = head;
        
        while (count-- > 1) {
            head = head.next;
        }
 
        // Delete the middle node
        head.next = head?.next?.next;
        
        return dummyHead;
    }
}
