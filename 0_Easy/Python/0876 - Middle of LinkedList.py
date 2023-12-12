# Definition for singly-linked list.
class ListNode(object):
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next
class Solution(object):
    def middleNode(self, head):
        """
        :type head: ListNode
        :rtype: ListNode
        """
        fast_node = head
        slow_node = head
        while fast_node != None:
            fast_node = fast_node.next
            if fast_node != None:
                fast_node = fast_node.next
                slow_node = slow_node.next
        return slow_node
        