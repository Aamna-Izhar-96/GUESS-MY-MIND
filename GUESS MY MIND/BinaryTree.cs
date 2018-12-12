using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Guessing_Game
{
    public class BinaryTreeGame
    {
        public BTNode Roots;
        
        public BinaryTreeGame()
        {
            Roots = new BTNode();
            
        }
        public void start()
        {
            this.ReadBinaryTree();
        }
        public void WriteBinaryTree()
        {
            StreamWriter write = new StreamWriter(@"Questions.txt");

            Queue data = PreOrderWrite();
            while (!data.IsEmpty())
            {
                write.WriteLine(data.Dequeue());
            }
            write.Close();
        }

        public Queue PreOrderWrite()
        {
            if (Roots == null)
            {
                return null;
            }

            Stack stack = new Stack();
            Queue output = new Queue();
            stack.push(Roots);

            while (!stack.IsEmpty())
            {

                BTNode temp = stack.pop();
                output.Enqueue(temp.GetQuestion());

                if (temp.GetYesNode() != null)
                {
                    stack.push(temp.GetYesNode());
                }
                else
                {
                    output.Enqueue("x");
                }
                if (temp.GetNoNode() != null)
                {
                    stack.push(temp.GetNoNode());
                }
                else
                {
                    output.Enqueue("x");
                }

            }
            return output;
        }


        public void ReadBinaryTree()
        {
            StreamReader Read = new StreamReader(@"Questions.txt");
            Queue input = new Queue();
            while (true)
            {
                string temp = Read.ReadLine();
                if (temp == null)
                {
                    break;
                }
                input.Enqueue(temp);
            }
            Read.Close();
            Roots = PreOrderRead(Roots, input);
        }

        public BTNode PreOrderRead(BTNode Root, Queue input)
        {
            if (input.IsEmpty())
            {
                return null;
            }

            if (input.peek() == "x")
            {
                input.Dequeue();
                return null;
            }
            Root = new BTNode(input.Dequeue());
            Root.NoNode = PreOrderRead(Root.NoNode, input);
            Root.YesNode = PreOrderRead(Root.YesNode, input);
            return Root;
        }

        public void PreOrderDisplay(BTNode Root)
        {
            if (Root == null)
            { return; }

            Console.WriteLine(Root.GetQuestion());
            PreOrderDisplay(Root.GetYesNode());
            PreOrderDisplay(Root.GetNoNode());
        }


    }



}

