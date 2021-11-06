
namespace FortuService
{
    partial class FormPiceList
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
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Общее", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Принтеры", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Компьютеры", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Телефоны", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("Другое", System.Windows.Forms.HorizontalAlignment.Left);
            this.ListView1 = new System.Windows.Forms.ListView();
            this.columnIDService = new System.Windows.Forms.ColumnHeader();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnPrice = new System.Windows.Forms.ColumnHeader();
            this.columnDescription = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.TextIDService = new System.Windows.Forms.Label();
            this.ListStatus = new System.Windows.Forms.ListBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonUpdateList = new System.Windows.Forms.Button();
            this.TextPrice = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDService,
            this.columnName,
            this.columnPrice,
            this.columnDescription});
            this.ListView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListView1.FullRowSelect = true;
            this.ListView1.GridLines = true;
            listViewGroup6.Header = "Общее";
            listViewGroup6.Name = "GroupGeneral";
            listViewGroup7.Header = "Принтеры";
            listViewGroup7.Name = "GroupPrinter";
            listViewGroup8.Header = "Компьютеры";
            listViewGroup8.Name = "GroupPC";
            listViewGroup9.Header = "Телефоны";
            listViewGroup9.Name = "GroupTelephone";
            listViewGroup10.Header = "Другое";
            listViewGroup10.Name = "GroupOther";
            this.ListView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9,
            listViewGroup10});
            this.ListView1.HideSelection = false;
            this.ListView1.LabelEdit = true;
            this.ListView1.Location = new System.Drawing.Point(12, 12);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(533, 389);
            this.ListView1.TabIndex = 1;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnIDService
            // 
            this.columnIDService.Text = "ID";
            this.columnIDService.Width = 40;
            // 
            // columnName
            // 
            this.columnName.Text = "Наименование";
            this.columnName.Width = 150;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Цена";
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Описание";
            this.columnDescription.Width = 250;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextDescription);
            this.groupBox1.Controls.Add(this.TextIDService);
            this.groupBox1.Controls.Add(this.ListStatus);
            this.groupBox1.Controls.Add(this.ButtonDelete);
            this.groupBox1.Controls.Add(this.ButtonEdit);
            this.groupBox1.Controls.Add(this.ButtonUpdateList);
            this.groupBox1.Controls.Add(this.TextPrice);
            this.groupBox1.Controls.Add(this.TextName);
            this.groupBox1.Location = new System.Drawing.Point(574, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 389);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // richTextDescription
            // 
            this.richTextDescription.Location = new System.Drawing.Point(21, 117);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(131, 110);
            this.richTextDescription.TabIndex = 9;
            this.richTextDescription.Text = "Описание";
            // 
            // TextIDService
            // 
            this.TextIDService.AutoSize = true;
            this.TextIDService.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextIDService.Location = new System.Drawing.Point(23, 31);
            this.TextIDService.Name = "TextIDService";
            this.TextIDService.Size = new System.Drawing.Size(0, 15);
            this.TextIDService.TabIndex = 7;
            // 
            // ListStatus
            // 
            this.ListStatus.FormattingEnabled = true;
            this.ListStatus.ItemHeight = 15;
            this.ListStatus.Items.AddRange(new object[] {
            "Общее",
            "Принтеры",
            "Компьютеры",
            "Телефоны",
            "Другое"});
            this.ListStatus.Location = new System.Drawing.Point(21, 233);
            this.ListStatus.Name = "ListStatus";
            this.ListStatus.Size = new System.Drawing.Size(131, 34);
            this.ListStatus.TabIndex = 6;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(20, 311);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(132, 28);
            this.ButtonDelete.TabIndex = 5;
            this.ButtonDelete.Text = "Удалить";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(20, 277);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(132, 28);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            // 
            // ButtonUpdateList
            // 
            this.ButtonUpdateList.Location = new System.Drawing.Point(20, 345);
            this.ButtonUpdateList.Name = "ButtonUpdateList";
            this.ButtonUpdateList.Size = new System.Drawing.Size(132, 28);
            this.ButtonUpdateList.TabIndex = 1;
            this.ButtonUpdateList.Text = "Обновить";
            this.ButtonUpdateList.UseVisualStyleBackColor = true;
            this.ButtonUpdateList.Click += new System.EventHandler(this.ButtonUpdateList_Click);
            // 
            // TextPrice
            // 
            this.TextPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.TextPrice.Location = new System.Drawing.Point(21, 88);
            this.TextPrice.Name = "TextPrice";
            this.TextPrice.PasswordChar = '*';
            this.TextPrice.PlaceholderText = "Цена";
            this.TextPrice.Size = new System.Drawing.Size(131, 23);
            this.TextPrice.TabIndex = 3;
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(22, 59);
            this.TextName.Name = "TextName";
            this.TextName.PlaceholderText = "Наименование";
            this.TextName.Size = new System.Drawing.Size(130, 23);
            this.TextName.TabIndex = 2;
            // 
            // FormPiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListView1);
            this.Name = "FormPiceList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPiceList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListView1;
        private System.Windows.Forms.ColumnHeader columnIDService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TextIDService;
        private System.Windows.Forms.ListBox ListStatus;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonUpdateList;
        private System.Windows.Forms.TextBox TextPrice;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.RichTextBox richTextDescription;
    }
}