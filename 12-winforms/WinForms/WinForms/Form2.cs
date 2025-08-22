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
    public partial class Form2 : Form
    {
        int a;
        int d;
        public Form2(int mod)
        {
            InitializeComponent();
            a = mod;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (a == 1)
            {
                button1.Text = "Добавить";
                textBox2.Enabled = false;
                buttonRight.Enabled = false;
                buttonLeft.Enabled = false;
            }
            if (a == 2)
            {
                button1.Text = "Сохранить";
                textBox2.Text = List.Users[0].ID.ToString();
                textBox1.Text = List.Users[0].FirstName.ToString();
                textBox3.Text = List.Users[0].LastName.ToString();
                dateTimePicker1.Text = List.Users[0].Birthdate.ToString();
            }
            checkedListBox1.Items.Clear();
            for (int i = 0; i < List.Rewards.Count; i++)
            {
                checkedListBox1.Items.Add(List.Rewards[i].Title);
                for (int j = 0; j < List.Users[d].ListRewards.Count; j++)
                {
                    if (List.Rewards[i].ID == List.Users[d].ListRewards[j].ID)
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d--;
            textBox2.Text = List.Users[d].ID.ToString();
            textBox1.Text = List.Users[d].FirstName.ToString();
            textBox3.Text = List.Users[d].LastName.ToString();
            dateTimePicker1.Text = List.Users[d].Birthdate.ToString();
            if (d == 0)
            {
                buttonRight.Enabled = true;
                buttonLeft.Enabled = false;
            }
            else
            {
                buttonRight.Enabled = true;
                buttonLeft.Enabled = true;
            }
            checkedListBox1.Items.Clear();
            for (int i = 0; i < List.Rewards.Count; i++)
            {
                checkedListBox1.Items.Add(List.Rewards[i].Title);
                for (int j = 0; j < List.Users[d].ListRewards.Count; j++)
                {
                    if (List.Rewards[i].ID == List.Users[d].ListRewards[j].ID)
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }

            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            d++;
            textBox2.Text = List.Users[d].ID.ToString();
            textBox1.Text = List.Users[d].FirstName.ToString();
            textBox3.Text = List.Users[d].LastName.ToString();
            dateTimePicker1.Text = List.Users[d].Birthdate.ToString();
            if (d == List.Users.Count - 1)
            {
                buttonLeft.Enabled = true;
                buttonRight.Enabled = false;
            }
            else
            {
                buttonLeft.Enabled = true;
                buttonRight.Enabled = true;
            }
            checkedListBox1.Items.Clear();
            for (int i = 0; i < List.Rewards.Count; i++)
            {
                checkedListBox1.Items.Add(List.Rewards[i].Title);
                for (int j = 0; j < List.Users[d].ListRewards.Count; j++)
                {
                    if (List.Rewards[i].ID == List.Users[d].ListRewards[j].ID)
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                User h = new User(textBox1.Text, textBox3.Text, dateTimePicker1.Value);
                
                List<Reward> n = new List<Reward>();
                for(int i = 0; i < List.Rewards.Count; i++)
                {
                    if(checkedListBox1.GetItemChecked(i) )
                    {
                        n.Add(List.Rewards[i]);

                    }
                }
                h.ListRewards = n;
                List.Users.Add(h);
                Close();
            }
            if (a == 2)
            {
                List<Reward> n = new List<Reward>();
                for (int i = 0; i < List.Rewards.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        n.Add(List.Rewards[i]);

                    }
                }
                List.Users[d].FirstName = textBox1.Text;
                List.Users[d].LastName = textBox3.Text;
                List.Users[d].Birthdate = dateTimePicker1.Value;
                List.Users[d].ListRewards = n;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult l = MessageBox.Show("Удаление пользователя", "Вы действительно хотите удалить?", MessageBoxButtons.YesNo);
            if (l == DialogResult.Yes)
            {
                List.Users.RemoveAt(d);
                Close();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
