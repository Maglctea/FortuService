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
    public partial class FormRegistrationUser : Form
    {
        public FormRegistrationUser()
        {
            InitializeComponent();
        }

        private void ButtonAuthorization_Click(object sender, EventArgs e)
        {
            if (LoginRegistration.Text.Length < 1 || PasswordRegistration1.Text.Length <1 || PasswordRegistration2.Text.Length < 1)
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка регистрации");
                return;
            }
            if (PasswordRegistration1.Text.Length != PasswordRegistration2.Text.Length)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка регистрации");
                return;
            }
            try
            {
                MySqlConnection connection = new("Server=94.103.81.106;" +
                                                 "Port=3307;" +
                                                 "Database=FortuService;" +
                                                 "User Id=Fortunella;" +
                                                 "Password=Mexanik_X3000;" +
                                                 "Allow User Variables=True;");
                connection.Open();

                String InsertORG = "INSERT INTO users (Login_User, Password_User) VALUES (@Login, @Password)";

                MySqlCommand insert = new(InsertORG, connection);
                insert.Parameters.AddWithValue("@Login", LoginRegistration.Text);
                insert.Parameters.AddWithValue("@Password", PasswordRegistration1.Text);

                insert.ExecuteNonQuery();

                MessageBox.Show("Пользователь успешно создан", "Успех!");

                connection.Close();
            }
            catch(MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Аккаунт с таким логином уже существует.","Ошибка регистрации");
            }

            LoginRegistration.Clear();
            PasswordRegistration1.Clear();
            PasswordRegistration2.Clear();
            this.Close();

        }
    }
}
