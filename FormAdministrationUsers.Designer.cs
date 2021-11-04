
namespace FortuService
{
    partial class FormAdministrationUsers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Администраторы", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Пользователи", System.Windows.Forms.HorizontalAlignment.Left);
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnIcon = new System.Windows.Forms.ColumnHeader();
            this.columnLogin = new System.Windows.Forms.ColumnHeader();
            this.ButtonUpdateList = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIcon,
            this.columnLogin});
            this.ListView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            listViewGroup1.Header = "Администраторы";
            listViewGroup1.Name = "GrouAdmins";
            listViewGroup2.Header = "Пользователи";
            listViewGroup2.Name = "GrouUsers";
            this.ListView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.ListView1.HideSelection = false;
            this.ListView1.LabelEdit = true;
            this.ListView1.Location = new System.Drawing.Point(18, 13);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(248, 388);
            this.ListView1.TabIndex = 0;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView1_ItemSelectionChanged);
            // 
            // columnIcon
            // 
            this.columnIcon.Text = "Иконка";
            this.columnIcon.Width = 55;
            // 
            // columnLogin
            // 
            this.columnLogin.Text = "Логин";
            this.columnLogin.Width = 150;
            // 
            // ButtonUpdateList
            // 
            this.ButtonUpdateList.Location = new System.Drawing.Point(309, 18);
            this.ButtonUpdateList.Name = "ButtonUpdateList";
            this.ButtonUpdateList.Size = new System.Drawing.Size(117, 33);
            this.ButtonUpdateList.TabIndex = 1;
            this.ButtonUpdateList.Text = "Обновить";
            this.ButtonUpdateList.UseVisualStyleBackColor = true;
            this.ButtonUpdateList.Click += new System.EventHandler(this.ButtonUpdateList_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 23);
            this.textBox1.TabIndex = 2;
            // 
            // FormAdministrationUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonUpdateList);
            this.Controls.Add(this.ListView1);
            this.Name = "FormAdministrationUsers";
            this.Text = "FormAdministrationUsers";
            this.Load += new System.EventHandler(this.FormAdministrationUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonUpdateList;
        private System.Windows.Forms.ColumnHeader columnIcon;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnLogin;
    }
}