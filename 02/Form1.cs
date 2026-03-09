using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retezec = textBox1.Text;
            string samohlasky = "aeiyouáéíóůú";
            string souhlasky = "qwrtzplkjhgfdaxcvbnmščřžťň";
            int samo = 0;
            int sou = 0;
            int c = 0;
            int ostatni = 0;
            foreach (char ch in retezec)
            {
                if (samohlasky.Contains(ch))
                {
                    samo++;
                }
                else if (souhlasky.Contains(ch)) 
                {
                    sou++;
                }
                else if (char.IsNumber(ch))
                {
                    c++;
                }
                else
                {
                    ostatni++;
                }
            }

            MessageBox.Show($"Samohlasek je ve slove {samo}, souhlasek je {sou}, čísel {c} a ostatnich znaku je {ostatni}");
        }
    }
}
