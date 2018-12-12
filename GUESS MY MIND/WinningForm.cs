using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class WinningForm : Form
    {
        int t;
        public WinningForm(int t)
        {
            InitializeComponent();
            this.t=t;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WinningForm_Load(object sender, EventArgs e)
        {
            if(t!=0)
            {
                label2.Visible = false;
                label1.Text="Thank you!! \nMy knowledge has been increased";
            }
        }
    }
}
