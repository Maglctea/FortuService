
namespace FortuService
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Активные объявления", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Неактивные объявления", System.Windows.Forms.HorizontalAlignment.Left);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.тикетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ОтобразитьТикетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СоздатьТикетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аккаунтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ВойтиВАккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьАккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеАккаунтомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьАккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиИзАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.АдминистрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.УправлениеПользователямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ПрайслистToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ListView = new System.Windows.Forms.ListView();
            this.columnIDTicket = new System.Windows.Forms.ColumnHeader();
            this.columnIDDevice = new System.Windows.Forms.ColumnHeader();
            this.columnNameDevice = new System.Windows.Forms.ColumnHeader();
            this.Ticket = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonShowTicket = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.MaskedTextBox();
            this.PatronymicClient = new System.Windows.Forms.TextBox();
            this.NameClient = new System.Windows.Forms.TextBox();
            this.SurnameClient = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.IdDevice = new System.Windows.Forms.TextBox();
            this.NameDevice = new System.Windows.Forms.TextBox();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.TextBox();
            this.Service = new System.Windows.Forms.TextBox();
            this.TicketClose = new System.Windows.Forms.Button();
            this.TicketOpen = new System.Windows.Forms.Button();
            this.TicketDelete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тикетыToolStripMenuItem,
            this.аккаунтыToolStripMenuItem,
            this.АдминистрированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // тикетыToolStripMenuItem
            // 
            this.тикетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ОтобразитьТикетыToolStripMenuItem,
            this.СоздатьТикетToolStripMenuItem});
            this.тикетыToolStripMenuItem.Name = "тикетыToolStripMenuItem";
            this.тикетыToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.тикетыToolStripMenuItem.Text = "Тикеты";
            // 
            // ОтобразитьТикетыToolStripMenuItem
            // 
            this.ОтобразитьТикетыToolStripMenuItem.Name = "ОтобразитьТикетыToolStripMenuItem";
            this.ОтобразитьТикетыToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.ОтобразитьТикетыToolStripMenuItem.Text = "Отобразить тикеты";
            this.ОтобразитьТикетыToolStripMenuItem.Click += new System.EventHandler(this.ОтобразитьТикетыToolStripMenuItem_Click);
            // 
            // СоздатьТикетToolStripMenuItem
            // 
            this.СоздатьТикетToolStripMenuItem.Name = "СоздатьТикетToolStripMenuItem";
            this.СоздатьТикетToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.СоздатьТикетToolStripMenuItem.Text = "Создать тикет";
            this.СоздатьТикетToolStripMenuItem.Click += new System.EventHandler(this.СоздатьТикетToolStripMenuItem_Click);
            // 
            // аккаунтыToolStripMenuItem
            // 
            this.аккаунтыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ВойтиВАккаунтToolStripMenuItem,
            this.создатьАккаунтToolStripMenuItem,
            this.управлениеАккаунтомToolStripMenuItem,
            this.выйтиИзАккаунтаToolStripMenuItem});
            this.аккаунтыToolStripMenuItem.Name = "аккаунтыToolStripMenuItem";
            this.аккаунтыToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.аккаунтыToolStripMenuItem.Text = "Аккаунты";
            // 
            // ВойтиВАккаунтToolStripMenuItem
            // 
            this.ВойтиВАккаунтToolStripMenuItem.Name = "ВойтиВАккаунтToolStripMenuItem";
            this.ВойтиВАккаунтToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.ВойтиВАккаунтToolStripMenuItem.Text = "Войти в аккаунт";
            this.ВойтиВАккаунтToolStripMenuItem.Click += new System.EventHandler(this.ВойтиВАккаунтToolStripMenuItem_Click);
            // 
            // создатьАккаунтToolStripMenuItem
            // 
            this.создатьАккаунтToolStripMenuItem.Name = "создатьАккаунтToolStripMenuItem";
            this.создатьАккаунтToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.создатьАккаунтToolStripMenuItem.Text = "Создать аккаунт";
            this.создатьАккаунтToolStripMenuItem.Click += new System.EventHandler(this.СоздатьАккаунтToolStripMenuItem_Click);
            // 
            // управлениеАккаунтомToolStripMenuItem
            // 
            this.управлениеАккаунтомToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьДанныеToolStripMenuItem,
            this.удалитьАккаунтToolStripMenuItem});
            this.управлениеАккаунтомToolStripMenuItem.Name = "управлениеАккаунтомToolStripMenuItem";
            this.управлениеАккаунтомToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.управлениеАккаунтомToolStripMenuItem.Text = "Управление аккаунтом";
            // 
            // изменитьДанныеToolStripMenuItem
            // 
            this.изменитьДанныеToolStripMenuItem.Name = "изменитьДанныеToolStripMenuItem";
            this.изменитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.изменитьДанныеToolStripMenuItem.Text = "Изменить данные";
            this.изменитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.ИзменитьДанныеToolStripMenuItem_Click);
            // 
            // удалитьАккаунтToolStripMenuItem
            // 
            this.удалитьАккаунтToolStripMenuItem.Name = "удалитьАккаунтToolStripMenuItem";
            this.удалитьАккаунтToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьАккаунтToolStripMenuItem.Text = "Удалить аккаунт";
            this.удалитьАккаунтToolStripMenuItem.Click += new System.EventHandler(this.УдалитьАккаунтToolStripMenuItem_Click);
            // 
            // выйтиИзАккаунтаToolStripMenuItem
            // 
            this.выйтиИзАккаунтаToolStripMenuItem.Name = "выйтиИзАккаунтаToolStripMenuItem";
            this.выйтиИзАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.выйтиИзАккаунтаToolStripMenuItem.Text = "Выйти из аккаунта";
            this.выйтиИзАккаунтаToolStripMenuItem.Click += new System.EventHandler(this.ВыйтиИзАккаунтаToolStripMenuItem_Click);
            // 
            // АдминистрированиеToolStripMenuItem
            // 
            this.АдминистрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.УправлениеПользователямиToolStripMenuItem,
            this.ПрайслистToolStripMenuItem});
            this.АдминистрированиеToolStripMenuItem.Name = "АдминистрированиеToolStripMenuItem";
            this.АдминистрированиеToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.АдминистрированиеToolStripMenuItem.Text = "Администрирование";
            this.АдминистрированиеToolStripMenuItem.Visible = false;
            // 
            // УправлениеПользователямиToolStripMenuItem
            // 
            this.УправлениеПользователямиToolStripMenuItem.Name = "УправлениеПользователямиToolStripMenuItem";
            this.УправлениеПользователямиToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.УправлениеПользователямиToolStripMenuItem.Text = "Управление пользователями";
            this.УправлениеПользователямиToolStripMenuItem.Click += new System.EventHandler(this.УправлениеПользователямиToolStripMenuItem_Click);
            // 
            // ПрайслистToolStripMenuItem
            // 
            this.ПрайслистToolStripMenuItem.Name = "ПрайслистToolStripMenuItem";
            this.ПрайслистToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.ПрайслистToolStripMenuItem.Text = "Прайслист";
            this.ПрайслистToolStripMenuItem.Click += new System.EventHandler(this.ПрайслистToolStripMenuItem_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.Location = new System.Drawing.Point(584, 9);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(104, 17);
            this.UserNameLabel.TabIndex = 6;
            this.UserNameLabel.Text = "Выполнить вход";
            this.UserNameLabel.Click += new System.EventHandler(this.ВойтиВАккаунтToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Turquoise;
            this.imageList1.Images.SetKeyName(0, "Trans01.jpg");
            this.imageList1.Images.SetKeyName(1, "Search01.jpg");
            this.imageList1.Images.SetKeyName(2, "orig2.png");
            // 
            // ListView
            // 
            this.ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDTicket,
            this.columnIDDevice,
            this.columnNameDevice});
            this.ListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListView.FullRowSelect = true;
            this.ListView.GridLines = true;
            listViewGroup1.Header = "Активные объявления";
            listViewGroup1.Name = "GroupActiveTickets";
            listViewGroup2.Header = "Неактивные объявления";
            listViewGroup2.Name = "GroupNoActiveTickets";
            this.ListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.ListView.HideSelection = false;
            this.ListView.LabelEdit = true;
            this.ListView.Location = new System.Drawing.Point(0, 27);
            this.ListView.MultiSelect = false;
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(394, 411);
            this.ListView.TabIndex = 7;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.View = System.Windows.Forms.View.Details;
            this.ListView.SelectedIndexChanged += new System.EventHandler(this.ListView_SelectedIndexChanged);
            // 
            // columnIDTicket
            // 
            this.columnIDTicket.Text = "ID Тикета";
            this.columnIDTicket.Width = 70;
            // 
            // columnIDDevice
            // 
            this.columnIDDevice.Text = "ID девайса";
            this.columnIDDevice.Width = 70;
            // 
            // columnNameDevice
            // 
            this.columnNameDevice.Text = "Наименование девайса";
            this.columnNameDevice.Width = 250;
            // 
            // Ticket
            // 
            this.Ticket.Location = new System.Drawing.Point(6, 22);
            this.Ticket.Name = "Ticket";
            this.Ticket.PlaceholderText = "Номер тикета";
            this.Ticket.Size = new System.Drawing.Size(82, 23);
            this.Ticket.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButtonShowTicket);
            this.groupBox1.Controls.Add(this.Ticket);
            this.groupBox1.Location = new System.Drawing.Point(400, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 59);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // ButtonShowTicket
            // 
            this.ButtonShowTicket.Location = new System.Drawing.Point(94, 22);
            this.ButtonShowTicket.Name = "ButtonShowTicket";
            this.ButtonShowTicket.Size = new System.Drawing.Size(80, 23);
            this.ButtonShowTicket.TabIndex = 9;
            this.ButtonShowTicket.Text = "Отобразить";
            this.ButtonShowTicket.UseVisualStyleBackColor = true;
            this.ButtonShowTicket.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Telephone);
            this.groupBox2.Controls.Add(this.PatronymicClient);
            this.groupBox2.Controls.Add(this.NameClient);
            this.groupBox2.Controls.Add(this.SurnameClient);
            this.groupBox2.Location = new System.Drawing.Point(400, 216);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 147);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Клиент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Телефон:";
            // 
            // Telephone
            // 
            this.Telephone.Enabled = false;
            this.Telephone.Location = new System.Drawing.Point(73, 22);
            this.Telephone.Mask = "+9 (999) 000-0000";
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(101, 23);
            this.Telephone.TabIndex = 14;
            // 
            // PatronymicClient
            // 
            this.PatronymicClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.PatronymicClient.Enabled = false;
            this.PatronymicClient.Location = new System.Drawing.Point(6, 109);
            this.PatronymicClient.Name = "PatronymicClient";
            this.PatronymicClient.PlaceholderText = "Отчество";
            this.PatronymicClient.Size = new System.Drawing.Size(168, 23);
            this.PatronymicClient.TabIndex = 13;
            // 
            // NameClient
            // 
            this.NameClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.NameClient.Enabled = false;
            this.NameClient.Location = new System.Drawing.Point(6, 80);
            this.NameClient.Name = "NameClient";
            this.NameClient.PlaceholderText = "Имя";
            this.NameClient.Size = new System.Drawing.Size(168, 23);
            this.NameClient.TabIndex = 3;
            // 
            // SurnameClient
            // 
            this.SurnameClient.Enabled = false;
            this.SurnameClient.Location = new System.Drawing.Point(6, 51);
            this.SurnameClient.Name = "SurnameClient";
            this.SurnameClient.PlaceholderText = "Фамилия";
            this.SurnameClient.Size = new System.Drawing.Size(168, 23);
            this.SurnameClient.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.IdDevice);
            this.groupBox3.Controls.Add(this.NameDevice);
            this.groupBox3.Controls.Add(this.richTextDescription);
            this.groupBox3.Location = new System.Drawing.Point(590, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 336);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Устройство";
            // 
            // IdDevice
            // 
            this.IdDevice.Enabled = false;
            this.IdDevice.Location = new System.Drawing.Point(6, 22);
            this.IdDevice.Name = "IdDevice";
            this.IdDevice.PlaceholderText = "ID Устройства";
            this.IdDevice.Size = new System.Drawing.Size(145, 23);
            this.IdDevice.TabIndex = 11;
            // 
            // NameDevice
            // 
            this.NameDevice.Enabled = false;
            this.NameDevice.Location = new System.Drawing.Point(6, 51);
            this.NameDevice.Name = "NameDevice";
            this.NameDevice.PlaceholderText = "Наименование девайса";
            this.NameDevice.Size = new System.Drawing.Size(145, 23);
            this.NameDevice.TabIndex = 10;
            // 
            // richTextDescription
            // 
            this.richTextDescription.Enabled = false;
            this.richTextDescription.Location = new System.Drawing.Point(6, 80);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(145, 241);
            this.richTextDescription.TabIndex = 9;
            this.richTextDescription.Text = "Описание:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.Price);
            this.groupBox4.Controls.Add(this.User);
            this.groupBox4.Controls.Add(this.Service);
            this.groupBox4.Location = new System.Drawing.Point(400, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 118);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Основное";
            this.groupBox4.Enter += new System.EventHandler(this.GroupBox4_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Стоимость:";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(89, 81);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(85, 23);
            this.Price.TabIndex = 5;
            // 
            // User
            // 
            this.User.Enabled = false;
            this.User.Location = new System.Drawing.Point(7, 22);
            this.User.Name = "User";
            this.User.PlaceholderText = "Мастер";
            this.User.Size = new System.Drawing.Size(167, 23);
            this.User.TabIndex = 4;
            // 
            // Service
            // 
            this.Service.Enabled = false;
            this.Service.Location = new System.Drawing.Point(7, 52);
            this.Service.Name = "Service";
            this.Service.PlaceholderText = "Услуга";
            this.Service.Size = new System.Drawing.Size(167, 23);
            this.Service.TabIndex = 3;
            // 
            // TicketClose
            // 
            this.TicketClose.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TicketClose.Location = new System.Drawing.Point(400, 369);
            this.TicketClose.Name = "TicketClose";
            this.TicketClose.Size = new System.Drawing.Size(112, 32);
            this.TicketClose.TabIndex = 19;
            this.TicketClose.Text = "Закрыть тикет";
            this.TicketClose.UseVisualStyleBackColor = true;
            this.TicketClose.Click += new System.EventHandler(this.TicketClose_Click);
            // 
            // TicketOpen
            // 
            this.TicketOpen.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TicketOpen.Location = new System.Drawing.Point(518, 369);
            this.TicketOpen.Name = "TicketOpen";
            this.TicketOpen.Size = new System.Drawing.Size(112, 32);
            this.TicketOpen.TabIndex = 20;
            this.TicketOpen.Text = "Открыть тикет";
            this.TicketOpen.UseVisualStyleBackColor = true;
            this.TicketOpen.Click += new System.EventHandler(this.TicketOpen_Click);
            // 
            // TicketDelete
            // 
            this.TicketDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TicketDelete.Location = new System.Drawing.Point(636, 369);
            this.TicketDelete.Name = "TicketDelete";
            this.TicketDelete.Size = new System.Drawing.Size(112, 32);
            this.TicketDelete.TabIndex = 21;
            this.TicketDelete.Text = "Удалить тикет";
            this.TicketDelete.UseVisualStyleBackColor = true;
            this.TicketDelete.Click += new System.EventHandler(this.TicketDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.TicketDelete);
            this.Controls.Add(this.TicketOpen);
            this.Controls.Add(this.TicketClose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListView);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FortuService";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem тикетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ОтобразитьТикетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СоздатьТикетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аккаунтыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ВойтиВАккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьАккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеАккаунтомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьДанныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьАккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиИзАккаунтаToolStripMenuItem;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.ToolStripMenuItem АдминистрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem УправлениеПользователямиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ПрайслистToolStripMenuItem;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ColumnHeader columnIDTicket;
        private System.Windows.Forms.ColumnHeader columnIDDevice;
        private System.Windows.Forms.ColumnHeader columnNameDevice;
        private System.Windows.Forms.TextBox Ticket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonShowTicket;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Telephone;
        private System.Windows.Forms.TextBox PatronymicClient;
        private System.Windows.Forms.TextBox NameClient;
        private System.Windows.Forms.TextBox SurnameClient;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox NameDevice;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox Service;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox IdDevice;
        private System.Windows.Forms.Button TicketClose;
        private System.Windows.Forms.Button TicketOpen;
        private System.Windows.Forms.Button TicketDelete;
    }
}

