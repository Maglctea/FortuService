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
    public partial class FormPiceList : Form
    {
        public FormPiceList()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            TextIDService.Text = "";
            TextName.Text = "";
            TextPrice.Text = "";
            richTextDescription.Text = "";
            ListStatus.SelectedIndex = 0;

            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader("SELECT `ID_Group_Service`, `ID_Service`, `Name_Service`, `Price_Service`, `Description_Service` FROM `priceList`");
            ListViewGroup groupGeneral = new(Name = "groupGeneral", Text = "Общее");
            ListViewGroup groupPrinter = new(Name = "groupPrinter", Text = "Принтеры");
            ListViewGroup groupPC = new(Name = "groupPC", Text = "Компьютеры");
            ListViewGroup groupTelephone = new(Name = "groupTelephone", Text = "Телефоны");
            ListViewGroup groupOther = new(Name = "GroupOther", Text = "Другое");


            ListView1.Items.Clear();
            ListView1.Groups.Add(groupGeneral);
            ListView1.Groups.Add(groupPrinter);
            ListView1.Groups.Add(groupPC);
            ListView1.Groups.Add(groupTelephone);
            ListView1.Groups.Add(groupOther);

            //Convert.ToString(reader[0])
            while (reader.Read())
            {

                ListViewItem item = new(new string[] { Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]) });
                if (Convert.ToInt32(reader[0]) == 1)
                {
                    item.Group = groupGeneral;
                }
                else if (Convert.ToInt32(reader[0]) == 2)
                {
                    item.Group = groupPrinter;
                }
                else if (Convert.ToInt32(reader[0]) == 3)
                {
                    item.Group = groupPC;
                }
                else if (Convert.ToInt32(reader[0]) == 4)
                {
                    item.Group = groupTelephone;
                }
                else
                {
                    item.Group = groupOther;
                }

                ListView1.Items.Add(item);
            }

            reader.Close();
        }

        private void ButtonUpdateList_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void FormPiceList_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem rows;
            if (ListView1.SelectedIndices.Count > 0)
            {
                rows = ListView1.SelectedItems[0];
                TextIDService.Text = Convert.ToString(rows.SubItems[0].Text);
                TextName.Text = Convert.ToString(rows.SubItems[1].Text);
                TextPrice.Text = Convert.ToString(rows.SubItems[2].Text);
                richTextDescription.Text = Convert.ToString(rows.SubItems[3].Text);
                if (rows.Group.Name == "groupGeneral")
                    ListStatus.SelectedIndex = 0;
                else if (rows.Group.Name == "groupPrinter")
                    ListStatus.SelectedIndex = 1;
                else if (rows.Group.Name == "groupPC")
                    ListStatus.SelectedIndex = 2;
                else if (rows.Group.Name == "groupTelephone")
                    ListStatus.SelectedIndex = 3;
                else 
                    ListStatus.SelectedIndex = 4;

            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            MySQL mySQL = new();

            if (TextName.Text.Length > 0)
            {
                MySqlDataReader reader = mySQL.GetReader(String.Format("UPDATE `priceList` " +
                                                                        "SET Name_Service=\"{0}\" " +
                                                                        "WHERE ID_Service={1} ", TextName.Text, TextIDService.Text));
                reader.Close();
            }
            if (TextPrice.Text.Length > 0)
            {
                MySqlDataReader reader1 = mySQL.GetReader(String.Format("UPDATE `priceList` " +
                                                                        "SET Price_Service={0} " +
                                                                        "WHERE ID_Service={1} ", TextPrice.Text, TextIDService.Text));
                reader1.Close();
            }
            if (richTextDescription.Text.Length > 0)
            {
                MySqlDataReader reader2 = mySQL.GetReader(String.Format("UPDATE `priceList` " +
                                                                        "SET Description_Service=\"{0}\" " +
                                                                        "WHERE ID_Service={1} ", richTextDescription.Text, TextIDService.Text));
                reader2.Close();
            }
            if (ListStatus.SelectedIndex > -1)
            {
                MySqlDataReader reader3 = mySQL.GetReader(String.Format("UPDATE `priceList` " +
                                                                        "SET ID_Group_Service={0} " +
                                                                        "WHERE ID_Service={1} ", ListStatus.SelectedIndex + 1, TextIDService.Text));
                reader3.Close();
            }


            UpdateList();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("DELETE FROM `priceList` " +
                                                                   "WHERE ID_Service={0}", TextIDService.Text));
            reader.Close();
            UpdateList();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (TextName.Text.Length < 1 || TextPrice.Text.Length < 1 || ListStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка добавления");
                return;
            }
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("INSERT INTO `priceList`(`Name_Service`, `Price_Service`, `Description_Service`, `ID_Group_Service`) " +
                                                                    "VALUES (\"{0}\",{1},\"{2}\",{3})", TextName.Text, TextPrice.Text, richTextDescription.Text, ListStatus.SelectedIndex+1));
            reader.Close();
            UpdateList();
        }
    }
}
