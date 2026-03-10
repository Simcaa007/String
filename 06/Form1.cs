using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string vys;

        private void button1_Click(object sender, EventArgs e)
        {
            vys = "";
            foreach (char ch in textBox1.Text)
            {
                if (!(ch >= 'A' && ch <= 'Z'))
                {
                    vys += ch;
                }
            }
            MessageBox.Show(vys);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vys = vys.Replace("*", "");
            MessageBox.Show(vys);

        }
    }
}
