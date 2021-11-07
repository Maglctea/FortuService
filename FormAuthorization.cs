using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FortuService
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void ButtonAuthorization_Click(object sender, EventArgs e)
        {

            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("SELECT * FROM `users` WHERE Login_User=\"{0}\" AND Password_User=\"{1}\"", LoginAuthorization.Text, PasswordAuthorization.Text));

            if (reader.HasRows)
            {
                MessageBox.Show("Подключено");
                this.Hide();
                MainForm mainForm = (MainForm)this.Owner;

                reader.Read();
                mainForm.Username = String.Format("Пользователь: {0}", reader[1]);
                if (Convert.ToInt32(reader[3]) == 1)
                    mainForm.АдминистрированиеToolStripMenuItem.Visible = true;
                else
                    mainForm.АдминистрированиеToolStripMenuItem.Visible = false;
                reader.Close();
                mainForm.UpdateTicketList();
            }

            else
                MessageBox.Show("Неверный логин или пароль");

            //dgv.DataSource = table; //можно исп для заполнения таблицы
        }
    }
}
