# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        prev, curr = None, head
        while curr:
            temp = curr.next
            curr.next = prev
            prev = curr
            curr = temp
        return prev

    # my own written logic
    # def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
    #     if head is None:
    #         return None

    #     if head.next is None:
    #         return head

    #     start = head
    #     end = head.next

    #     while end is not None:
    #         temp = end.next
    #         #start.next = None
    #         end.next = start
    #         start = end
    #         end = temp

    #     head.next = None
    #     return start
