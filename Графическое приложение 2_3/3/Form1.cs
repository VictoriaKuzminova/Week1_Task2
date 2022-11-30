using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        private int kol_vo=10;
        private float x;
        private int str;
        public Form1()
        {
            InitializeComponent();
        }

        private void res_button_Click(object sender, EventArgs e)
        {
            if(price_TextBox.Text==""|| kol_TextBox.Text == "")
            {
                MessageBox.Show("Введены не все значения!");
            }
            else
            {
                do_while_TextBox.Text = "";
                for_TextBox.Text = "";
                while_TextBox.Text = "";



                try
                {
                    x = float.Parse(price_TextBox.Text);
                    if (x <= 0)
                    {
                        MessageBox.Show("Цена не может быть меньше или равна 0!");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!");
                    return;
                }
                try
                {
                    str = int.Parse(kol_TextBox.Text);
                    if ((str <= 0) || (str > 10))
                    {
                        MessageBox.Show("Количество строк не может принимать данное значение");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!");
                    return;
                }
                while (kol_vo <= str * 10)
                {

                    while_TextBox.Text += "Количество " + kol_vo + "  стоят " +( kol_vo * x) + " руб\n";
                    kol_vo = kol_vo + 10;
                }
                kol_vo = 10;
                do
                {
                    do_while_TextBox.Text += "Количество " + kol_vo + "  стоят " + (kol_vo * x)+ " руб\n";
                    kol_vo += 10;
                } while (kol_vo <= str * 10);
                kol_vo = 10;


                for (int i = 10; i <= str * 10; i += 10)
                {
                    for_TextBox.Text += "Количество " + i + "  стоят " + (i * x) + " руб\n";
                }
            }

        }
    }
 }

