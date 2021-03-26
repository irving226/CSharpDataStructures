using System;
using static CubanLinx.LinkedList;

namespace CubanLinx
{
    class Program
    {
        static void Main(string[] args)
        {
          
            ListNode nodeZero = new ListNode(0);
         
            ListNode nodeOne = new ListNode(1);
            ListNode nodeTwo = new ListNode(2);
            ListNode nodeThree = new ListNode(3);
            ListNode nodeFour = new ListNode(4);
            ListNode nodeFive = new ListNode(5);

            ListNode list1 = nodeZero;
            list1.next = nodeOne;
            nodeOne.next = nodeTwo;
            nodeTwo.next = nodeThree;
            nodeThree.next = nodeFour;
            nodeFour.next = nodeFive;

            int a = 3;
            int b = 4;

            ListNode list2 = new ListNode(1000000);
            ListNode secNodeZero = new ListNode(1000001);
            ListNode secNodeOne = new ListNode(1000002);
            list2.next = secNodeZero;
            secNodeZero.next = secNodeOne;
            list1.MergeInBetween(list1, a, b, list2);



            
        }
    }
}
