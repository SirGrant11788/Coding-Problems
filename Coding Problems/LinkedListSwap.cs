using System;
using System.Collections.Generic;
using System.Text;

namespace Coding_Problems
{

    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    public class LinkedListSwap
    {
        Node head; // head of list  

        /* Function to swap Nodes x and y in   
        linked list by changing links */
        public void swapNodes(int x, int y)
        {
            // Nothing to do if x and y are same  
            if (x == y) return;

            // Search for x (keep track of prevX and CurrX)  
            Node prevX = null, currX = head;
            while (currX != null && currX.data != x)
            {
                prevX = currX;
                currX = currX.next;
            }

            // Search for y (keep track of prevY and currY)  
            Node prevY = null, currY = head;
            while (currY != null && currY.data != y)
            {
                prevY = currY;
                currY = currY.next;
            }

            // If either x or y is not present, nothing to do  
            if (currX == null || currY == null)
                return;

            // If x is not head of linked list  
            if (prevX != null)
                prevX.next = currY;
            else //make y the new head  
                head = currY;

            // If y is not head of linked list  
            if (prevY != null)
                prevY.next = currX;
            else // make x the new head  
                head = currX;

            // Swap next pointers  
            Node temp = currX.next;
            currX.next = currY.next;
            currY.next = temp;
        }

        /* Function to add Node at beginning of list. */
        public void push(int new_data)
        {
            /* 1. alloc the Node and put the data */
            Node new_Node = new Node(new_data);

            /* 2. Make next of new Node as head */
            new_Node.next = head;

            /* 3. Move the head to point to new Node */
            head = new_Node;
        }

        /* This function prints contents of linked list  
        starting from the given Node */
        public void printList()
        {
            Node tNode = head;
            while (tNode != null)
            {
                Console.Write(tNode.data + " ");
                tNode = tNode.next;
            }
        }
        public static void Swap()
        {
            LinkedListSwap llist = new LinkedListSwap();
            //testing
            // Adding elements in the LinkedList 
            // Using AddLast() method 
            llist.push(4);
            llist.push(3);
            llist.push(2);
            llist.push(1);
            Console.Write("\n Linked list before calling swapNodes() ");
            llist.printList();

            llist.swapNodes(2, 1);
            llist.swapNodes(4, 3);

            Console.Write("\n Linked list after calling swapNodes() ");
            llist.printList();

        }
    }
}
