
namespace FortuService
{
    partial class FormDeleteUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteUser));
            this.PasswordUser = new System.Windows.Forms.TextBox();
            this.LoginUser = new System.Windows.Forms.Label();
            this.EditLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordUser
            // 
            this.PasswordUser.Location = new System.Drawing.Point(12, 29);
            this.PasswordUser.Name = "PasswordUser";
            this.PasswordUser.PasswordChar = '*';
            this.PasswordUser.PlaceholderText = "Пароль";
            this.PasswordUser.Size = new System.Drawing.Size(181, 23);
            this.PasswordUser.TabIndex = 10;
            // 
            // LoginUser
            // 
            this.LoginUser.AutoSize = true;
            this.LoginUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginUser.Location = new System.Drawing.Point(12, 9);
            this.LoginUser.Name = "LoginUser";
            this.LoginUser.Size = new System.Drawing.Size(73, 17);
            this.LoginUser.TabIndex = 11;
            this.LoginUser.Text = "LoginUser1";
            this.LoginUser.Click += new System.EventHandler(this.LoginUser_Click);
            // 
            // EditLoginButton
            // 
            this.EditLoginButton.Location = new System.Drawing.Point(12, 58);
            this.EditLoginButton.Name = "EditLoginButton";
            this.EditLoginButton.Size = new System.Drawing.Size(181, 27);
            this.EditLoginButton.TabIndex = 12;
            this.EditLoginButton.Text = "Удалить аккаунт";
            this.EditLoginButton.UseVisualStyleBackColor = true;
            this.EditLoginButton.Click += new System.EventHandler(this.EditLoginButton_Click);
            // 
            // FormDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 99);
            this.Controls.Add(this.EditLoginButton);
            this.Controls.Add(this.LoginUser);
            this.Controls.Add(this.PasswordUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDeleteUser";
            this.Text = "Удаление пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordUser;
        public System.Windows.Forms.Label LoginUser;
        private System.Windows.Forms.Button EditLoginButton;
    }
}