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
    public partial class Add_Delivery : Form
    {
        DataBase dataBase = new DataBase();
        public Add_Delivery()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Add_Delivery_Load(object sender, EventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int client_id;
            int delivery_cost;
            var remaining_time = textBox_remaining_time.Text;

            if (int.TryParse(textBox_client_id2.Text, out client_id) && int.TryParse(textBox_delivery_cost.Text, out delivery_cost))
            {
                var addQuery = $"insert into delivery (client_id, delivery_cost, remaining_time) values ('{client_id}', '{delivery_cost}', '{remaining_time}')";

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
