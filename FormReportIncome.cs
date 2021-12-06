using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FortuService
{
    public partial class FormReportIncome : Form
    {
        public FormReportIncome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application App = new Excel.Application();
            Excel.Workbook Book = App.Workbooks.Add();
            Excel.Worksheet List = Book.Sheets[1];
            List.Columns[1].ColumnWidth = 15;
            List.Columns[2].ColumnWidth = 10;
            List.Cells[1, 1] = String.Format("Доход за период от {0} до {1}", dateTimePicker1.Value.ToString("dd.MM.yyyy"), dateTimePicker2.Value.ToString("dd.MM.yyyy"));
            List.Cells[2, 1] = "Мастер";
            List.Cells[2, 2] = "Доход";

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
                MySqlDataReader reader1 = mySQL.GetReader(String.Format("SELECT SUM(priceList.Price_Service) " +
                                                                        "FROM " +
                                                                            "tickets, " +
                                                                            "devices, " +
                                                                            "users, " +
                                                                            "groupService," +
                                                                            " priceList, " +
                                                                            "statusTicket " +
                                                                        "WHERE " +
                                                                            "tickets.ID_Devices = devices.ID_Device AND tickets.ID_User = users.ID_User " +
                                                                            "AND users.Login_User = \"{0}\" AND priceList.ID_Group_Service = groupService.ID_Group " +
                                                                            "AND tickets.ID_Service = priceList.ID_Group_Service " +
                                                                            "AND statusTicket.ID_Status = tickets.Status_Ticket AND tickets.Status_Ticket IN ({1}) " +
                                                                            "AND tickets.DateCreate BETWEEN '{2}' AND '{3}'", user, statusTickets, date1, date2));
                List.Cells[NumberString, 1] = user;

                if (reader1.HasRows)
                {
                    reader1.Read();
                    List.Cells[NumberString, 2] = reader1[0].ToString();
                }
                else
                    List.Cells[NumberString, 2] = "0";

                reader1.Close();
            }
            List.Cells[NumberString + 1, 1] = "Итого:";
            List.Cells[NumberString + 1, 2].Formula = String.Format("=SUM(B3:B{0})", NumberString);

            List.Columns[1].EntireColumn.Font.Bold = true;
            List.Columns[1].EntireRow.Font.Bold = true;
            List.Range[String.Format("B3:F{0}", NumberString)].Font.Bold = false;
            App.Visible = true;
        }

        private void FormReportIncome_Load(object sender, EventArgs e)
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

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
