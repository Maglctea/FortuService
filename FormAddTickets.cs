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
    public partial class FormAddTickets : Form
    {
        public FormAddTickets()
        {
            InitializeComponent();
        }

        private void FormAddTickets_Load(object sender, EventArgs e)
        {
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader("SELECT `Login_User` FROM `users`");
            while (reader.Read())
            {
                User.Items.Add(reader[0]);
            }
            reader.Close(); 
            
            MySqlDataReader reader1 = mySQL.GetReader("SELECT `Name_Service` FROM `priceList`");
            while (reader1.Read())
            {
                Service.Items.Add(reader1[0]);
            }
            reader1.Close();
        }

        private void Telephone_TextChanged(object sender, EventArgs e)
        {
            if (Telephone.MaskCompleted)
            {
                MySQL mySQL = new();
                MySqlDataReader reader = mySQL.GetReader(String.Format("SELECT `Surname_Client`, `Name_Client`, `Patronymic_Client` " +
                                                         "FROM `clients` WHERE Telephone_Client=\"{0}\"", Telephone.Text));
                if (reader.HasRows)
                {
                    reader.Read();
                    SurnameClient.Text = reader[0].ToString();
                    NameClient.Text = reader[1].ToString();
                    PatronymicClient.Text = reader[2].ToString();
                }
                reader.Close();

                MySqlDataReader reader1 = mySQL.GetReader(String.Format("SELECT DISTINCT ID_Device, Name_Device FROM clients, devices " +
                                                                        "WHERE clients.ID_Client=devices.ID_Client " +
                                                                        "AND clients.Telephone_Client=\"{0}\"", Telephone.Text));
                while (reader1.Read())
                {
                    Device.Items.Add(String.Format("{0}: {1}",reader1[0], reader1[1]));
                }
                reader1.Close();
            }
        }

        private void Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("SELECT `Problem_Device` FROM `devices` WHERE ID_Device={0}", Device.Text.Split(':')[0]));
            richTextDescription.Text = "Описание:";
            while (reader.Read())
            {
                richTextDescription.Text = richTextDescription.Text + "\n" + reader[0].ToString();
            }
            reader.Close();
        }
    }
}
