using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int count = 0;
            List<string> list = new List<string>();

            if (textBox5.Text == "")
            {
                MessageBox.Show("Введите вопрос");
                return;
            }
            if (textBox1.Text != "")
            {
                count++;
            }
            if (textBox2.Text != "")
            {
                count++;
            }
            if (textBox3.Text != "")
            {
                count++;
            }
            if (textBox4.Text != "")
            {
                count++;
            }
            if (count < 2)
            {
                MessageBox.Show("Введите как минимум 2 ответа на вопрос");
                return;
            }
            int count2 = 0;
            if (checkBox1.Checked)
            {
                if (textBox1.Text != "")
                {
                    count2++;
                }
                else
                {
                    MessageBox.Show("Пустой ответ не может являться правильным");
                    return;
                }
            }
            if (checkBox2.Checked)
            {
                if (textBox2.Text != "")
                {
                    count2++;
                }
                else
                {
                    MessageBox.Show("Пустой ответ не может являться правильным");
                    return;
                }
            }
            if (checkBox3.Checked)
            {
                if (textBox3.Text != "")
                {
                    count2++;
                }
                else
                {
                    MessageBox.Show("Пустой ответ не может являться правильным");
                    return;
                }
            }
            if (checkBox4.Checked)
            {
                if (textBox4.Text != "")
                {
                    count2++;
                }
                else
                {
                    MessageBox.Show("Пустой ответ не может являться правильным");
                    return;
                }
            }
            if (count2 > count - 1 || count2 == 0)
            {
                MessageBox.Show("Необходимо ометить галочкой как минимум 1 правильный ответ, количество правильных ответов не может быть равно количеству ответов");
                return;
            }
            MessageBox.Show("Вопрос добавлен");

            list.Add(textBox5.Text);
            list.Add(textBox1.Text);
            list.Add(checkBox1.Checked.ToString());
            list.Add(textBox2.Text);
            list.Add(checkBox2.Checked.ToString());
            list.Add(textBox3.Text);
            list.Add(checkBox3.Checked.ToString());
            list.Add(textBox4.Text);
            list.Add(checkBox4.Checked.ToString());

            foreach (var item in list)
            {
                if (item != "")
                {
                    if (item == "True")
                    {
                        label6.Text += item.ToString();
                    }
                    if(item != "True" && item != "False")
                    {
                        label6.Text += "\n";
                        label6.Text += item.ToString();
                    }
                }   
            }

            string q = label6.Text;

            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = null;   //сброс для 
            checkBox1.Checked = checkBox2.Checked = checkBox3.Checked = checkBox4.Checked = false;  //последующего вопроса
        }

        private void back_Click(object sender, EventArgs e)
        {

        }
    }
}
