using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    public class Node
    {

        public BTNode data;
        public Node next;

        public Node()
        {
            data = null;
            next = null;
        }


        public Node(BTNode value)
        {
            data = value;
            next = null;
        }

    }
}
