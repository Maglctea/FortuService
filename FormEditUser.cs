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
    public partial class FormEditUser : System.Windows.Forms.Form
    {
        public string Login
        {
            get { return this.LoginUser1.Text; }

            set
            {
                this.LoginUser1.Text = value;
            }
        }

        public FormEditUser()
        {
            InitializeComponent();
        }


        private void EditLoginButton_Click(object sender, EventArgs e)
            //Кнопка смена логина
        {
            if (LoginUser2.Text.Length < 1 || PasswordUser.Text.Length < 1)
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка");
                return;
            }
                
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("UPDATE `users` " +
                                                                    "SET Login_User=\"{0}\" " +
                                                                    "WHERE Login_User=\"{1}\" " +
                                                                    "AND Password_User=\"{2}\"", LoginUser2.Text, LoginUser1.Text.Replace("Пользователь: ", ""),  PasswordUser.Text));
            if (reader.RecordsAffected > 0)
            {
                MainForm mainForm = (MainForm)this.Owner;

                mainForm.Username = String.Format("Пользователь: {0}", LoginUser2.Text);
                LoginUser1.Text = String.Format("Пользователь: {0}", LoginUser2.Text);
                MessageBox.Show("Логин изменен");
            }
            else
                MessageBox.Show("Неверный логин или пароль");
            reader.Close();
        }

        private void EditButtonPassword_Click(object sender, EventArgs e)
        {
            if (NewPasswordUser.Text.Length < 1 || PasswordUser1.Text.Length < 1 || PasswordUser2.Text.Length < 1)
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка");
                return;
            }
            if (PasswordUser1.Text != PasswordUser2.Text)
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка");
                return;
            }
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("UPDATE `users` " +
                                                                    "SET Password_User=\"{0}\" " +
                                                                    "WHERE Login_User=\"{1}\" " +
                                                                    "AND Password_User=\"{2}\"", PasswordUser2.Text, LoginUser1.Text.Replace("Пользователь: ", ""), NewPasswordUser.Text));
            if (reader.RecordsAffected > 0)
                MessageBox.Show("Пароль изменен");
            else
                MessageBox.Show("Неверный логин или пароль");
            reader.Close();
        }
    }
}
