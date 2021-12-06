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
    public partial class FormAdministrationUsers : System.Windows.Forms.Form
    {
        private ListViewItem rows;

        public FormAdministrationUsers()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            TextLogin.Text = "";
            TextNewLogin.Text = "";
            TextPassword.Text = "";
            ListStatus.SelectedIndex = -1;

            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader("SELECT `Status_User`, `Login_User` FROM `users`");
            ListViewGroup groupAdmin = new(Name = "GroupAdmin", Text = "Администраторы");
            ListViewGroup groupUser = new(Name = "GroupUser", Text = "Пользователи");
            
            


            ListView1.Items.Clear();
            ListView1.Groups.Add(groupAdmin);
            ListView1.Groups.Add(groupUser);
            //Convert.ToString(reader[0])
            while (reader.Read())
            {

                ListViewItem item = new(new string[] {"", Convert.ToString(reader[1])});
                if (Convert.ToInt32(reader[0]) == 1)
                {
                    item.Group = groupAdmin;
                    item.ImageIndex = 0;
                }
                else
                {
                    item.Group = groupUser;
                    item.ImageIndex = 1;
                }

                ListView1.Items.Add(item);
                

            }

            reader.Close();
        }

        private void FormAdministrationUsers_Load(object sender, EventArgs e)
        {
            ImageList imageList = new();
            imageList.ImageSize = new Size(24, 24);
            imageList.Images.Add(new Bitmap(@"src\iconAdmin.png"));
            imageList.Images.Add(new Bitmap(@"src\iconUser.png"));
            Bitmap emptyImage = new(24, 24);
            using (Graphics gr = Graphics.FromImage(emptyImage))
            {
                gr.Clear(Color.White);
            }
            imageList.Images.Add(emptyImage);
            ListView1.SmallImageList = imageList;

            UpdateList();
        }

        private void ButtonUpdateList_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (ListView1.SelectedIndices.Count > 0)
            {
                rows = ListView1.SelectedItems[0];
                TextLogin.Text = Convert.ToString(rows.SubItems[1].Text);
                if (rows.Group.Name == "GroupAdmin")
                    ListStatus.SetSelected(0, true);
                else if (rows.Group.Name == "GroupUser")
                    ListStatus.SetSelected(1, true);

            }
                
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {

            MySQL mySQL = new();
            
            if (TextNewLogin.Text.Length > 0)
            {
                MySqlDataReader reader = mySQL.GetReader(String.Format("UPDATE `users` " +
                                                                        "SET Login_User=\"{0}\" " +
                                                                        "WHERE Login_User=\"{1}\" ", TextNewLogin.Text, TextLogin.Text));
                reader.Close();
            }
            if (TextPassword.Text.Length > 0)
            {
                MySqlDataReader reader1 = mySQL.GetReader(String.Format("UPDATE `users` " +
                                                                        "SET Password_User=\"{0}\" " +
                                                                        "WHERE Login_User=\"{1}\" ", TextPassword.Text, TextLogin.Text));
                reader1.Close();
            }
            if (ListStatus.SelectedIndex > -1)
            {
                MySqlDataReader reader2 = mySQL.GetReader(String.Format("UPDATE `users` " +
                                                                        "SET Status_User=\"{0}\" " +
                                                                        "WHERE Login_User=\"{1}\" ", ListStatus.SelectedIndex + 1, TextLogin.Text));
                reader2.Close();
            }
            
            
            UpdateList();
            

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            MySQL mySQL = new();
            MySqlDataReader reader = mySQL.GetReader(String.Format("DELETE FROM `users` " +
                                                                   "WHERE Login_User=\"{0}\" ", TextLogin.Text));
            reader.Close();
            UpdateList();
        }
    }
}
