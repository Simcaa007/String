using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string s in textBox1.Lines)
            {
                string vys = "";
                string[] casti = s.Split('-');
                string cisla = casti[1];
                foreach (char ch in casti[0])
                {
                    vys += char.ToUpper(ch);
                }

                vys += '-';

                if (cisla.Length > 6)
                {
                    vys += cisla.Substring(0, 6);
                }
                else if (cisla.Length == 6)
                {
                    vys += cisla;
                }
                else
                {
                    int l = cisla.Length;
                    switch (l)
                    {
                        case 0: vys += "000000"; break;
                        case 1: vys += cisla + "00000"; break;
                        case 2: vys += cisla + "0000"; break;
                        case 3: vys += cisla + "000"; break;
                        case 4: vys += cisla + "00"; break;
                        case 5: vys += cisla + "0"; break;
                    }
                }

                listBox1.Items.Add(vys);
            }
        }
    }
}
