using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string t = textBox2.Text;

            string[] slova = s.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);


            foreach (string slovo in slova)
            {
                char posledni = slovo[slovo.Length - 1];

                if (t.Contains(posledni))
                {
                    listBox1.Items.Add(slovo);
                }
            }

        }
    }
}
