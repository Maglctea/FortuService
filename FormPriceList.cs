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
            TextName.Text = "";
            TextPrice.Text = "";
            richTextDescription.Text = "";
            ListStatus.SelectedIndex = -1;

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
                if (rows.Group.Name == "groupGeneral")
                    ListStatus.SetSelected(0, true);
                else if (rows.Group.Name == "groupPrinter")
                    ListStatus.SetSelected(1, true);
                else if (rows.Group.Name == "groupPC")
                    ListStatus.SetSelected(2, true);
                else if (rows.Group.Name == "groupTelephone")
                    ListStatus.SetSelected(3, true);
                else 
                    ListStatus.SetSelected(4, true);

            }
        }
    }
}
