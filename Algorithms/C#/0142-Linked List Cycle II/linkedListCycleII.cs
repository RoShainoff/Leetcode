/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        var set = new HashSet<ListNode>();
        
        for (ListNode i = head; i != null && i.next != null; i = i.next)
        {            
            if(!set.Contains(i))
                set.Add(i);
            else
                return i;
        }
        
        return null;
    }
}
