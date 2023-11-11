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

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Form1 : Form
    {

        DataBase dataBase = new DataBase();

        int selectedRow;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("client_id", "ID");
            dataGridView1.Columns.Add("imya", "Имя");
            dataGridView1.Columns.Add("familiya", "Фамилия");
            dataGridView1.Columns.Add("otchestvo", "Отчество");
            dataGridView1.Columns.Add("year_of_birth", "Год рождения");
            dataGridView1.Columns.Add("adress", "Адрес");
            dataGridView1.Columns.Add("phone_number", "Номер телефона");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetString(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querryString = $"select * from client";

            SqlCommand command = new SqlCommand(querryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             selectedRow = e.RowIndex;
            
            if(e.RowIndex >= 0)
            {
                DataGridView row = dataGridView1.Rows[selectedRow];

                textBox_id.Text = row.SelectedCells[0].Value.ToString();
                textBox_id.Text = row.SelectedCells[1].Value.ToString();
                textBox_id.Text = row.SelectedCells[2].Value.ToString();
                textBox_id.Text = row.SelectedCells[3].Value.ToString();
                textBox_id.Text = row.SelectedCells[4].Value.ToString();
                textBox_id.Text = row.SelectedCells[5].Value.ToString();
                textBox_id.Text = row.SelectedCells[6].Value.ToString();
            }
            

        }

        private void pictureBox_update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }
    }
}
