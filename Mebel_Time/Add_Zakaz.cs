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
using System.Data.SqlClient;

namespace Mebel_Time
{
    public partial class Add_Zakaz : Form
    {
        DataBase dataBase = new DataBase();
        public Add_Zakaz()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Add_Zakaz_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int client_id;
            var name_of = textBox_name_of.Text;
            var type_of = textBox_type_of.Text;
            int price;
            var remaining_days = textBox_remaining_days.Text;
            var material = textBox_material.Text;
            var size = textBox_size.Text;

            if(int.TryParse(textBox_client_id.Text, out client_id) && int.TryParse(textBox_price.Text, out price))
            {
                var addQuery = $"insert into mebel (client_id, name_of, type_of, remaining_days, price, material, size) values ('{client_id}', '{name_of}', '{type_of}', '{remaining_days}', '{price}', '{material}', '{size}')";

                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Запись не удалось создать!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
        }
    }
}
