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
    public partial class MainForm : Form
        
    {
        public string Username
        {
            get{return this.UserNameLabel.Text; }

            set{this.UserNameLabel.Text = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ВойтиВАккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAuthorization formAuthorization = new();
            formAuthorization.Owner = this;
            formAuthorization.Show();
        }


        private void СоздатьАккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrationUser formRegistrationUser = new();
            formRegistrationUser.Owner = this;
            formRegistrationUser.Show();
        }

        private void ИзменитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditUser formEditUser = new();
            formEditUser.Owner = this;
            formEditUser.Login = UserNameLabel.Text;
            formEditUser.Show();
        }

        private void УдалитьАккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteUser formDeleteUser = new();
            formDeleteUser.Owner = this;
            formDeleteUser.LoginUser.Text = UserNameLabel.Text;
            formDeleteUser.Show();
        }

        private void ВыйтиИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserNameLabel.Text = "Выполнить вход";
            АдминистрированиеToolStripMenuItem.Visible = false;
        }
    }
}
