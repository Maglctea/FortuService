
namespace FortuService
{
    partial class FormAddTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddTickets));
            this.User = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.MaskedTextBox();
            this.PatronymicClient = new System.Windows.Forms.TextBox();
            this.NameClient = new System.Windows.Forms.TextBox();
            this.SurnameClient = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Device = new System.Windows.Forms.ComboBox();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Service = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.FormattingEnabled = true;
            this.User.Location = new System.Drawing.Point(6, 23);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(146, 23);
            this.User.TabIndex = 3;
            this.User.Text = "Логин мастера";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Telephone);
            this.groupBox1.Controls.Add(this.PatronymicClient);
            this.groupBox1.Controls.Add(this.NameClient);
            this.groupBox1.Controls.Add(this.SurnameClient);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Клиент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Тел.:";
            // 
            // Telephone
            // 
            this.Telephone.Location = new System.Drawing.Point(44, 22);
            this.Telephone.Mask = "+9 (999) 000-0000";
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(108, 23);
            this.Telephone.TabIndex = 14;
            this.Telephone.TextChanged += new System.EventHandler(this.Telephone_TextChanged);
            // 
            // PatronymicClient
            // 
            this.PatronymicClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.PatronymicClient.Location = new System.Drawing.Point(6, 109);
            this.PatronymicClient.Name = "PatronymicClient";
            this.PatronymicClient.PlaceholderText = "Отчество";
            this.PatronymicClient.Size = new System.Drawing.Size(146, 23);
            this.PatronymicClient.TabIndex = 13;
            // 
            // NameClient
            // 
            this.NameClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.NameClient.Location = new System.Drawing.Point(6, 80);
            this.NameClient.Name = "NameClient";
            this.NameClient.PlaceholderText = "Имя";
            this.NameClient.Size = new System.Drawing.Size(146, 23);
            this.NameClient.TabIndex = 3;
            // 
            // SurnameClient
            // 
            this.SurnameClient.Location = new System.Drawing.Point(6, 51);
            this.SurnameClient.Name = "SurnameClient";
            this.SurnameClient.PlaceholderText = "Фамилия";
            this.SurnameClient.Size = new System.Drawing.Size(146, 23);
            this.SurnameClient.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Device);
            this.groupBox2.Controls.Add(this.richTextDescription);
            this.groupBox2.Location = new System.Drawing.Point(183, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 241);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Устройство";
            // 
            // Device
            // 
            this.Device.FormattingEnabled = true;
            this.Device.Location = new System.Drawing.Point(6, 23);
            this.Device.Name = "Device";
            this.Device.Size = new System.Drawing.Size(146, 23);
            this.Device.TabIndex = 7;
            this.Device.Text = "Наименование";
            this.Device.SelectedIndexChanged += new System.EventHandler(this.Device_SelectedIndexChanged);
            // 
            // richTextDescription
            // 
            this.richTextDescription.Location = new System.Drawing.Point(6, 52);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(145, 174);
            this.richTextDescription.TabIndex = 9;
            this.richTextDescription.Text = "Описание:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Service);
            this.groupBox3.Controls.Add(this.User);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 88);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Основное";
            // 
            // Service
            // 
            this.Service.FormattingEnabled = true;
            this.Service.Location = new System.Drawing.Point(7, 52);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(146, 23);
            this.Service.TabIndex = 10;
            this.Service.Text = "Услуга";
            // 
            // FormAddTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 314);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddTickets";
            this.Text = "Создать тикет";
            this.Load += new System.EventHandler(this.FormAddTickets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox User;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PatronymicClient;
        private System.Windows.Forms.TextBox NameClient;
        private System.Windows.Forms.TextBox SurnameClient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox Service;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Telephone;
        private System.Windows.Forms.ComboBox Device;
    }
}