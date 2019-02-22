using AlgorithmsLibrary.DataStructures;
using System.Collections;

namespace AlgorithmsLibrary.LinkedLists
{
    /// <summary>
    /// 
    /// </summary>
    public class LinkedListOperatons
    {
        /// <summary>
        /// Reverse a singly linked list.
        ///     Example:
        ///     Input: 1->2->3->4->5->NULL
        ///     Output: 5->4->3->2->1->NULL
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.Next == null)
                return head;

            ListNode curr = head;
            ListNode prev = null;

            while (curr != null)
            {
                ListNode next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }

        /// <summary>
        /// ReverseList Recursive
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode ReverseListRecursive(ListNode head)
        {
            if (head == null || head.Next == null)
                return head;

            //get second node    
            ListNode second = head.Next;
            //set first's next to be null
            head.Next = null;

            ListNode rest = ReverseListRecursive(second);
            second.Next = head;

            return rest;
        }

        /// <summary>
        /// Detect cycle in LL
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle(ListNode head)
        {

            if (head == null || head.Next == null)
                return false;

            ListNode fast = head.Next;
            ListNode slow = head;

            while (fast != null && fast.Next != null)
            {

                if (fast == slow)
                    return true;
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return false;
        }

        /// <summary>
        /// Check if the list is Palindrome using extra space
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.Next == null)
                return true;

            ArrayList aList = new ArrayList();

            while (head != null)
            {
                aList.Add(head.Val);
                head = head.Next;
            }

            for (int i = 0; i < aList.Count / 2; i++)
            {
                if ((int)aList[i] != (int)aList[aList.Count - 1 - i])
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Method -2  
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool IsPalindrome2(ListNode head)
        {
            if (head == null || head.Next == null)
                return true;

            ListNode half = getMiddlNodeAndReverseFirstHalf(ref head);

            while (half != null && head != null)
            {
                if (half.Val != head.Val)
                    return false;
                half = half.Next;
                head = head.Next;
            }

            return true;
        }

        private ListNode getMiddlNodeAndReverseFirstHalf(ref ListNode head)
        {
            if (head == null)
                return head;

            ListNode slow = head;
            ListNode fast = head;
            ListNode prev = null, next = null;
            ListNode curr = head;

            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;

                //reverse first half
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;

            if (fast != null)
                slow = slow.Next;

            return slow;
        }
    }
}
