using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mebel_Time
{
    public partial class signup : Form
    {
        DataBase dataBase = new DataBase();
        public signup()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void signup_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '•';
            textBox_logn.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void button_enter_Click(object sender, EventArgs e)
        {

            var login = textBox_logn.Text;
            var password = textBox_password.Text;

            string querrystring = $"insert into register(login_user, password_user) values('{login}', '{password}')";

            SqlCommand command = new SqlCommand(querrystring, dataBase.getConnection());

            dataBase.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                login frm_login = new login();
                this.Hide();
                frm_login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }
            dataBase.closeConnection();
        }

        private Boolean checkuser()
        {
            var loginUser = textBox_logn.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querrystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querrystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0 )
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_logn.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_password.Text = "";
        }
    }
}
