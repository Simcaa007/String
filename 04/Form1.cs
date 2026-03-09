using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Odstran(string retezec)
        {
            int pocet = 0;
            foreach (char ch in retezec)
            {
                if (ch >= '0' && ch <= '9')
                {
                    pocet = ch - '0';
                }
            }

            string vys = retezec.Remove(pocet - 1);
            return vys;
        }

        string Vem(string retezec)
        {
            int pocet = 0;
            foreach (char ch in retezec)
            {
                if (ch >= '0' && ch <= '9')
                {
                    pocet = ch - '0';
                }
            }

            int v = retezec.Length - pocet;

            string vys = retezec.Take(v);
            return vys;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retezec = textBox1.Text;

            MessageBox.Show($"{Odstran(retezec)}");
        }
    }
}
