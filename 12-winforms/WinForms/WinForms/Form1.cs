using System.Collections.Generic;
using System.Windows.Forms;
namespace WinForms
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<User> users1 = new List<User>();
            List<Reward> rewards1 = new List<Reward>();
            User a = new User("����", "��������", new DateTime(1989, 1, 9));
            Reward b = new Reward("1000 ������", "");
            users1.Add(new User("����", "������", new DateTime(1998, 5, 14)));
            users1.Add(new User("����", "������", new DateTime(1996, 12, 13)));
            users1.Add(new User("����", "������", new DateTime(1992, 1, 3)));
            users1.Add(new User("����", "������", new DateTime(1991, 4, 4)));
            users1.Add(new User("����", "������", new DateTime(1992, 1, 22)));
            rewards1.Add(new Reward("����������� ������", "���� �� �������� ���������� ������������� ������, �������� ������������ �� ���������� ������� ������������, ������������� ����������� ��� ������� ����� � �������� ��� �������� ��������."));
            rewards1.Add(new Reward("������ �������", "����������� ����������, �������� ������������ �����, ������� �������� ������ �������� ������ ��� �������� ����������� ����� ����� � � ���������� ������ ���� ����������� ������ ����� � �������� ������������, ��� ����� ������������ ������� ���."));
            new List(users1, rewards1);
            List.Users[0].ListRewards = rewards1;
            dataGridView1.DataSource = new MyBindingList<User>(List.Users.ToArray());
            dataGridView2.DataSource = new MyBindingList<Reward>(List.Rewards.ToArray());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2(1);
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3(1);
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2(2);
            a.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3(2);
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new MyBindingList<User>(List.Users.ToArray());
            dataGridView2.DataSource = new MyBindingList<Reward>(List.Rewards.ToArray());
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�����������: ������");
        }
    }
}
