using System;
using System.Collections.Generic;
using System.Text;

namespace CubanLinx
{

    class Node
    {
        public int val;
        public Node next;

        public Node(int val=0)
        {
            this.val = val;
        }
    }
    class LinkedList
    {
        public Node head;

        public Node first;
        public Node last;

        public LinkedList(Node head = null)
        {
            this.head = head;
            first = null ;
            last = null;


            
        }
        
     
        

        public void AddToFront(int val)
        {
            Node node = new Node();
            node.val = val;
            Node pointer = head;
            if (head == null)
            {
                head = node;
               
            }
            else
            {
                head = node;
                head.next = pointer;
              

            }


        }
        public void AddToLinkedList(int val)
        {
            if (head == null)
            {
                Node newNode = new Node();
                newNode.val = val;
                this.AddToFront(newNode.val);
            }
            else
            {
                Node pointer = new Node();

                while (pointer.next != null)
                {
                    pointer = pointer.next;
                }
                Node newNode = new Node();
                newNode.val = val;
                pointer = newNode;
            }

        }
        public void AddAt(int index)
        {

            Node newNode = new Node();

            if (index == 0)
            {

            }
        }

        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                //deletes old head and replaces it with node at head.next
                head = head.next;
            }

            Node runner = head;

            for (int i = 0; i < index - 1; i++)
            {
                runner = runner.next;
                if (runner.next == null)
                {
                    throw new NullReferenceException();
                }
                else
                {

                    Node newNode = runner.next.next;
                    runner.next = newNode;
                }

            }
        }

        public int Count()
        {
            int count = 0;
           
            if (this.head != null)
            {
                count++;
            }
            Node pointerNode = head;
            while (pointerNode.next != null)
            {
                count++;
            }
            return count;
        }

        public void ReplaceNodeWith(Node nodeToReplace, Node replacementNode)
        {
            Node pointer = this.head;

           for(int i = 0; i < this.Count(); i++)
            {
                if (pointer == nodeToReplace)
                {
                    pointer.val = replacementNode.val;
                }
            }

        }

        public LinkedList MergeInBetween(LinkedList list1, int a, int b, LinkedList list2)
        {
            int count=0;
            Node headNode = new Node();
            Node twoPointer = list2.head;
            if (list1.head == null)
            {
                list1.head = headNode;
            }
            Node pointerNode = list1.head;
            do
            {
                pointerNode = pointerNode.next;
                count++;
            } while (count != a);

            for (int i = a; i < b; i++)
            {
                pointerNode.val = twoPointer.val;
                twoPointer = twoPointer.next;


            }
            LinkedList answer = new LinkedList();
            answer.head = list1.head;
            answer.last = twoPointer;
            return answer;

        }

    }



}

