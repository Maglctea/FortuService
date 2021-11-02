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
    public partial class FormDeleteUser : Form
    {
        public FormDeleteUser()
        {
            InitializeComponent();
        }

        private void EditLoginButton_Click(object sender, EventArgs e)
        {
            if (PasswordUser.Text.Length < 1)
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка");
                return;
            }
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("DELETE FROM `users` " +
                                                                    "WHERE Login_User=\"{0}\" " +
                                                                    "AND Password_User=\"{1}\"", LoginUser.Text.Replace("Пользователь: ", ""), PasswordUser.Text));
            if (reader.RecordsAffected > 0)
            {
                MessageBox.Show("Аккаунт удален", "Успех");
                LoginUser.Text = "Пользователь: ";
            }

            else
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }
            reader.Close();
            this.Hide();
            MainForm mainForm = (MainForm)this.Owner;
            mainForm.Username = String.Format("Пользователь: ");
            mainForm.АдминистрированиеToolStripMenuItem.Visible = false;
        }

        private void LoginUser_Click(object sender, EventArgs e)
        {

        }
    }
}
