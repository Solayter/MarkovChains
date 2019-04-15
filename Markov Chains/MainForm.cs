using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Markov_Chains
{
    public partial class MainForm : Form
    {
        Logics logics;
        public MainForm()
        {
            InitializeComponent();
            logics = new Logics(30);
            
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            string[] str;
            string[] output = new string[] { "", "", "" };
            if (input.EndsWith(" "))
            {
                str = input.Split(' ');

                output = logics.FindNextWords(str[0], str[str.Length - 2]);
            }
            if(output == null)
                output = new string[] { "", "", "" };
            buttonWordFirst.Text = output[0];
            buttonWordSecond.Text = output[1];
            buttonWordThird.Text = output[2];
            
        }

        private void buttonWordFirst_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonWordFirst.Text + " ";
        }

        private void buttonWordSecond_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonWordSecond.Text + " ";
        }

        private void buttonWordThird_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonWordThird.Text + " ";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            string[] str;
            int sym = 0;

            if (input.EndsWith(" "))
                sym = 2;
            else
                sym = 1;

            str = input.Split(' ');
            for (int i = 0; i < str.Length - sym; i++)
            {
                logics.AddNewRoot(str[0]);
                logics.AddNewChains(str[0], str[i], str[i + 1]);
            }
            textBoxInput.Text = "";
        }
    }
}
