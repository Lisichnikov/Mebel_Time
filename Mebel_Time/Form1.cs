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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        // клиентская база
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
            dataGridView1.Columns[7].Visible = false;
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

            CreateColumns2();
            RefreshDataGrid2(dataGridView2);

            CreateColumns3();
            RefreshDataGrid3(dataGridView3);

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
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

        // база заказов
        private void CreateColumns2()
        {
            dataGridView2.Columns.Add("zakaz_id", "ID");
            dataGridView2.Columns.Add("client_id", "ID клиента");
            dataGridView2.Columns.Add("remaining_days", "Готовность заказа");
            dataGridView2.Columns.Add("name_of", "Название");
            dataGridView2.Columns.Add("type_of", "Тип");
            dataGridView2.Columns.Add("price", "Цена");
            dataGridView2.Columns.Add("material", "Материалы");
            dataGridView2.Columns.Add("size", "Размеры");
            dataGridView2.Columns.Add("IsNew", String.Empty);
            dataGridView2.Columns[8].Visible = false;
        }

        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetString(6), record.GetString(7), RowState.ModifiedNew);
        }

        private void RefreshDataGrid2(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querryString = $"select * from mebel";

            SqlCommand command = new SqlCommand(querryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow2(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                textBox_zakaz_id.Text = row.Cells[0].Value.ToString();
                textBox_client_id.Text = row.Cells[1].Value.ToString();
                textBox_name_of.Text = row.Cells[3].Value.ToString();
                textBox_type_of.Text = row.Cells[4].Value.ToString();
                textBox_price.Text = row.Cells[5].Value.ToString();
                textBox_remaining_days.Text = row.Cells[2].Value.ToString();
                textBox_material.Text = row.Cells[6].Value.ToString();
                textBox_size.Text = row.Cells[7].Value.ToString();
            }
        }

        private void pictureBox_update2_Click(object sender, EventArgs e)
        {
            RefreshDataGrid2(dataGridView2);
        }

        private void button_newNote2_Click(object sender, EventArgs e)
        {
            Add_Zakaz addzakazfrm = new Add_Zakaz();
            addzakazfrm.Show();
        }

        private void Search2(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from mebel where concat (zakaz_id, client_id, name_of, type_of, remaining_days, price, material, size) like '%" + textBox8.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow2(dgw, read);
            }
            read.Close();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            Search2(dataGridView2);
        }

        private void Update2()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView2.Rows[index].Cells[8].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);
                    var deleteQuerry = $"delete from mebel where zakaz_id = {id}";

                    var command = new SqlCommand(deleteQuerry, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var zakaz_id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var client_id = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var name_of = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    var type_of = dataGridView2.Rows[index].Cells[4].Value.ToString();
                    var price = dataGridView2.Rows[index].Cells[5].Value.ToString();
                    var remaining_days = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var material = dataGridView2.Rows[index].Cells[6].Value.ToString();
                    var size = dataGridView2.Rows[index].Cells[7].Value.ToString();

                    var changeQuerry = $"update mebel set client_id = '{client_id}', remaining_days = '{remaining_days}', name_of = '{name_of}', type_of = '{type_of}', price = '{price}', material = '{material}', size = '{size}' where zakaz_id = '{zakaz_id}'";

                    var command = new SqlCommand(changeQuerry, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        private void deleteRow2()
        {
            int index = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows[index].Visible = false;

            if (dataGridView2.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView2.Rows[index].Cells[8].Value = RowState.Deleted;
                return;
            }
            dataGridView2.Rows[index].Cells[8].Value = RowState.Deleted;
        }

        private void button_delete2_Click(object sender, EventArgs e)
        {
            deleteRow2();
            ClearFields2();
        }

        private void button_save2_Click(object sender, EventArgs e)
        {
            Update2();
        }

        private void Change2()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;

            var zakaz_id = textBox_zakaz_id.Text;
            int client_id;
            var name_of = textBox_name_of.Text;
            var type_of = textBox_type_of.Text;
            var remaining_days = textBox_remaining_days.Text;
            int price;
            var material = textBox_material.Text;
            var size = textBox_size.Text;

            if (dataGridView2.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_client_id.Text, out client_id) && int.TryParse(textBox_price.Text, out price))
                {
                    dataGridView2.Rows[selectedRow].SetValues(zakaz_id, client_id, remaining_days, name_of, type_of, price, material, size);
                    dataGridView2.Rows[selectedRow].Cells[8].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Не удалось изменить запись!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_edit2_Click(object sender, EventArgs e)
        {
            Change2();
            ClearFields2();
        }

        private void ClearFields2()
        {
            textBox_zakaz_id.Text = "";
            textBox_client_id.Text = "";
            textBox_remaining_days.Text = "";
            textBox_name_of.Text = "";
            textBox_type_of.Text = "";
            textBox_price.Text = "";
            textBox_material.Text = "";
            textBox_size.Text = "";
        }

        private void pictureBox_eraser2_Click(object sender, EventArgs e)
        {
            ClearFields2();
        }


        // база доставки
        private void CreateColumns3()
        {
            dataGridView3.Columns.Add("zakaz_id", "ID");
            dataGridView3.Columns.Add("client_id", "ID клиента");
            dataGridView3.Columns.Add("delivery_cost", "Стоимость доставки");
            dataGridView3.Columns.Add("remaining_time", "Время ожидания");
            dataGridView3.Columns.Add("IsNew", String.Empty);
            dataGridView3.Columns[4].Visible = false;
        }

        private void ReadSingleRow3(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetString(3), RowState.ModifiedNew);
        }

        private void RefreshDataGrid3(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string querryString = $"select * from delivery";

            SqlCommand command = new SqlCommand(querryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow3(dgw, reader);
            }
            reader.Close();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedRow];

                textBox_zakaz_id2.Text = row.Cells[0].Value.ToString();
                textBox_client_id2.Text = row.Cells[1].Value.ToString();
                textBox_delivery_cost.Text = row.Cells[2].Value.ToString();
                textBox_remaining_time.Text = row.Cells[3].Value.ToString();
            }
        }

        private void pictureBox_update3_Click(object sender, EventArgs e)
        {
            RefreshDataGrid3(dataGridView3);
        }

        private void button_newNote3_Click(object sender, EventArgs e)
        {
            Add_Delivery adddeliveryfrm = new Add_Delivery();
            adddeliveryfrm.Show();
        }

        private void Search3(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"select * from delivery where concat (zakaz_id, client_id, delivery_cost, remaining_time) like '%" + textBox10.Text + "%'";

            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow3(dgw, read);
            }
            read.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            Search3(dataGridView3);
        }

        private void Update3()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView3.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView3.Rows[index].Cells[4].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView3.Rows[index].Cells[0].Value);
                    var deleteQuerry = $"delete from delivery where zakaz_id = {id}";

                    var command = new SqlCommand(deleteQuerry, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var zakaz_id = dataGridView3.Rows[index].Cells[0].Value.ToString();
                    var client_id = dataGridView3.Rows[index].Cells[1].Value.ToString();
                    var delivery_cost = dataGridView3.Rows[index].Cells[2].Value.ToString();
                    var remaining_time = dataGridView3.Rows[index].Cells[3].Value.ToString();

                    var changeQuerry = $"update delivery set client_id = '{client_id}', delivery_cost = '{delivery_cost}', remaining_time = '{remaining_time}' where zakaz_id = '{zakaz_id}'";

                    var command = new SqlCommand(changeQuerry, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        private void deleteRow3()
        {
            int index = dataGridView3.CurrentCell.RowIndex;

            dataGridView3.Rows[index].Visible = false;

            if (dataGridView3.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dataGridView3.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            dataGridView3.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private void button_delete3_Click(object sender, EventArgs e)
        {
            deleteRow3();
            ClearFields3();
        }

        private void button_save3_Click(object sender, EventArgs e)
        {
            Update3();
        }

        private void Change3()
        {
            var selectedRowIndex = dataGridView3.CurrentCell.RowIndex;

            var zakaz_id = textBox_zakaz_id2.Text;
            int client_id;
            int delivery_cost;
            var remaining_time = textBox_remaining_time.Text;

            if (dataGridView3.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (int.TryParse(textBox_client_id2.Text, out client_id) && int.TryParse(textBox_delivery_cost.Text, out delivery_cost))
                {
                    dataGridView3.Rows[selectedRow].SetValues(zakaz_id, client_id, delivery_cost, remaining_time);
                    dataGridView3.Rows[selectedRow].Cells[4].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Не удалось изменить запись!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_edit3_Click(object sender, EventArgs e)
        {
            Change3();
            ClearFields3();
        }

        private void ClearFields3()
        {
            textBox_zakaz_id2.Text = "";
            textBox_client_id2.Text = "";
            textBox_delivery_cost.Text = "";
            textBox_remaining_time.Text = "";
        }

        private void pictureBox_erase3_Click(object sender, EventArgs e)
        {
            ClearFields3();
        }

        private void выдатьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                sum += Convert.ToDouble(dataGridView2[5, i].Value);
            }

            int count = dataGridView2.RowCount;
            string otchet = "ОТЧЕТ О ВЫРУЧКЕ" +
                "\n" +
                "\nВыручка: " + sum +
                "\nКоличество активных заказов: " + count;

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, otchet);
            MessageBox.Show("Файл сохранен");
        }

        private void показатьПрайслистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string price_list = "ПРАЙС-ЛИСТ\n" +
                "\n" +
                "Диван-кровать D202:   25000р\n" +
                "Диван-кровать D303:   30000р\n" +
                "Диван D201:   20000р\n" +
                "Диван угольный D20130:   27000р\n" +
                "Стол круглый S101:   12000р\n" +
                "Стол квадратный S1015:   14000р\n" +
                "Стол большой S303:   20000р\n" +
                "Стул обычный ST806060:   2000р\n" +
                "Стул круглый ST406040:   1500р\n" +
                "Стул треугольный ST606060:   1800р\n" +
                "Кресло офисное K806060:   6000р\n" +
                "Кресло K806050:   10000р\n" +
                "Кровать KR202:   25000р\n" +
                "Кровать KR201:   20000р\n" +
                "Кровать круглая KR303:   35000р\n";

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, price_list);
            MessageBox.Show("Файл сохранен");
        }
    }
}