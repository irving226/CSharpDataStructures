using System;
using System.Collections.Generic;
using System.Text;

namespace CubanLinx
{
    class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {

            //leetcode protection
            if (list1 == null)
            {
                ListNode nodeOne = new ListNode();
            }

            if (list2 == null)
            {
                ListNode nodeTwo = new ListNode();
            }

            if (a == 0 && b == 0)
            {
                return list2;
            }
            ListNode endNodes = list1;


            int count = 0;
            while (count < b)
            {
                ListNode pointer = endNodes;

                while (pointer.next != null)
                {
                    pointer = pointer.next;
                    count++;
                    if (count > b)
                    {
                        break;
                    }

                }

                endNodes = pointer;
            }
            ListNode PointerTwo = list2;
            while (PointerTwo.next != null)
            {
                PointerTwo = PointerTwo.next;
            }
            PointerTwo.next = endNodes;

            count = 0;
            ListNode pointerOne = list1;

            while (count != a - 1)
            {
                pointerOne = pointerOne.next;
                count++;
            }
            pointerOne.next = list2;


            return list1;

            //}
        }
    }
}