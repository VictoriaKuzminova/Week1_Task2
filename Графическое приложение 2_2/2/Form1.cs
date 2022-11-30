using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        private int kol_vo_day;
        public Form1()
        {
            InitializeComponent();
        }

        private void Res_button_Click(object sender, EventArgs e)
        {
            if (day_TextBox.Text == "")
            {
                MessageBox.Show("Введены не все значения!");
            }
            else
            {
                try
                {
                    kol_vo_day = int.Parse(day_TextBox.Text);
                    if (kol_vo_day < 0)
                    {
                        MessageBox.Show("Количество не может быть меньше 0");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Некорректный ввод!");
                    return;
                }
                
                DateTime start = new DateTime(1990, 1, 1);
                DateTime finish = start.AddDays(kol_vo_day); //добавляем дни
                int month = finish.Month; //получаем месяцы
                string s_month = "";
                switch (month)
                {
                    case 1: s_month = "Январь"; break;
                    case 2: s_month = "Февраль"; break;
                    case 3: s_month = "Март"; break;
                    case 4: s_month = "Апрель"; break;
                    case 5: s_month = "Май"; break;
                    case 6: s_month = "Июнь"; break;
                    case 7: s_month = "Июль"; break;
                    case 8: s_month = "Август"; break;
                    case 9: s_month = "Сентябрь"; break;
                    case 10: s_month = "Октябрь"; break;
                    case 11: s_month = "Ноябрь"; break;
                    case 12: s_month = "Декабрь"; break;
                }
                res_TextBox.Text=s_month;
            }
        }
    }
}
