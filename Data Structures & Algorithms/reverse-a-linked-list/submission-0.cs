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
        if(head==null)
        {
            return null;
        }
        ListNode s = head;
        ListNode f = s.next;
        head.next=null;
        while(f!=null)
        {
            ListNode temp = f.next;
            f.next = s;
            s = f;
            f = temp;
        }
        return s;
    }
}
