
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
            this.TextNewLogin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextLogin = new System.Windows.Forms.Label();
            this.ListStatus = new System.Windows.Forms.ListBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            listViewGroup1.Name = "GroupAdmins";
            listViewGroup2.Header = "Пользователи";
            listViewGroup2.Name = "GroupUsers";
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
            this.columnLogin.Width = 180;
            // 
            // ButtonUpdateList
            // 
            this.ButtonUpdateList.Location = new System.Drawing.Point(24, 241);
            this.ButtonUpdateList.Name = "ButtonUpdateList";
            this.ButtonUpdateList.Size = new System.Drawing.Size(129, 28);
            this.ButtonUpdateList.TabIndex = 1;
            this.ButtonUpdateList.Text = "Обновить";
            this.ButtonUpdateList.UseVisualStyleBackColor = true;
            this.ButtonUpdateList.Click += new System.EventHandler(this.ButtonUpdateList_Click);
            // 
            // TextNewLogin
            // 
            this.TextNewLogin.Location = new System.Drawing.Point(23, 59);
            this.TextNewLogin.Name = "TextNewLogin";
            this.TextNewLogin.PlaceholderText = "Логин";
            this.TextNewLogin.Size = new System.Drawing.Size(130, 23);
            this.TextNewLogin.TabIndex = 2;
            this.TextNewLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TextLogin);
            this.groupBox1.Controls.Add(this.ListStatus);
            this.groupBox1.Controls.Add(this.ButtonDelete);
            this.groupBox1.Controls.Add(this.ButtonEdit);
            this.groupBox1.Controls.Add(this.ButtonUpdateList);
            this.groupBox1.Controls.Add(this.TextPassword);
            this.groupBox1.Controls.Add(this.TextNewLogin);
            this.groupBox1.Location = new System.Drawing.Point(294, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 389);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // TextLogin
            // 
            this.TextLogin.AutoSize = true;
            this.TextLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextLogin.Location = new System.Drawing.Point(23, 31);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(0, 15);
            this.TextLogin.TabIndex = 7;
            // 
            // ListStatus
            // 
            this.ListStatus.FormattingEnabled = true;
            this.ListStatus.ItemHeight = 15;
            this.ListStatus.Items.AddRange(new object[] {
            "Администратор",
            "Пользователь"});
            this.ListStatus.Location = new System.Drawing.Point(24, 117);
            this.ListStatus.Name = "ListStatus";
            this.ListStatus.Size = new System.Drawing.Size(129, 34);
            this.ListStatus.TabIndex = 6;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(23, 207);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(130, 28);
            this.ButtonDelete.TabIndex = 5;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(23, 173);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(130, 28);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(23, 88);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.PlaceholderText = "Пароль";
            this.TextPassword.Size = new System.Drawing.Size(130, 23);
            this.TextPassword.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAdministrationUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 427);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListView1);
            this.Name = "FormAdministrationUsers";
            this.Text = "FormAdministrationUsers";
            this.Load += new System.EventHandler(this.FormAdministrationUsers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonUpdateList;
        private System.Windows.Forms.ColumnHeader columnIcon;
        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader columnLogin;
        private System.Windows.Forms.TextBox TextNewLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListStatus;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label TextLogin;
        private System.Windows.Forms.Button button1;
    }
}