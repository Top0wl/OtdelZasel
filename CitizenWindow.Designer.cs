
namespace OtdelZasel
{
    partial class CitizenWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label_write_petition = new System.Windows.Forms.Label();
            this.label_head_petition = new System.Windows.Forms.Label();
            this.richTextBox_Petition = new System.Windows.Forms.RichTextBox();
            this.button_send_petiton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1205, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label_write_petition);
            this.tabPage1.Controls.Add(this.label_head_petition);
            this.tabPage1.Controls.Add(this.richTextBox_Petition);
            this.tabPage1.Controls.Add(this.button_send_petiton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1197, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Заявление на заселение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label_write_petition
            // 
            this.label_write_petition.AutoSize = true;
            this.label_write_petition.Location = new System.Drawing.Point(220, 61);
            this.label_write_petition.Name = "label_write_petition";
            this.label_write_petition.Size = new System.Drawing.Size(140, 15);
            this.label_write_petition.TabIndex = 3;
            this.label_write_petition.Text = "Введите текст заявления";
            // 
            // label_head_petition
            // 
            this.label_head_petition.AutoSize = true;
            this.label_head_petition.Location = new System.Drawing.Point(555, 40);
            this.label_head_petition.Name = "label_head_petition";
            this.label_head_petition.Size = new System.Drawing.Size(65, 15);
            this.label_head_petition.TabIndex = 2;
            this.label_head_petition.Text = "Заявление";
            // 
            // richTextBox_Petition
            // 
            this.richTextBox_Petition.Location = new System.Drawing.Point(366, 58);
            this.richTextBox_Petition.Name = "richTextBox_Petition";
            this.richTextBox_Petition.Size = new System.Drawing.Size(450, 450);
            this.richTextBox_Petition.TabIndex = 1;
            this.richTextBox_Petition.Text = "";
            // 
            // button_send_petiton
            // 
            this.button_send_petiton.Location = new System.Drawing.Point(477, 514);
            this.button_send_petiton.Name = "button_send_petiton";
            this.button_send_petiton.Size = new System.Drawing.Size(211, 46);
            this.button_send_petiton.TabIndex = 0;
            this.button_send_petiton.Text = "Подать заявление";
            this.button_send_petiton.UseVisualStyleBackColor = true;
            this.button_send_petiton.Click += new System.EventHandler(this.button_send_petiton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1197, 622);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заявление на выселение";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1197, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оплата";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CitizenWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 674);
            this.Controls.Add(this.tabControl1);
            this.Name = "CitizenWindow";
            this.Text = "CitizenWindow";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button_send_petiton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label_write_petition;
        private System.Windows.Forms.Label label_head_petition;
        private System.Windows.Forms.RichTextBox richTextBox_Petition;
    }
}