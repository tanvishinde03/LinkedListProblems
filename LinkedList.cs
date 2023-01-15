using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkdinListProblems
{
    public class LinkedList
    {
        internal Nodes head;
        public  void Addlast(int data)
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
            Console.WriteLine("{0} is inserted in to Linked list", newNode.data);
        }
        public void Display()
        {
            Console.WriteLine("Display of Nodes");
            Nodes temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write("" + temp.data + " ");
                    temp = temp.next;

                }
            }
        }
    }




























}

