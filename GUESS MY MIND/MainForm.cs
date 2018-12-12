using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//label1 use to show a question that is read from tree
//label2 just display a question no text
//label3 show a ques no that increment after ques
//button1 for yes tree
//button2 for no tree
namespace Guessing_Game
{
    public partial class MainForm : Form
    {
        BinaryTreeGame Game;
        BTNode TempRoot;
        String q; // just to hold question string of Node
        int count = 1;
        bool status = false;
        public MainForm()
        {

            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            
            InitializeComponent();
            t.Abort();
            Game = new BinaryTreeGame();
            
        }

        public void SplashScreen()
        {
            Application.Run(new SplashScreen());
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
           
            Game.start();
            TempRoot = Game.Roots;
            q = TempRoot.GetQuestion();
            MakeQues();
            label2.Text = "Question No:";
        }
       
        public void MakeQues()
        {
            
            label3.Text = Convert.ToString(count);
            label1.Text = " ";
            label1.Text = q;
        }
        
        public void MakePrediction()//when no node and yes node are null 
        {
            status = true;
            label2.Visible = false;
            label3.Visible = false;
            label1.Text = " ";
            label1.Text = "Are you thinking of a " + q + "?";
        }
        
        private void label2_Click(object sender, EventArgs e)
        {
            //QUESTION NO:
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NO BUTTON
            if (status == false)
            {
                TempRoot = TempRoot.GetNoNode();
                if (TempRoot.IsPrediction())
                {

                    q = TempRoot.GetQuestion();
                    MakeQues();
                }
                else
                {
                    q = TempRoot.GetQuestion();
                    MakePrediction();
                }
            }
            else
            {
                this.Hide();
                UpdateknowledgeScreen t = new UpdateknowledgeScreen(TempRoot);
                t.ShowDialog();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //YES BUTTON
            if (status == false)
            {
                count++;
                TempRoot = TempRoot.GetYesNode();
                if (TempRoot.IsPrediction())
                {

                    q = TempRoot.GetQuestion();
                    MakeQues();
                }
                else
                {
                    q = TempRoot.GetQuestion();
                    MakePrediction();
                }
            }
            else
            {
                this.Hide();
                WinningForm t = new WinningForm(0);
                t.ShowDialog();

            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //QUESTION BOX
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        
    }
}
