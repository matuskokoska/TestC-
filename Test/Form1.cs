using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double score, total;
            score = 0;
            total = 5;
            if (radioButton1.Checked)
            {
                score++;
            }

            if (radioButton5.Checked)
            {
                score++;
            }

            if (checkBox2.Checked)
            {
                score+=0.5;
            }

            if (checkBox1.Checked)
            {
                score -= 0.5;
            }

            if (checkBox4.Checked)
            {
                score -= 0.5;
            }

            if (checkBox3.Checked)
            {
                score += 0.5;
            }

            if (textBox1.Text.Trim().ToLower().Equals("arpanet"))
            {
                score++;
            }

            if(dateTimePicker1.Value.Day==1 && dateTimePicker1.Value.Month == 1 && dateTimePicker1.Value.Year == 1970)
            {
                score++;
            }

            if (comboBox1.SelectedIndex > 7)
            {
                label2.Show();
            }
            else
            {
                label2.Hide();
            }

            label3.Text = "Tvoje skóre je: "+score.ToString() + "/" + total.ToString();
            label3.Show();

        }
    }
}
