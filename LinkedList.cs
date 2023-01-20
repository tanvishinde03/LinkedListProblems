using LinkdinListProblems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LinkedListUCs;


namespace LinkdinList
{
    public class LinkedList
    {
        internal Nodes head;
        internal void Addlast(int data)
        {
            Nodes newNode = new Nodes(data);

            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Nodes temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
            Console.WriteLine("{0} is inserted in to Linked list Last position", newNode.data);
        }
        public void Display()
        {
            Console.WriteLine("Display of Nodes");
            Nodes temp = this.head;
            int pos = 1;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine("position :" + pos + "Data" + temp.data + "\n");
                    temp = temp.next;
                }
            }
        }
        public void AddAtfirst(int data)
        {
            Nodes newNode1 = new Nodes(data);
            newNode1.next = head;
            head = newNode1;
            Console.WriteLine("{0} is inserted to the Linked List at first position ", newNode1.data);
        }

        internal void InsertBetween(int previous, int data, int after)
        {
            Nodes temp = head;
            Nodes newNode = new Nodes(data);
            Nodes store;
            while (temp != null)
            {
                if (temp.data == previous && temp.next.data == after)
                {
                    store = temp.next;
                    temp.next.next = newNode;
                    newNode = store;
                }
                else
                {
                    temp = temp.next;

                }
            }
        }
        internal Nodes DeleteFirstNode(int data)
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            Console.WriteLine("Element First{0} Is Removed", data);
            return this.head;
        }

        internal Nodes DeleteLastNode(int data)
        {
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                return null;
            }
            Nodes temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
            Console.WriteLine("Last Element {0} Is Removed", data);
            return this.head;
        }
        internal void Search(int data)
        {
            Nodes temp = head;
            while (temp != null)
            {
                if (temp.data == data)
                {
                    Console.WriteLine("The node {0} is found.", temp.data);
                    return;
                }
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("\nThe Node {0} is not found in the linked list.", data);
            }


        }
    }
}

























