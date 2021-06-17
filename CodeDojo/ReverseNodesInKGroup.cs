using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeDojo
{
    public partial class Solution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null) return head;
            var stacks = new List<Stack<ListNode>>();
            var stack = new Stack<ListNode>();
            int count = 0;
            while (head != null)
            {
                count++;
                stack.Push(head);
                if (count == k)
                {
                    count = 0;
                    stacks.Add(new Stack<ListNode>(stack.Reverse()));
                    stack.Clear();
                }
                head = head.next;
            }
            if(stack.Count > 0) stacks.Add(new Stack<ListNode>(stack));
            head = stacks[0].Peek();
            for (int i = 0; i < stacks.Count; i++)
            {
                stack = stacks[i];
                if (stack.Count == k)
                {
                    for (int j = 0; j < k; j++)
                    {
                        stack.Pop().next = j < k - 1 ? stack.Peek() :
                            i < stacks.Count - 1 ? stacks[i + 1].Peek() : null;
                    }
                }
            }
            return head;
        }
    }
}
