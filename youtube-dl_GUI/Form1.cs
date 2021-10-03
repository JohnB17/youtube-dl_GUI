using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace youtube_dl_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ytUrl = textBox1.Text;
            string strCmdText;
            strCmdText = $"/C youtube-dl.exe {ytUrl} && pause";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }
    }
}
