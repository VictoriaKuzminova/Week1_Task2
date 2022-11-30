using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        private float x;
        private float y;
        public Form1()
        {
            InitializeComponent();
        }

        private void X_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowSymbol = "-,\b";
            if (!allowSymbol.Contains(e.KeyChar) && !char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void Y_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowSymbol = "-,\b";
            if (!allowSymbol.Contains(e.KeyChar) && !char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void res_Button_Click(object sender, EventArgs e)
        {
            if (X_textBox.Text == "" || Y_textBox.Text == "")
            {
                MessageBox.Show("Введены не все данные");
            }
            else
            {
                x = float.Parse(X_textBox.Text);
                y = float.Parse(Y_textBox.Text);
                if (y >= Math.Abs(x) && x * x + y * y <= 225)
                {
                    if (y > Math.Abs(x) && x * x + y * y < 225)
                        res_TextBox.Text = "Да";
                    else
                        res_TextBox.Text = "На границе";
                }
                else
                    res_TextBox.Text = "Нет";
            }
        }
    }
}
