public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode currentHead = head;
        ListNode prevNode = null;
        ListNode nextNode;

        while(currentHead != null){
            nextNode = currentHead.next;
            currentHead.next = prevNode;
            prevNode = currentHead;
            currentHead = nextNode;
        }
        return prevNode;
        
    }
}
