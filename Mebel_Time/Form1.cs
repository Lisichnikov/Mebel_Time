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

        private void ClearFields()
        {
            textBox_id.Text = "";
            textBox_imya.Text = "";
            textBox_familiya.Text = "";
            textBox_otchestvo.Text = "";
            textBox_year_of_birth.Text = "";
            textBox_adress.Text = "";
            textBox_phone_number.Text = "";
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
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBox_id.Text = row.Cells[0].Value.ToString();
                textBox_imya.Text = row.Cells[1].Value.ToString();
                textBox_familiya.Text = row.Cells[2].Value.ToString();
                textBox_otchestvo.Text = row.Cells[3].Value.ToString();
                textBox_year_of_birth.Text = row.Cells[4].Value.ToString();
                textBox_adress.Text = row.Cells[5].Value.ToString();
                textBox_phone_number.Text = row.Cells[6].Value.ToString();
            }
            

        }

        private void pictureBox_update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void button_newNote_Click(object sender, EventArgs e)
        {
            Add_Form addfrm = new Add_Form();
            addfrm.Show();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from client where concat (client_id, imya, familiya, otchestvo, year_of_birth, adress, phone_number) like '%" + textBox_search.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while(read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            
            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
        }

        private void Update()
        {
            dataBase.openConnection();

            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;

                if(rowState == RowState.Existed)
                {
                    continue;
                }

                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuerry = $"delete from client where client_id = {id}";

                    var command = new SqlCommand(deleteQuerry, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var client_id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var imya = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var familiya = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var otchestvo = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var year_of_birth = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var adress = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var phone_number = dataGridView1.Rows[index].Cells[6].Value.ToString();

                    var changeQuerry = $"update client set imya = '{imya}', familiya = '{familiya}', otchestvo = '{otchestvo}', year_of_birth = '{year_of_birth}', adress = '{adress}', phone_number = '{phone_number}' where client_id = '{client_id}'";

                    var command = new SqlCommand(changeQuerry, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var client_id = textBox_id.Text;
            var imya = textBox_imya.Text;
            var familiya = textBox_familiya.Text;
            var otchestvo = textBox_otchestvo.Text;
            var year_of_birth = textBox_year_of_birth.Text;
            var adress = textBox_adress.Text;
            var phone_number = textBox_phone_number.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                /* 
                 if(int.TryParse(textBox_int.Text, out int))
                {
                dataGridView1.Rows[selectedRow].SetValues(client_id, imya, familiya, otchestvo, year_of_birth, adress, phone_number);
                dataGridView1.Rows[selectedRow].Cells[7].Value = RowState.Modified;
                }
                else
                {
                MessageBox.Show("Запись не создана!", "Позор!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                */
                dataGridView1.Rows[selectedRow].SetValues(client_id, imya, familiya, otchestvo, year_of_birth, adress, phone_number);
                dataGridView1.Rows[selectedRow].Cells[7].Value = RowState.Modified;
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void pictureBox_eraser_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void pictureBox_search_Click(object sender, EventArgs e)
        {

        }
    }
}
