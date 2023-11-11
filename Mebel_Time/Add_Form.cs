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
    public partial class Add_Form : Form
    {
        DataBase dataBase = new DataBase();
        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var imya = textBox_imya.Text;
            var familiya = textBox_familiya.Text;
            var otchestvo = textBox_otchestvo.Text;
            var year_of_birth = textBox_year_of_birth.Text;
            var adress = textBox_adress.Text;
            var phone_number = textBox_phone_number.Text;

            /* 
            int int;
            if(int.TryParse(textBox_int.Text, out int))
            {
            var addQuery = $"insert into client (imya, familiya, otchestvo, year_of_birth, adress, phone_number) values ('{imya}', '{familiya}', '{otchestvo}', '{year_of_birth}', '{adress}', '{phone_number}')";
            }
            else
            {
            MessageBox.Show("Запись не создана!", "Позор!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            */

            var addQuery = $"insert into client (imya, familiya, otchestvo, year_of_birth, adress, phone_number) values ('{imya}', '{familiya}', '{otchestvo}', '{year_of_birth}', '{adress}', '{phone_number}')";

            var command = new SqlCommand(addQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.closeConnection();
        }
    }
}
