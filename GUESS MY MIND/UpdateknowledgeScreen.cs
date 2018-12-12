using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//label1 //you will win what are u thinking of?
  //and
//label1 "Please enter a question to distinguish a " + TRoot.GetQuestion() + " From " + UserAnswer;
//button 1 for ok
// button2 for yes
//button3 for no
//textbox1 //use to take a user object
//label3 "If you were thinking of a " + UserAnswer + ", \nwhat would the answer to that question be?";
namespace Guessing_Game
{
    public partial class UpdateknowledgeScreen : Form
    {
        int count = 0; //just to change label
        BinaryTreeGame Game;
        BTNode TRoot;
        string UserAnswer;
        string UserQuestion;
        public UpdateknowledgeScreen(BTNode root)
        {
            InitializeComponent();
            Game = new BinaryTreeGame();
            TRoot = root;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //you will win what are u thinking of?
        }

        private void UpdateknowledgeScreen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //use to take a user object
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {//ok button
            

            if (count == 0)
            {
                UserAnswer = textBox1.Text.ToString();
                label1.Text = "Please enter a question to distinguish a " + TRoot.GetQuestion() + " From " + UserAnswer;
                textBox1.Text = " ";
            }
            
            if (count == 1)
            {
                label3.Text = "If you were thinking of a " + UserAnswer + ", \nwhat would the answer to that question be?";
                UserQuestion = textBox1.Text.ToString();
                textBox1.Visible = false;
                label1.Visible = false;
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
            }
                count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonfunctions(this.button2);
            this.Hide();
            WinningForm t = new WinningForm(1);
            t.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonfunctions(this.button3);
            this.Hide();
            WinningForm t = new WinningForm(1);
            t.ShowDialog();
        }

        public void buttonfunctions(Button a)
        {
            BTNode current = AddingRoot();
            if (a == button3)
            {
                current.SetYesNode(new BTNode(TRoot.GetQuestion()));
                current.SetNoNode(new BTNode(UserAnswer));
            }
            else
            {
                current.SetNoNode(new BTNode(TRoot.GetQuestion()));
                current.SetYesNode(new BTNode(UserAnswer));
            }
            current.SetQuestion(UserQuestion);
            Game.WriteBinaryTree();//write a tree on file using stack and queue

        }
    
        public BTNode AddingRoot()
        {//adding root for new yes or no node or question
            Game.start();
            Queue<BTNode> queue=new Queue<BTNode>();
            queue.Enqueue(Game.Roots);
            
            while(queue.Count>0)
            {
                BTNode t=queue.Dequeue();
               if(t.GetQuestion()==TRoot.GetQuestion())
               {
                   return t;
               }
                if(t.GetYesNode()!=null)
                queue.Enqueue(t.GetYesNode());
                if (t.GetNoNode() != null)
                queue.Enqueue(t.GetNoNode());
            }
            return null;
        }

        
    }
}
