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
        RootWord rt = new RootWord(0, 10);
        public MainForm()
        {
            InitializeComponent();
           
        }
    }
}
