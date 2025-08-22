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
            User a = new User("Иван", "Иванович", new DateTime(1989, 1, 9));
            Reward b = new Reward("1000 рублей", "");
            users1.Add(new User("Иван", "Иванов", new DateTime(1998, 5, 14)));
            users1.Add(new User("Иван", "Иванов", new DateTime(1996, 12, 13)));
            users1.Add(new User("Иван", "Иванов", new DateTime(1992, 1, 3)));
            users1.Add(new User("Иван", "Иванов", new DateTime(1991, 4, 4)));
            users1.Add(new User("Иван", "Иванов", new DateTime(1992, 1, 22)));
            rewards1.Add(new Reward("Нобелевская премия", "Одна из наиболее престижных международных премий, ежегодно присуждаемая за выдающиеся научные исследования, революционные изобретения или крупный вклад в культуру или развитие общества."));
            rewards1.Add(new Reward("Премия Дарвина", "Виртуальная антипремия, ежегодно присуждаемая лицам, которые наиболее глупым способом умерли или потеряли способность иметь детей и в результате лишили себя возможности внести вклад в генофонд человечества, тем самым потенциально улучшив его."));
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

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик: Михаил");
        }
    }
}
