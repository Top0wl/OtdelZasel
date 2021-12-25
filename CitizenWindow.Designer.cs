
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
            this.comboBox_LeavingReason = new System.Windows.Forms.ComboBox();
            this.button_send_PetitonOut = new System.Windows.Forms.Button();
            this.label_PetOut = new System.Windows.Forms.Label();
            this.label_write_PetitionOut = new System.Windows.Forms.Label();
            this.richTextBox_PetitonOut = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_Balance2 = new System.Windows.Forms.Label();
            this.label_Balance = new System.Windows.Forms.Label();
            this.button_pay = new System.Windows.Forms.Button();
            this.numericUpDown_Sum = new System.Windows.Forms.NumericUpDown();
            this.label_Sum = new System.Windows.Forms.Label();
            this.textBox_CVV = new System.Windows.Forms.TextBox();
            this.textBox_BankCard = new System.Windows.Forms.TextBox();
            this.label_CVV = new System.Windows.Forms.Label();
            this.Label_BankCard = new System.Windows.Forms.Label();
            this.label_reason = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sum)).BeginInit();
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
            this.label_head_petition.Location = new System.Drawing.Point(524, 40);
            this.label_head_petition.Name = "label_head_petition";
            this.label_head_petition.Size = new System.Drawing.Size(140, 15);
            this.label_head_petition.TabIndex = 2;
            this.label_head_petition.Text = "Заявление на заселение";
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
            this.tabPage3.Controls.Add(this.label_reason);
            this.tabPage3.Controls.Add(this.comboBox_LeavingReason);
            this.tabPage3.Controls.Add(this.button_send_PetitonOut);
            this.tabPage3.Controls.Add(this.label_PetOut);
            this.tabPage3.Controls.Add(this.label_write_PetitionOut);
            this.tabPage3.Controls.Add(this.richTextBox_PetitonOut);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1197, 622);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заявление на выселение";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox_LeavingReason
            // 
            this.comboBox_LeavingReason.FormattingEnabled = true;
            this.comboBox_LeavingReason.Location = new System.Drawing.Point(820, 64);
            this.comboBox_LeavingReason.Name = "comboBox_LeavingReason";
            this.comboBox_LeavingReason.Size = new System.Drawing.Size(311, 23);
            this.comboBox_LeavingReason.TabIndex = 4;
            // 
            // button_send_PetitonOut
            // 
            this.button_send_PetitonOut.Location = new System.Drawing.Point(273, 517);
            this.button_send_PetitonOut.Name = "button_send_PetitonOut";
            this.button_send_PetitonOut.Size = new System.Drawing.Size(211, 46);
            this.button_send_PetitonOut.TabIndex = 3;
            this.button_send_PetitonOut.Text = "Подать заявление";
            this.button_send_PetitonOut.UseVisualStyleBackColor = true;
            this.button_send_PetitonOut.Click += new System.EventHandler(this.button_send_PetitonOut_Click);
            // 
            // label_PetOut
            // 
            this.label_PetOut.AutoSize = true;
            this.label_PetOut.Location = new System.Drawing.Point(320, 43);
            this.label_PetOut.Name = "label_PetOut";
            this.label_PetOut.Size = new System.Drawing.Size(144, 15);
            this.label_PetOut.TabIndex = 2;
            this.label_PetOut.Text = "Заявление на выселение";
            // 
            // label_write_PetitionOut
            // 
            this.label_write_PetitionOut.AutoSize = true;
            this.label_write_PetitionOut.Location = new System.Drawing.Point(16, 64);
            this.label_write_PetitionOut.Name = "label_write_PetitionOut";
            this.label_write_PetitionOut.Size = new System.Drawing.Size(140, 15);
            this.label_write_PetitionOut.TabIndex = 1;
            this.label_write_PetitionOut.Text = "Введите текст заявления";
            // 
            // richTextBox_PetitonOut
            // 
            this.richTextBox_PetitonOut.Location = new System.Drawing.Point(162, 61);
            this.richTextBox_PetitonOut.Name = "richTextBox_PetitonOut";
            this.richTextBox_PetitonOut.Size = new System.Drawing.Size(450, 450);
            this.richTextBox_PetitonOut.TabIndex = 0;
            this.richTextBox_PetitonOut.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label_Balance2);
            this.tabPage2.Controls.Add(this.label_Balance);
            this.tabPage2.Controls.Add(this.button_pay);
            this.tabPage2.Controls.Add(this.numericUpDown_Sum);
            this.tabPage2.Controls.Add(this.label_Sum);
            this.tabPage2.Controls.Add(this.textBox_CVV);
            this.tabPage2.Controls.Add(this.textBox_BankCard);
            this.tabPage2.Controls.Add(this.label_CVV);
            this.tabPage2.Controls.Add(this.Label_BankCard);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1197, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оплата";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // label_Balance2
            // 
            this.label_Balance2.AutoSize = true;
            this.label_Balance2.Location = new System.Drawing.Point(347, 72);
            this.label_Balance2.Name = "label_Balance2";
            this.label_Balance2.Size = new System.Drawing.Size(46, 15);
            this.label_Balance2.TabIndex = 10;
            this.label_Balance2.Text = "Баланс";
            // 
            // label_Balance
            // 
            this.label_Balance.AutoSize = true;
            this.label_Balance.Location = new System.Drawing.Point(265, 72);
            this.label_Balance.Name = "label_Balance";
            this.label_Balance.Size = new System.Drawing.Size(76, 15);
            this.label_Balance.TabIndex = 9;
            this.label_Balance.Text = "Ваш баланс:";
            // 
            // button_pay
            // 
            this.button_pay.Location = new System.Drawing.Point(347, 281);
            this.button_pay.Name = "button_pay";
            this.button_pay.Size = new System.Drawing.Size(229, 65);
            this.button_pay.TabIndex = 8;
            this.button_pay.Text = "Оплатить";
            this.button_pay.UseVisualStyleBackColor = true;
            this.button_pay.Click += new System.EventHandler(this.button_pay_Click);
            // 
            // numericUpDown_Sum
            // 
            this.numericUpDown_Sum.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_Sum.Location = new System.Drawing.Point(347, 224);
            this.numericUpDown_Sum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Sum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Sum.Name = "numericUpDown_Sum";
            this.numericUpDown_Sum.Size = new System.Drawing.Size(229, 23);
            this.numericUpDown_Sum.TabIndex = 7;
            this.numericUpDown_Sum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_Sum
            // 
            this.label_Sum.AutoSize = true;
            this.label_Sum.Location = new System.Drawing.Point(293, 224);
            this.label_Sum.Name = "label_Sum";
            this.label_Sum.Size = new System.Drawing.Size(48, 15);
            this.label_Sum.TabIndex = 5;
            this.label_Sum.Text = "Сумма:";
            // 
            // textBox_CVV
            // 
            this.textBox_CVV.Location = new System.Drawing.Point(347, 192);
            this.textBox_CVV.Name = "textBox_CVV";
            this.textBox_CVV.Size = new System.Drawing.Size(229, 23);
            this.textBox_CVV.TabIndex = 3;
            // 
            // textBox_BankCard
            // 
            this.textBox_BankCard.Location = new System.Drawing.Point(347, 163);
            this.textBox_BankCard.Name = "textBox_BankCard";
            this.textBox_BankCard.Size = new System.Drawing.Size(229, 23);
            this.textBox_BankCard.TabIndex = 2;
            // 
            // label_CVV
            // 
            this.label_CVV.AutoSize = true;
            this.label_CVV.Location = new System.Drawing.Point(278, 195);
            this.label_CVV.Name = "label_CVV";
            this.label_CVV.Size = new System.Drawing.Size(63, 15);
            this.label_CVV.TabIndex = 1;
            this.label_CVV.Text = "CVV/CVC :";
            // 
            // Label_BankCard
            // 
            this.Label_BankCard.AutoSize = true;
            this.Label_BankCard.Location = new System.Drawing.Point(189, 166);
            this.Label_BankCard.Name = "Label_BankCard";
            this.Label_BankCard.Size = new System.Drawing.Size(152, 15);
            this.Label_BankCard.TabIndex = 0;
            this.Label_BankCard.Text = "Номер банковской карты:";
            // 
            // label_reason
            // 
            this.label_reason.AutoSize = true;
            this.label_reason.Location = new System.Drawing.Point(639, 67);
            this.label_reason.Name = "label_reason";
            this.label_reason.Size = new System.Drawing.Size(175, 15);
            this.label_reason.TabIndex = 5;
            this.label_reason.Text = "Выберите причину выселения";
            // 
            // CitizenWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 674);
            this.Controls.Add(this.tabControl1);
            this.Name = "CitizenWindow";
            this.Text = "CitizenWindow";
            this.Load += new System.EventHandler(this.CitizenWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Sum)).EndInit();
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
        private System.Windows.Forms.Label Label_BankCard;
        private System.Windows.Forms.Label label_PetOut;
        private System.Windows.Forms.TextBox textBox_BankCard;
        private System.Windows.Forms.NumericUpDown numericUpDown_Sum;
        private System.Windows.Forms.Label label_Sum;
        private System.Windows.Forms.TextBox textBox_CVV;
        private System.Windows.Forms.Button button_pay;
        private System.Windows.Forms.Label label_Balance2;
        private System.Windows.Forms.Label label_Balance;
        private System.Windows.Forms.Button button_send_PetitonOut;
        private System.Windows.Forms.Label label_CVV;
        private System.Windows.Forms.Label label_write_PetitionOut;
        private System.Windows.Forms.RichTextBox richTextBox_PetitonOut;
        private System.Windows.Forms.ComboBox comboBox_LeavingReason;
        private System.Windows.Forms.Label label_write_reason;
        private System.Windows.Forms.Label label_reason;
    }
}