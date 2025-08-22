using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form3 : Form
    {
        int a;
        int c;
        public Form3(int mod)
        {
            InitializeComponent();
            a = mod;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            if (a == 1)
            {
                textBox1.Enabled = false;
                buttonLeft.Enabled = false;
                buttonRight.Enabled = false;
            }
            if (a == 2)
            {
                textBox1.Text = List.Rewards[0].ID.ToString();
                textBox2.Text = List.Rewards[0].Title.ToString();
                textBox3.Text = List.Rewards[0].Description.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c--;
            textBox1.Text = List.Rewards[c].ID.ToString();
            textBox2.Text = List.Rewards[c].Title.ToString();
            textBox3.Text = List.Rewards[c].Description.ToString();
            if (c == 0)
            {
                buttonLeft.Enabled = false;
                buttonRight.Enabled = true;
            }
            else
            {
                buttonLeft.Enabled = true;
                buttonRight.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                Reward g = new Reward(textBox2.Text, textBox3.Text);
                List.Rewards.Add(g);
                Close();
            }
            if (a == 2)
            {
                List.Rewards[c].Title = textBox2.Text;
                List.Rewards[c].Description = textBox3.Text;
            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            c++;
            textBox1.Text = List.Rewards[c].ID.ToString();
            textBox2.Text = List.Rewards[c].Title.ToString();
            textBox3.Text = List.Rewards[c].Description.ToString();
            if (c == List.Rewards.Count - 1)
            {
                buttonRight.Enabled = false;
                buttonLeft.Enabled = true;
            }
            else
            {
                buttonRight.Enabled = true;
                buttonLeft.Enabled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult l = MessageBox.Show("Удаление награды", "Вы действительно хотите удалить?", MessageBoxButtons.YesNo);
            if (l == DialogResult.Yes)
            {
                List.Rewards.RemoveAt(c);
                Close();
            }

        }
    }
}
