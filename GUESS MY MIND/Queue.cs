using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    public class Queue
    {
        public NodeQueue Head;
        public NodeQueue Tail;
        public Queue()
        {
            Head = null;
            Tail = null;
        }


        public void Enqueue(string value)
        {
            NodeQueue temp = new NodeQueue(value);

            if (IsEmpty())
            {
                Head = temp;
            }
            else
            {
                Tail.next = temp;
            }
            Tail = temp;
            Tail.next = null;
        }

        public string Dequeue()
        {

            if (IsEmpty() == false)
            {
                string temp = Head.data;
                Head = Head.next;
                return temp;
            }
            return null;
        }
        public string peek()
        {


            if (IsEmpty() == false)
            {
                string temp = Head.data;

                return temp;
            }
            return null;
        }


        public bool IsEmpty()
        {
            if (Head == null)
                return true;
            else
                return false;
        }


    }
}
