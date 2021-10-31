
namespace FortuService
{
    partial class FormRegistrationUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrationUser));
            this.LoginRegistration = new System.Windows.Forms.TextBox();
            this.PasswordRegistration1 = new System.Windows.Forms.TextBox();
            this.PasswordRegistration2 = new System.Windows.Forms.TextBox();
            this.ButtonRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginRegistration
            // 
            this.LoginRegistration.Location = new System.Drawing.Point(12, 12);
            this.LoginRegistration.Name = "LoginRegistration";
            this.LoginRegistration.PlaceholderText = "Логин";
            this.LoginRegistration.Size = new System.Drawing.Size(181, 23);
            this.LoginRegistration.TabIndex = 1;
            // 
            // PasswordRegistration1
            // 
            this.PasswordRegistration1.Location = new System.Drawing.Point(12, 41);
            this.PasswordRegistration1.Name = "PasswordRegistration1";
            this.PasswordRegistration1.PasswordChar = '*';
            this.PasswordRegistration1.PlaceholderText = "Пароль";
            this.PasswordRegistration1.Size = new System.Drawing.Size(181, 23);
            this.PasswordRegistration1.TabIndex = 2;
            // 
            // PasswordRegistration2
            // 
            this.PasswordRegistration2.Location = new System.Drawing.Point(12, 70);
            this.PasswordRegistration2.Name = "PasswordRegistration2";
            this.PasswordRegistration2.PasswordChar = '*';
            this.PasswordRegistration2.PlaceholderText = "Повторите пароль";
            this.PasswordRegistration2.Size = new System.Drawing.Size(181, 23);
            this.PasswordRegistration2.TabIndex = 3;
            // 
            // ButtonRegistration
            // 
            this.ButtonRegistration.Location = new System.Drawing.Point(12, 99);
            this.ButtonRegistration.Name = "ButtonRegistration";
            this.ButtonRegistration.Size = new System.Drawing.Size(181, 27);
            this.ButtonRegistration.TabIndex = 4;
            this.ButtonRegistration.Text = "Создать";
            this.ButtonRegistration.UseVisualStyleBackColor = true;
            this.ButtonRegistration.Click += new System.EventHandler(this.ButtonAuthorization_Click);
            // 
            // FormRegistrationUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 149);
            this.Controls.Add(this.ButtonRegistration);
            this.Controls.Add(this.PasswordRegistration2);
            this.Controls.Add(this.PasswordRegistration1);
            this.Controls.Add(this.LoginRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegistrationUser";
            this.Text = "Регистрация пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginRegistration;
        private System.Windows.Forms.TextBox PasswordRegistration1;
        private System.Windows.Forms.TextBox PasswordRegistration2;
        private System.Windows.Forms.Button ButtonRegistration;
    }
}