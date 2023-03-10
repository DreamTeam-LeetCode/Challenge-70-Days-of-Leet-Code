public class Solution {
    public ListNode MiddleNode(ListNode head) {
        ListNode final = head, middle = head;
        while(final?.next is not null)
        {
            final = final.next.next;
            middle = middle.next;
        }
        return middle;
    }
}
