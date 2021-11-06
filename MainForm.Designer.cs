
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
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.ОтобразитьТикетыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ОтобразитьТикетыToolStripMenuItem.Text = "Отобразить тикеты";
            // 
            // СоздатьТикетToolStripMenuItem
            // 
            this.СоздатьТикетToolStripMenuItem.Name = "СоздатьТикетToolStripMenuItem";
            this.СоздатьТикетToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FortuService";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

