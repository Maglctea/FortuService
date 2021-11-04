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
    public partial class FormAdministrationUsers : Form
    {
        private ListViewItem rows;

        public FormAdministrationUsers()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
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
            imageList.Images.Add(new Bitmap(@"..\..\..\src\iconAdmin.png"));
            imageList.Images.Add(new Bitmap(@"..\..\..\src\iconUser.png"));
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
                textBox1.Text = Convert.ToString(rows.SubItems[1].Text);
            }
                
        }
    }
}
