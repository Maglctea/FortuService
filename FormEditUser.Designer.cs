
namespace FortuService
{
    partial class FormEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditUser));
            this.EditButtonPassword = new System.Windows.Forms.Button();
            this.PasswordUser1 = new System.Windows.Forms.TextBox();
            this.NewPasswordUser = new System.Windows.Forms.TextBox();
            this.EditPasswordUser = new System.Windows.Forms.GroupBox();
            this.PasswordUser2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LoginUser1 = new System.Windows.Forms.Label();
            this.EditLoginButton = new System.Windows.Forms.Button();
            this.PasswordUser = new System.Windows.Forms.TextBox();
            this.LoginUser2 = new System.Windows.Forms.TextBox();
            this.EditPasswordUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditButtonPassword
            // 
            this.EditButtonPassword.Location = new System.Drawing.Point(6, 126);
            this.EditButtonPassword.Name = "EditButtonPassword";
            this.EditButtonPassword.Size = new System.Drawing.Size(181, 27);
            this.EditButtonPassword.TabIndex = 8;
            this.EditButtonPassword.Text = "Изменить";
            this.EditButtonPassword.UseVisualStyleBackColor = true;
            this.EditButtonPassword.Click += new System.EventHandler(this.EditButtonPassword_Click);
            // 
            // PasswordUser1
            // 
            this.PasswordUser1.Location = new System.Drawing.Point(6, 59);
            this.PasswordUser1.Name = "PasswordUser1";
            this.PasswordUser1.PasswordChar = '*';
            this.PasswordUser1.PlaceholderText = "Новый пароль";
            this.PasswordUser1.Size = new System.Drawing.Size(181, 23);
            this.PasswordUser1.TabIndex = 7;
            // 
            // NewPasswordUser
            // 
            this.NewPasswordUser.Location = new System.Drawing.Point(6, 30);
            this.NewPasswordUser.Name = "NewPasswordUser";
            this.NewPasswordUser.PasswordChar = '*';
            this.NewPasswordUser.PlaceholderText = "Старый пароль";
            this.NewPasswordUser.Size = new System.Drawing.Size(181, 23);
            this.NewPasswordUser.TabIndex = 6;
            // 
            // EditPasswordUser
            // 
            this.EditPasswordUser.Controls.Add(this.PasswordUser2);
            this.EditPasswordUser.Controls.Add(this.PasswordUser1);
            this.EditPasswordUser.Controls.Add(this.EditButtonPassword);
            this.EditPasswordUser.Controls.Add(this.NewPasswordUser);
            this.EditPasswordUser.Location = new System.Drawing.Point(235, 22);
            this.EditPasswordUser.Name = "EditPasswordUser";
            this.EditPasswordUser.Size = new System.Drawing.Size(196, 182);
            this.EditPasswordUser.TabIndex = 9;
            this.EditPasswordUser.TabStop = false;
            this.EditPasswordUser.Text = "Изменить пароль";
            // 
            // PasswordUser2
            // 
            this.PasswordUser2.Location = new System.Drawing.Point(6, 88);
            this.PasswordUser2.Name = "PasswordUser2";
            this.PasswordUser2.PasswordChar = '*';
            this.PasswordUser2.PlaceholderText = "Повторите пароль";
            this.PasswordUser2.Size = new System.Drawing.Size(181, 23);
            this.PasswordUser2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LoginUser1);
            this.groupBox1.Controls.Add(this.EditLoginButton);
            this.groupBox1.Controls.Add(this.PasswordUser);
            this.groupBox1.Controls.Add(this.LoginUser2);
            this.groupBox1.Location = new System.Drawing.Point(14, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 182);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Изменить логин";
            // 
            // LoginUser1
            // 
            this.LoginUser1.AutoSize = true;
            this.LoginUser1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginUser1.Location = new System.Drawing.Point(6, 30);
            this.LoginUser1.Name = "LoginUser1";
            this.LoginUser1.Size = new System.Drawing.Size(73, 17);
            this.LoginUser1.TabIndex = 11;
            this.LoginUser1.Text = "LoginUser1";
            // 
            // EditLoginButton
            // 
            this.EditLoginButton.Location = new System.Drawing.Point(6, 126);
            this.EditLoginButton.Name = "EditLoginButton";
            this.EditLoginButton.Size = new System.Drawing.Size(181, 27);
            this.EditLoginButton.TabIndex = 10;
            this.EditLoginButton.Text = "Изменить";
            this.EditLoginButton.UseVisualStyleBackColor = true;
            this.EditLoginButton.Click += new System.EventHandler(this.EditLoginButton_Click);
            // 
            // PasswordUser
            // 
            this.PasswordUser.Location = new System.Drawing.Point(6, 88);
            this.PasswordUser.Name = "PasswordUser";
            this.PasswordUser.PasswordChar = '*';
            this.PasswordUser.PlaceholderText = "Пароль";
            this.PasswordUser.Size = new System.Drawing.Size(181, 23);
            this.PasswordUser.TabIndex = 10;
            // 
            // LoginUser2
            // 
            this.LoginUser2.Location = new System.Drawing.Point(6, 59);
            this.LoginUser2.Name = "LoginUser2";
            this.LoginUser2.PlaceholderText = "Новый логин";
            this.LoginUser2.Size = new System.Drawing.Size(181, 23);
            this.LoginUser2.TabIndex = 6;
            // 
            // FormEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 225);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EditPasswordUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEditUser";
            this.Text = "Изменить данные аккаунта";
            this.EditPasswordUser.ResumeLayout(false);
            this.EditPasswordUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditButtonPassword;
        private System.Windows.Forms.TextBox PasswordUser1;
        private System.Windows.Forms.TextBox NewPasswordUser;
        private System.Windows.Forms.GroupBox EditPasswordUser;
        private System.Windows.Forms.TextBox PasswordUser2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PasswordUser;
        private System.Windows.Forms.TextBox LoginUser2;
        private System.Windows.Forms.Button EditLoginButton;
        private System.Windows.Forms.Label LoginUser1;
    }
}