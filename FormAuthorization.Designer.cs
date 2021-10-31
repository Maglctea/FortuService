
namespace FortuService
{
    partial class FormAuthorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.LoginAuthorization = new System.Windows.Forms.TextBox();
            this.PasswordAuthorization = new System.Windows.Forms.TextBox();
            this.ButtonAuthorization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginAuthorization
            // 
            this.LoginAuthorization.Location = new System.Drawing.Point(12, 19);
            this.LoginAuthorization.Name = "LoginAuthorization";
            this.LoginAuthorization.PlaceholderText = "Логин";
            this.LoginAuthorization.Size = new System.Drawing.Size(181, 23);
            this.LoginAuthorization.TabIndex = 0;
            // 
            // PasswordAuthorization
            // 
            this.PasswordAuthorization.Location = new System.Drawing.Point(12, 48);
            this.PasswordAuthorization.Name = "PasswordAuthorization";
            this.PasswordAuthorization.PasswordChar = '*';
            this.PasswordAuthorization.PlaceholderText = "Пароль";
            this.PasswordAuthorization.Size = new System.Drawing.Size(181, 23);
            this.PasswordAuthorization.TabIndex = 1;
            // 
            // ButtonAuthorization
            // 
            this.ButtonAuthorization.Location = new System.Drawing.Point(12, 77);
            this.ButtonAuthorization.Name = "ButtonAuthorization";
            this.ButtonAuthorization.Size = new System.Drawing.Size(181, 27);
            this.ButtonAuthorization.TabIndex = 2;
            this.ButtonAuthorization.Text = "Войти";
            this.ButtonAuthorization.UseVisualStyleBackColor = true;
            this.ButtonAuthorization.Click += new System.EventHandler(this.ButtonAuthorization_Click);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 126);
            this.Controls.Add(this.ButtonAuthorization);
            this.Controls.Add(this.LoginAuthorization);
            this.Controls.Add(this.PasswordAuthorization);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAuthorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox LoginAuthorization;
        private System.Windows.Forms.TextBox PasswordAuthorization;
        private System.Windows.Forms.Button ButtonAuthorization;
    }
}