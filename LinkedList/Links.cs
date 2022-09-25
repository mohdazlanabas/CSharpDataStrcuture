using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Links
    {
        public Node First { get; set; }
        public void InsertFirst(int data)
        {
            // CREATE THE HEAD
            // INSERT
            // Create New Node
            Node newNode = new Node();
            // Put the data in the node
            newNode.Data = data;
            // Put the old node in next
            newNode.Next = First;
            // Make the head the new node
            First = newNode;
        }
        // DELETE
        public Node DeleteFirst()
        {
            // Assigna temp variable
            Node temp = First;
            // Assign the next head
            First = First.Next;
            return temp;
        }
        public void DisplayList()
        {
            Console.WriteLine("Iterating thru List....");
            Node current = First;
            while(current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
        }
        public void InsertLast(int data)
        {
            Node current = First;
            while(current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
        }
    }
}
