using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    public class NodeQueue
    {

        public string data;
        public NodeQueue next;

        public NodeQueue()
        {
            data = null;
            next = null;
        }


        public NodeQueue(string value)
        {
            data = value;
            next = null;
        }
    }
}
