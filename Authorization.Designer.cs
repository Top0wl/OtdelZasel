using System.ComponentModel;

namespace OtdelZasel
{
    partial class Authorization
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.Auth_Button = new System.Windows.Forms.Button();
            this.Registration_Button = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Auth_Button
            // 
            this.Auth_Button.Location = new System.Drawing.Point(155, 295);
            this.Auth_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Auth_Button.Name = "Auth_Button";
            this.Auth_Button.Size = new System.Drawing.Size(276, 96);
            this.Auth_Button.TabIndex = 0;
            this.Auth_Button.Text = "Войти";
            this.Auth_Button.UseVisualStyleBackColor = true;
            this.Auth_Button.Click += new System.EventHandler(this.Auth_Button_Click);
            // 
            // Registration_Button
            // 
            this.Registration_Button.Location = new System.Drawing.Point(422, 479);
            this.Registration_Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Registration_Button.Name = "Registration_Button";
            this.Registration_Button.Size = new System.Drawing.Size(153, 27);
            this.Registration_Button.TabIndex = 1;
            this.Registration_Button.Text = "Зарегистрироваться";
            this.Registration_Button.UseVisualStyleBackColor = true;
            this.Registration_Button.Click += new System.EventHandler(this.Registration_Button_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(183, 130);
            this.login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(224, 23);
            this.login.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(183, 211);
            this.password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(224, 23);
            this.password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(115, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(115, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Registration_Button);
            this.Controls.Add(this.Auth_Button);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button Registration_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;

        private System.Windows.Forms.Button Auth_Button;

        #endregion
    }
}