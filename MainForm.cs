using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FortuService.Properties;
using MySql.Data.MySqlClient;

namespace FortuService
{ 
    public partial class MainForm : System.Windows.Forms.Form
        
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
            UpdateTicketList();
        }

        private void УправлениеПользователямиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdministrationUsers formAdministrationUsers = new();
            formAdministrationUsers.Owner = this;
            formAdministrationUsers.Show();
        }

        private void ПрайслистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPiceList formPiceList = new();
            formPiceList.Owner = this;
            formPiceList.Show();
        }

        private void СоздатьТикетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddTickets formAddTickets = new();
            formAddTickets.Owner = this;
            formAddTickets.Show();
        }

        private void ShowTicket(int IdTicket)
        {
            User.Clear();
            Service.Clear();
            Price.Clear();
            Telephone.Clear();
            SurnameClient.Clear();
            NameClient.Clear();
            PatronymicClient.Clear();
            IdDevice.Clear();
            NameDevice.Clear();
            richTextDescription.Text = "Описание:";
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("SELECT users.Login_User, priceList.Name_Service, priceList.Price_Service, clients.Telephone_Client, clients.Surname_Client, clients.Name_Client, clients.Patronymic_Client, ID_Devices, devices.Name_Device, devices.Problem_Device FROM tickets, users, clients, devices, priceList WHERE tickets.ID_User = users.ID_User AND tickets.ID_Client = clients.ID_Client AND tickets.ID_Devices = devices.ID_Device AND tickets.ID_Service = priceList.ID_Service AND tickets.ID_Tickets = {0}", IdTicket));
            if (reader.HasRows)
            {
                reader.Read();
                User.Text = reader[0].ToString();
                Service.Text = reader[1].ToString();
                Price.Text = reader[2].ToString();
                Telephone.Text = reader[3].ToString();
                SurnameClient.Text = reader[4].ToString();
                NameClient.Text = reader[5].ToString();
                PatronymicClient.Text = reader[6].ToString();
                IdDevice.Text = reader[7].ToString();
                NameDevice.Text = reader[8].ToString();
                richTextDescription.Text = reader[9].ToString();
            }
            else
                MessageBox.Show("Тикет с данным ID не существует.", "Ошибка");
            reader.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedIndices.Count > 0)
                foreach (var i in ListView.SelectedIndices)
                    ListView.Items[Convert.ToInt32(i)].Selected = false;
            ShowTicket(Convert.ToInt32(Ticket.Text));
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        public void UpdateTicketList()
        {
            MySQL mySQL = new();

            MySqlDataReader reader = mySQL.GetReader(String.Format("SELECT ID_Tickets, ID_Devices, devices.Name_Device, Status_Ticket, groupService.ID_Group " +
                                                                   "FROM tickets, devices, users, groupService, priceList " +
                                                                   "WHERE tickets.ID_Devices=devices.ID_Device AND tickets.ID_User=users.ID_User AND users.Login_User=\"{0}\" " +
                                                                   "AND priceList.ID_Group_Service=groupService.ID_Group " +
                                                                   "AND tickets.ID_Service=priceList.ID_Group_Service", UserNameLabel.Text.Replace("Пользователь: ", "")));
            ListViewGroup GroupActiveTickets = new(Name = "GroupActiveTickets", Text = "Активные объявления");
            ListViewGroup GroupNoActiveTickets = new(Name = "GroupNoActiveTickets", Text = "Неактивные объявления");
            ListView.Items.Clear();
            ListView.Groups.Add(GroupActiveTickets);
            ListView.Groups.Add(GroupNoActiveTickets);

            while (reader.Read())
            {

                ListViewItem item = new(new string[] { " "+Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2])});

                if (Convert.ToInt32(reader[4]) == 1)
                    item.ImageIndex = 0;
                else if (Convert.ToInt32(reader[4]) == 2)
                    item.ImageIndex = 1;
                else if (Convert.ToInt32(reader[4]) == 3)
                    item.ImageIndex = 2;
                else if (Convert.ToInt32(reader[4]) == 4)
                    item.ImageIndex = 3;
                else
                    item.ImageIndex = 4;

                if (Convert.ToInt32(reader[3]) == 1)
                {
                    item.Group = GroupActiveTickets;
                }
                else
                {
                    item.Group = GroupNoActiveTickets;
                }

                ListView.Items.Add(item);
            }
        }

        private void ОтобразитьТикетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateTicketList();
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListView.SelectedIndices.Count > 0)
            {
                ShowTicket(Convert.ToInt32(ListView.SelectedItems[0].Text));
            }
        }

        private void TicketClose_Click(object sender, EventArgs e)
        {
            int IDTicket;

            if (ListView.SelectedIndices.Count > 0 && ListView.SelectedIndices[0] > -1)
                IDTicket = Convert.ToInt32(ListView.SelectedItems[0].Text);
            else
            {
                if (Ticket.Text.Length > 0)
                    IDTicket = Convert.ToInt32(Ticket.Text);
                else
                    return;

            }
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("UPDATE `tickets` SET `Status_Ticket`= 0 WHERE ID_Tickets={0} ", IDTicket));
            reader.Close();
            UpdateTicketList();

        }

        private void TicketOpen_Click(object sender, EventArgs e)
        {
            int IDTicket;

            if (ListView.SelectedIndices.Count > 0 && ListView.SelectedIndices[0] > -1)
                IDTicket = Convert.ToInt32(ListView.SelectedItems[0].Text);
            else
            {
                if (Ticket.Text.Length > 0)
                    IDTicket = Convert.ToInt32(Ticket.Text);
                else
                    return;

            }
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("UPDATE `tickets` SET `Status_Ticket`= 1 WHERE ID_Tickets={0} ", IDTicket));
            reader.Close();
            UpdateTicketList();
        }

        private void TicketDelete_Click(object sender, EventArgs e)
        {
            int IDTicket;

            if (ListView.SelectedIndices.Count > 0 && ListView.SelectedIndices[0] > -1)
                IDTicket = Convert.ToInt32(ListView.SelectedItems[0].Text);
            else
            {
                if (Ticket.Text.Length > 0)
                    IDTicket = Convert.ToInt32(Ticket.Text);
                else
                    return;

            }
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("DELETE FROM `tickets` WHERE ID_Tickets={0} ", IDTicket));
            reader.Close();
            UpdateTicketList();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            int IDTicket;
            int IDClient;

            if (ListView.SelectedIndices.Count > 0 && ListView.SelectedIndices[0] > -1)
                IDTicket = Convert.ToInt32(ListView.SelectedItems[0].Text);
            else
            {
                if (Ticket.Text.Length > 0)
                                IDTicket = Convert.ToInt32(Ticket.Text);
                else
                    return;

            }
                
            
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("SELECT `ID_Client` FROM `tickets` WHERE `ID_Tickets`={0}", IDTicket));
            if (reader.HasRows)
            {
                reader.Read();
                IDClient = Convert.ToInt32(reader[0]);
                reader.Close();
            }
            else
            {
                reader.Close();
                return;
            }
                
            MySqlDataReader reader1 = mySQL.GetReader(String.Format("UPDATE `devices` SET `Name_Device`=\"{0}\",`Problem_Device`=\"{1}\" " +
                                                                   "WHERE `ID_Device`={2}", NameDevice.Text, richTextDescription.Text, IdDevice.Text));
            reader1.Close();

            MySqlDataReader reader2 = mySQL.GetReader(String.Format("UPDATE `clients` SET `Telephone_Client`=\"{0}\",`Surname_Client`=\"{1}\",`Name_Client`=\"{2}\",`Patronymic_Client`=\"{3}\" " +
                                                                    "WHERE `ID_Client`={4}", Telephone.Text, SurnameClient.Text, NameClient.Text, PatronymicClient.Text, IDClient));
            reader2.Close();
            UpdateTicketList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MySQL mySQL = new();
            mySQL.CloseConnection();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ImageList imageList = new();
            imageList.ImageSize = new Size(24, 24);
            imageList.Images.Add(Resources.other);
            imageList.Images.Add(Resources.iconPrinter);
            imageList.Images.Add(Resources.iconPC);
            imageList.Images.Add(Resources.iconTelephone);
            imageList.Images.Add(Resources.other);


            Bitmap emptyImage = new(24, 24);
            using (Graphics gr = Graphics.FromImage(emptyImage))
            {
                gr.Clear(Color.White);
            }
            imageList.Images.Add(emptyImage);
            ListView.SmallImageList = imageList;
        }

        private void списокТикетовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportTickets formReportTickets = new FormReportTickets();
            formReportTickets.Owner = this;
            formReportTickets.Show();
        }

        private void отчетОДоходеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportIncome formReportIncome = new FormReportIncome(); 
            formReportIncome.Owner = this;
            formReportIncome.Show();
        }
    }
}
