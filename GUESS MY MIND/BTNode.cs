using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    public class BTNode
    {
        private string question;
        public BTNode NoNode;
        public BTNode YesNode;

        public BTNode(string ques)
        {
            question = ques;

        }

        public BTNode()
        {
            question = null;
            NoNode = null;
            YesNode = null;
        }

        public void SetYesNode(BTNode node)
        {
            this.YesNode = node;
        }
        public void SetNoNode(BTNode node)
        {
            this.NoNode = node;
        }

        public BTNode GetYesNode()
        {
            return this.YesNode;
        }

        public BTNode GetNoNode()
        {
            return this.NoNode;
        }
        public string GetQuestion()
        {
            return this.question;
        }

        public void SetQuestion(string ques)
        {
            question = ques;
        }
        public bool IsPrediction()
        {
            if (NoNode == null && YesNode == null)
                return false;
            else
                return true;
        }
    }

}
