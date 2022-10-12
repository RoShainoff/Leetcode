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
    public ListNode ReverseList(ListNode head) { 
        var dummyHead = new ListNode();
        
        while (head != null)
        {
            var next = head.next;
            head.next = dummyHead.next;
            
            dummyHead.next = head;
            head = next;
        }
        
        return dummyHead.next;
    }
}
