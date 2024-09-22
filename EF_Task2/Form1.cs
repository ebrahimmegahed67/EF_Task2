using EF_Task2.Models;

namespace EF_Task2
{
    public partial class Form1 : Form
    {
        Taskcontext taskcontext;
        public Form1()
        {
            InitializeComponent();
            taskcontext = new Taskcontext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taskcontext = new Taskcontext();
            dgv_author.DataSource = taskcontext.Author.Select(s => new { authId = s.autId, name = s.name, age = s.age, userName = s.userName, password = s.password, joinDate = s.joinDate }).ToList();
        }

        public void clear()
        {
            txt_name.Text = txt_password.Text = txt_userName.Text = string.Empty;
            nu_age.Value = 0;
            date.Value = new DateTime(2024, 9, 22);
        }

        private void dgv_author_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = (int)dgv_author.SelectedRows[0].Cells[0].Value;
            author author = taskcontext.Author.Where(s => s.autId == id).SingleOrDefault();

            txt_name.Text = author.name;
            txt_password.Text = author.password;
            txt_userName.Text = author.userName;
            nu_age.Value = (int)author.age;
            date.Value = author.joinDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            author s = new author()
            {
                name = txt_name.Text,
                userName = txt_userName.Text,
                password = txt_password.Text,
                age = (int)nu_age.Value,
                joinDate = date.Value
            };
            taskcontext.Add(s);
            taskcontext.SaveChanges();
            MessageBox.Show("Added");
            dgv_author.DataSource = taskcontext.Author.Select(s => new { authId = s.autId, name = s.name, age = s.age, userName = s.userName, password = s.password, joinDate = s.joinDate }).ToList();
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_author.SelectedRows[0].Cells[0].Value;
            author author = taskcontext.Author.Where(s => s.autId == id).SingleOrDefault();
            author.name = txt_name.Text;
            author.userName = txt_userName.Text;
            author.password = txt_password.Text;
            author.joinDate = date.Value;
            author.age = (int)nu_age.Value;
            taskcontext.SaveChanges();
            MessageBox.Show("Updated");
            dgv_author.DataSource = taskcontext.Author.Select(s => new { authId = s.autId, name = s.name, age = s.age, userName = s.userName, password = s.password, joinDate = s.joinDate }).ToList();
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_author.SelectedRows[0].Cells[0].Value;
            author author = taskcontext.Author.Where(s => s.autId == id).SingleOrDefault();
            taskcontext.Remove(author);
            taskcontext.SaveChanges();
            MessageBox.Show("Deleted");
            dgv_author.DataSource = taskcontext.Author.Select(s => new { authId = s.autId, name = s.name, age = s.age, userName = s.userName, password = s.password, joinDate = s.joinDate }).ToList();
            clear();
        }
    }
}
