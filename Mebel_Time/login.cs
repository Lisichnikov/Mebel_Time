using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mebel_Time
{
    public partial class login : Form
    {
        DataBase dataBase = new DataBase();
        public login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void login_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '•';
            textBox_logn.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void button_enter_Click_1(object sender, EventArgs e)
        {
            var loginUser = textBox_logn.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void linklabel_Click(object sender, EventArgs e)
        {
            signup frm_sign = new signup();
            frm_sign.Show();
            this.Hide();
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
