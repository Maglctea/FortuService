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
using Excel = Microsoft.Office.Interop.Excel;

namespace FortuService
{
    public partial class FormReportTickets : Form
    {
        public FormReportTickets()
        {
            InitializeComponent();
        }

        private void FormReportTickets_Load(object sender, EventArgs e)
        {
            CheckedUsersList.Items.Clear();
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader("SELECT `Login_User` FROM `users`");
            while (reader.Read())
            {
                CheckedUsersList.Items.Add(reader[0]);
            }
            reader.Close();
            radioButton1.Checked = true;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                for (int i = 0; i < CheckedUsersList.Items.Count; i++)
                                    CheckedUsersList.SetItemChecked(i, true);
                CheckedUsersList.Enabled = false;
            }
                
            else
            {
                CheckedUsersList.Enabled = true;
            }

            

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application App = new Excel.Application();
            Excel.Workbook Book = App.Workbooks.Add();
            Excel.Worksheet List = Book.Sheets[1];
            List.Columns[1].ColumnWidth = 15;
            List.Columns[2].ColumnWidth = 9;
            List.Columns[3].ColumnWidth = 11;
            List.Columns[4].ColumnWidth = 13;
            List.Columns[5].ColumnWidth = 12;
            List.Columns[6].ColumnWidth = 27;

            List.Cells[1, 1] = String.Format("Отчет о тикетах за период от {0} до {1}", dateTimePicker1.Value.ToString("dd.MM.yyyy"), dateTimePicker2.Value.ToString("dd.MM.yyyy"));
            List.Cells[2, 1] = "Мастер";
            List.Cells[2, 2] = "№ Тикета";
            List.Cells[2, 3] = "№ Девайса";
            List.Cells[2, 4] = "Модель";
            List.Cells[2, 5] = "Статус тикета";
            List.Cells[2, 6] = "Наименование услуги";

            string statusTickets = "0, 1";
            if (radioButton4.Checked)
                statusTickets = "0, 1";
            else if (radioButton3.Checked)
                statusTickets = "0";
            else if (radioButton5.Checked)
                statusTickets = "1";

            string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string date2 = dateTimePicker2.Value.AddDays(1).ToString("yyyy-MM-dd");

            MySQL mySQL = new();
            List<string> ListUsers = new List<string>();
            
            int NumberString = 2;
            foreach (string user in CheckedUsersList.CheckedItems)
            {
                NumberString++;
                MySqlDataReader reader1 = mySQL.GetReader(String.Format("SELECT "+
                                                                            "tickets.ID_Tickets, "+
                                                                            "ID_Devices, "+
                                                                            "devices.Name_Device, "+
                                                                            "statusTicket.Name_Status, "+
                                                                            "priceList.Name_Service "+
                                                                        "FROM "+
                                                                            "tickets, "+
                                                                            "devices, "+
                                                                            "users, "+
                                                                            "groupService, "+
                                                                            "priceList, "+
                                                                            "statusTicket "+
                                                                        "WHERE "+
                                                                            "tickets.ID_Devices = devices.ID_Device AND tickets.ID_User = users.ID_User AND " +
                                                                            "users.Login_User = \"{0}\" AND priceList.ID_Group_Service = groupService.ID_Group AND " +
                                                                            "tickets.ID_Service = priceList.ID_Group_Service AND statusTicket.ID_Status = tickets.Status_Ticket AND " +
                                                                            "tickets.Status_Ticket IN ({1}) AND tickets.DateCreate BETWEEN '{2}' AND '{3}'" +
                                                                        "ORDER BY "+
                                                                            "devices.ID_Device", user, statusTickets, date1, date2));
                List.Cells[NumberString, 1] = user;
                while (reader1.Read())
                {
                    List.Cells[NumberString, 2] = reader1[0].ToString();
                    List.Cells[NumberString, 3] = reader1[1].ToString();
                    List.Cells[NumberString, 4] = reader1[2].ToString();
                    List.Cells[NumberString, 5] = reader1[3].ToString();
                    List.Cells[NumberString, 6] = reader1[4].ToString();
                    NumberString++;
                }
                reader1.Close();
            }
            List.Columns[1].EntireColumn.Font.Bold = true;
            List.Columns[1].EntireRow.Font.Bold = true;
            List.Columns[2].EntireRow.Font.Bold = true;
            List.Range[String.Format("B3:F{0}", NumberString)].Font.Bold = false;
            App.Visible = true;
        }
    }
}
