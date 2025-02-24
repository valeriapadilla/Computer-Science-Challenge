public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        ListNode modelList = new ListNode(0);
        modelList.next = head;
        ListNode prevLeft = modelList;

        for(int i=1;i<left;i++){
            prevLeft = prevLeft.next;
        };

        ListNode startNode = prevLeft.next;
        ListNode nextNode = startNode.next;

        for(int i=1; i<=right-left;i++){
            startNode.next = nextNode.next;
            nextNode.next = prevLeft.next;
            prevLeft.next = nextNode;
            nextNode =  startNode.next;
        };
        return modelList.next;
        
    }
}
