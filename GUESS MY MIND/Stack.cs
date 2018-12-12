using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    public class Stack
    {
        public Node Head;

        public Stack()
        {
            Head = null;
        }


        public void push(BTNode value)
        {
            Node Current = new Node(value);
            Node temp = Head;
            Current.next = temp;
            Head = Current;
        }

        public BTNode pop()
        {

            if (IsEmpty() == false)
            {
                BTNode temp = Head.data;
                Head = Head.next;
                return temp;
            }
            return null;
        }

        public BTNode peek()
        {
            if (IsEmpty() == false)
            {
                BTNode temp = Head.data;
                Head = Head.next;
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

        public void Display()
        {
            Node temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
