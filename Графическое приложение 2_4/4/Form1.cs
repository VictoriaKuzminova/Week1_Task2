using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void res_button_Click(object sender, EventArgs e)
        {
            res_textBox.Text = "";
            int j;
            int a = 1;
            for (int i = 1; i <= 5; ++i,res_textBox.Text+=" "+ "\n")
            {
                for (j = 1; j <= a; j++)
                {
                    res_textBox.Text+= "       " + i;
                }
                a++;
            }

        }
    }
}
