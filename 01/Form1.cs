using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string[] retezce = new string[textBox1.Lines.Length];
            int p = 0;
            foreach (string s in textBox1.Lines)
            {
                if (s[0] >= 'a' && s[0] <= 'z')
                {
                    string slovo = char.ToUpper(s[0]) + s.Substring(1) + ".";
                    slovo = slovo.Trim();
                    retezce[p] = slovo;
                }
                else
                {
                    string slovo = s + ".";
                    slovo = slovo.Trim();
                    retezce[p] = slovo;
                }
                p++;
            }

            textBox1.Clear();

            textBox1.Lines = retezce;
        }
    }
}
