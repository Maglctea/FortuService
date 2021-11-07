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

        private void UpdateForm()
        {
            Device.Items.Clear();
            SurnameClient.Clear();
            NameClient.Clear();
            PatronymicClient.Clear();
            richTextDescription.Text = "Описание:";

            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader("SELECT `ID_User`, `Login_User` FROM `users`");
            while (reader.Read())
            {
                User.Items.Add(String.Format("{0}: {1}", reader[0], reader[1]));
            }
            reader.Close();

            MySqlDataReader reader1 = mySQL.GetReader("SELECT `ID_Service`, `Name_Service` FROM `priceList`");
            while (reader1.Read())
            {
                Service.Items.Add(String.Format("{0}: {1}", reader1[0], reader1[1]));
            }
            reader1.Close();
        }

        private void FormAddTickets_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void Telephone_TextChanged(object sender, EventArgs e)
        {
            if (Telephone.MaskCompleted)
            {
                UpdateForm();
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
                    Device.Items.Add(String.Format("{0}: {1}", reader1[0], reader1[1]));
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

        private void ButtonAddTicket(object sender, EventArgs e)
        {
            int IdClient;
            int IdDevice;

            MySQL mySQL = new();
            //КЛИЕНТ
            MySqlDataReader reader = mySQL.GetReader(String.Format("SELECT `ID_Client` FROM `clients` WHERE `Telephone_Client`=\"{0}\"", Telephone.Text));
            if (reader.HasRows)
            {
                reader.Read();
                IdClient = Convert.ToInt32(reader[0]);
                reader.Close();
            }
            else
            {
                reader.Close();
                MySqlDataReader reader1 = mySQL.GetReader(String.Format("INSERT INTO `clients`(`Telephone_Client`, `Surname_Client`, `Name_Client`, `Patronymic_Client`) " +
                                                                        "VALUES (\"{0}\",\"{1}\",\"{2}\",\"{3}\")", Telephone.Text, SurnameClient.Text, NameClient.Text, PatronymicClient.Text));
                reader1.Close();

                MySqlDataReader reader2 = mySQL.GetReader(String.Format("SELECT `ID_Client` FROM `clients` WHERE `Telephone_Client`=\"{0}\"", Telephone.Text));
                reader2.Read();
                 IdClient = Convert.ToInt32(reader2[0]);
                reader2.Close();
            }

            //ДЕВАЙС
            if (Device.Items.Count > 0 && Device.Text.IndexOf(':') > -1)
                IdDevice = Convert.ToInt32(Device.Text.Split(':')[0]);
            else
            {
                MySqlDataReader reader3 = mySQL.GetReader(String.Format("INSERT INTO `devices`(`ID_Client`, `Name_Device`, `Problem_Device`) " +
                                                                        "VALUES ({0},\"{1}\",\"{2}\")", IdClient, Device.Text, richTextDescription.Text));
                reader3.Close();

                MySqlDataReader reader4 = mySQL.GetReader(String.Format("SELECT `ID_Device` FROM `devices`, `clients` " +
                                                                        "WHERE `Telephone_Client`=\"{0}\" AND `Name_Device`=\"{1}\"", Telephone.Text, Device.Text));
                reader4.Read();
                IdDevice = Convert.ToInt32(reader4[0]);
                reader4.Close();

            }

            //СОЗДАНИЕ ТИКЕТА
            MySqlDataReader reader5 = mySQL.GetReader(String.Format("INSERT INTO `tickets`(`ID_User`, `ID_Client`, `ID_Devices`, `ID_Service`) " +
                                                                     "VALUES ({0},{1},{2},{3})", User.Text.Split(':')[0], IdClient, IdDevice, Service.Text.Split(':')[0]));

            if (reader5.RecordsAffected > 0)
            {
                MessageBox.Show("Тикет создан", "Успех");
            }
            reader5.Close();
        }
    }
}
