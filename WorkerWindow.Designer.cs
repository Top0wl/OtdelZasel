﻿namespace OtdelZasel
{
    partial class WorkerWindow
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
            this.tabControl_Petitions = new System.Windows.Forms.TabControl();
            this.tabPage_Petitions = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label_typeOfPetition = new System.Windows.Forms.Label();
            this.label_LeavingReason = new System.Windows.Forms.Label();
            this.label_Содержимое = new System.Windows.Forms.Label();
            this.label_answer = new System.Windows.Forms.Label();
            this.richTextBox_textOfSelectedPetition = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.button_Reject = new System.Windows.Forms.Button();
            this.button_Accept = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.dataGridView_Petitions = new System.Windows.Forms.DataGridView();
            this.tabPage_CheckIn = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView_FreePlaces = new System.Windows.Forms.DataGridView();
            this.button_CheckInCitizen = new System.Windows.Forms.Button();
            this.dataGridView_CitizensForCheckIn = new System.Windows.Forms.DataGridView();
            this.tabPage_ChechOut = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button_CheckOut = new System.Windows.Forms.Button();
            this.checkBox_CheckOutWithPetitions = new System.Windows.Forms.CheckBox();
            this.dataGridView_CitizensForCheckOut = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label_EmployeeName = new System.Windows.Forms.Label();
            this.tabControl_Petitions.SuspendLayout();
            this.tabPage_Petitions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Petitions)).BeginInit();
            this.tabPage_CheckIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FreePlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CitizensForCheckIn)).BeginInit();
            this.tabPage_ChechOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CitizensForCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Petitions
            // 
            this.tabControl_Petitions.Controls.Add(this.tabPage_Petitions);
            this.tabControl_Petitions.Controls.Add(this.tabPage_CheckIn);
            this.tabControl_Petitions.Controls.Add(this.tabPage_ChechOut);
            this.tabControl_Petitions.Location = new System.Drawing.Point(12, 37);
            this.tabControl_Petitions.Name = "tabControl_Petitions";
            this.tabControl_Petitions.SelectedIndex = 0;
            this.tabControl_Petitions.Size = new System.Drawing.Size(1162, 618);
            this.tabControl_Petitions.TabIndex = 0;
            this.tabControl_Petitions.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Petitions_Selecting);
            // 
            // tabPage_Petitions
            // 
            this.tabPage_Petitions.Controls.Add(this.label3);
            this.tabPage_Petitions.Controls.Add(this.label_typeOfPetition);
            this.tabPage_Petitions.Controls.Add(this.label_LeavingReason);
            this.tabPage_Petitions.Controls.Add(this.label_Содержимое);
            this.tabPage_Petitions.Controls.Add(this.label_answer);
            this.tabPage_Petitions.Controls.Add(this.richTextBox_textOfSelectedPetition);
            this.tabPage_Petitions.Controls.Add(this.label1);
            this.tabPage_Petitions.Controls.Add(this.richTextBox_Message);
            this.tabPage_Petitions.Controls.Add(this.button_Reject);
            this.tabPage_Petitions.Controls.Add(this.button_Accept);
            this.tabPage_Petitions.Controls.Add(this.title);
            this.tabPage_Petitions.Controls.Add(this.dataGridView_Petitions);
            this.tabPage_Petitions.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Petitions.Name = "tabPage_Petitions";
            this.tabPage_Petitions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Petitions.Size = new System.Drawing.Size(1154, 590);
            this.tabPage_Petitions.TabIndex = 0;
            this.tabPage_Petitions.Text = "Заявления";
            this.tabPage_Petitions.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Список поданных заявлений";
            // 
            // label_typeOfPetition
            // 
            this.label_typeOfPetition.AutoSize = true;
            this.label_typeOfPetition.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_typeOfPetition.Location = new System.Drawing.Point(674, 54);
            this.label_typeOfPetition.Name = "label_typeOfPetition";
            this.label_typeOfPetition.Size = new System.Drawing.Size(0, 20);
            this.label_typeOfPetition.TabIndex = 11;
            // 
            // label_LeavingReason
            // 
            this.label_LeavingReason.AutoSize = true;
            this.label_LeavingReason.Location = new System.Drawing.Point(674, 226);
            this.label_LeavingReason.Name = "label_LeavingReason";
            this.label_LeavingReason.Size = new System.Drawing.Size(0, 15);
            this.label_LeavingReason.TabIndex = 10;
            // 
            // label_Содержимое
            // 
            this.label_Содержимое.AutoSize = true;
            this.label_Содержимое.Location = new System.Drawing.Point(674, 196);
            this.label_Содержимое.Name = "label_Содержимое";
            this.label_Содержимое.Size = new System.Drawing.Size(79, 15);
            this.label_Содержимое.TabIndex = 9;
            this.label_Содержимое.Text = "Содержимое";
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Location = new System.Drawing.Point(674, 415);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(113, 15);
            this.label_answer.TabIndex = 8;
            this.label_answer.Text = "Ответ на заявление";
            // 
            // richTextBox_textOfSelectedPetition
            // 
            this.richTextBox_textOfSelectedPetition.Location = new System.Drawing.Point(674, 97);
            this.richTextBox_textOfSelectedPetition.Name = "richTextBox_textOfSelectedPetition";
            this.richTextBox_textOfSelectedPetition.ReadOnly = true;
            this.richTextBox_textOfSelectedPetition.Size = new System.Drawing.Size(451, 96);
            this.richTextBox_textOfSelectedPetition.TabIndex = 7;
            this.richTextBox_textOfSelectedPetition.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Текст заявления";
            // 
            // richTextBox_Message
            // 
            this.richTextBox_Message.Location = new System.Drawing.Point(674, 450);
            this.richTextBox_Message.Name = "richTextBox_Message";
            this.richTextBox_Message.Size = new System.Drawing.Size(425, 76);
            this.richTextBox_Message.TabIndex = 5;
            this.richTextBox_Message.Text = "";
            // 
            // button_Reject
            // 
            this.button_Reject.Location = new System.Drawing.Point(966, 532);
            this.button_Reject.Name = "button_Reject";
            this.button_Reject.Size = new System.Drawing.Size(133, 41);
            this.button_Reject.TabIndex = 3;
            this.button_Reject.Text = "Отклонить";
            this.button_Reject.UseVisualStyleBackColor = true;
            this.button_Reject.Click += new System.EventHandler(this.button_Reject_Click);
            // 
            // button_Accept
            // 
            this.button_Accept.Location = new System.Drawing.Point(674, 532);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(145, 41);
            this.button_Accept.TabIndex = 2;
            this.button_Accept.Text = "Принять";
            this.button_Accept.UseVisualStyleBackColor = true;
            this.button_Accept.Click += new System.EventHandler(this.button_Accept_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(674, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(272, 21);
            this.title.TabIndex = 1;
            this.title.Text = "Содержимое выбранного заявления";
            // 
            // dataGridView_Petitions
            // 
            this.dataGridView_Petitions.AllowUserToAddRows = false;
            this.dataGridView_Petitions.AllowUserToDeleteRows = false;
            this.dataGridView_Petitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Petitions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Petitions.Location = new System.Drawing.Point(3, 43);
            this.dataGridView_Petitions.MultiSelect = false;
            this.dataGridView_Petitions.Name = "dataGridView_Petitions";
            this.dataGridView_Petitions.ReadOnly = true;
            this.dataGridView_Petitions.RowTemplate.Height = 25;
            this.dataGridView_Petitions.Size = new System.Drawing.Size(628, 530);
            this.dataGridView_Petitions.TabIndex = 0;
            this.dataGridView_Petitions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Petitions_CellClick);
            // 
            // tabPage_CheckIn
            // 
            this.tabPage_CheckIn.Controls.Add(this.label6);
            this.tabPage_CheckIn.Controls.Add(this.label4);
            this.tabPage_CheckIn.Controls.Add(this.dataGridView_FreePlaces);
            this.tabPage_CheckIn.Controls.Add(this.button_CheckInCitizen);
            this.tabPage_CheckIn.Controls.Add(this.dataGridView_CitizensForCheckIn);
            this.tabPage_CheckIn.Location = new System.Drawing.Point(4, 24);
            this.tabPage_CheckIn.Name = "tabPage_CheckIn";
            this.tabPage_CheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CheckIn.Size = new System.Drawing.Size(1154, 590);
            this.tabPage_CheckIn.TabIndex = 1;
            this.tabPage_CheckIn.Text = "Заселение";
            this.tabPage_CheckIn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(643, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Свободные места в общежитиях";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Список граждан для заселения";
            // 
            // dataGridView_FreePlaces
            // 
            this.dataGridView_FreePlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FreePlaces.Location = new System.Drawing.Point(622, 38);
            this.dataGridView_FreePlaces.Name = "dataGridView_FreePlaces";
            this.dataGridView_FreePlaces.RowTemplate.Height = 25;
            this.dataGridView_FreePlaces.Size = new System.Drawing.Size(526, 406);
            this.dataGridView_FreePlaces.TabIndex = 2;
            // 
            // button_CheckInCitizen
            // 
            this.button_CheckInCitizen.Location = new System.Drawing.Point(941, 473);
            this.button_CheckInCitizen.Name = "button_CheckInCitizen";
            this.button_CheckInCitizen.Size = new System.Drawing.Size(161, 52);
            this.button_CheckInCitizen.TabIndex = 1;
            this.button_CheckInCitizen.Text = "Заселить";
            this.button_CheckInCitizen.UseVisualStyleBackColor = true;
            // 
            // dataGridView_CitizensForCheckIn
            // 
            this.dataGridView_CitizensForCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CitizensForCheckIn.Location = new System.Drawing.Point(3, 38);
            this.dataGridView_CitizensForCheckIn.Name = "dataGridView_CitizensForCheckIn";
            this.dataGridView_CitizensForCheckIn.RowTemplate.Height = 25;
            this.dataGridView_CitizensForCheckIn.Size = new System.Drawing.Size(573, 406);
            this.dataGridView_CitizensForCheckIn.TabIndex = 0;
            // 
            // tabPage_ChechOut
            // 
            this.tabPage_ChechOut.Controls.Add(this.label5);
            this.tabPage_ChechOut.Controls.Add(this.button_CheckOut);
            this.tabPage_ChechOut.Controls.Add(this.checkBox_CheckOutWithPetitions);
            this.tabPage_ChechOut.Controls.Add(this.dataGridView_CitizensForCheckOut);
            this.tabPage_ChechOut.Location = new System.Drawing.Point(4, 24);
            this.tabPage_ChechOut.Name = "tabPage_ChechOut";
            this.tabPage_ChechOut.Size = new System.Drawing.Size(1154, 590);
            this.tabPage_ChechOut.TabIndex = 2;
            this.tabPage_ChechOut.Text = "Выселение";
            this.tabPage_ChechOut.UseVisualStyleBackColor = true;
            this.tabPage_ChechOut.Enter += new System.EventHandler(this.tabPage_ChechOut_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Список для выселения";
            // 
            // button_CheckOut
            // 
            this.button_CheckOut.Location = new System.Drawing.Point(458, 466);
            this.button_CheckOut.Name = "button_CheckOut";
            this.button_CheckOut.Size = new System.Drawing.Size(241, 64);
            this.button_CheckOut.TabIndex = 2;
            this.button_CheckOut.Text = "Выселить";
            this.button_CheckOut.UseVisualStyleBackColor = true;
            this.button_CheckOut.Click += new System.EventHandler(this.button_CheckOut_Click);
            // 
            // checkBox_CheckOutWithPetitions
            // 
            this.checkBox_CheckOutWithPetitions.AutoSize = true;
            this.checkBox_CheckOutWithPetitions.Checked = true;
            this.checkBox_CheckOutWithPetitions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CheckOutWithPetitions.Location = new System.Drawing.Point(25, 466);
            this.checkBox_CheckOutWithPetitions.Name = "checkBox_CheckOutWithPetitions";
            this.checkBox_CheckOutWithPetitions.Size = new System.Drawing.Size(158, 19);
            this.checkBox_CheckOutWithPetitions.TabIndex = 1;
            this.checkBox_CheckOutWithPetitions.Text = "Выселять по заявлению";
            this.checkBox_CheckOutWithPetitions.UseVisualStyleBackColor = true;
            // 
            // dataGridView_CitizensForCheckOut
            // 
            this.dataGridView_CitizensForCheckOut.AllowUserToAddRows = false;
            this.dataGridView_CitizensForCheckOut.AllowUserToDeleteRows = false;
            this.dataGridView_CitizensForCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CitizensForCheckOut.Location = new System.Drawing.Point(3, 39);
            this.dataGridView_CitizensForCheckOut.Name = "dataGridView_CitizensForCheckOut";
            this.dataGridView_CitizensForCheckOut.ReadOnly = true;
            this.dataGridView_CitizensForCheckOut.RowTemplate.Height = 25;
            this.dataGridView_CitizensForCheckOut.Size = new System.Drawing.Size(696, 401);
            this.dataGridView_CitizensForCheckOut.TabIndex = 0;
            this.dataGridView_CitizensForCheckOut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CitizensForCheckOut_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(684, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Авторизированный работник";
            // 
            // label_EmployeeName
            // 
            this.label_EmployeeName.AutoSize = true;
            this.label_EmployeeName.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label_EmployeeName.Location = new System.Drawing.Point(909, 9);
            this.label_EmployeeName.Name = "label_EmployeeName";
            this.label_EmployeeName.Size = new System.Drawing.Size(0, 19);
            this.label_EmployeeName.TabIndex = 13;
            // 
            // WorkerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 667);
            this.Controls.Add(this.label_EmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl_Petitions);
            this.Name = "WorkerWindow";
            this.Text = "Режим работника";
            this.Load += new System.EventHandler(this.WorkerWindow_Load);
            this.tabControl_Petitions.ResumeLayout(false);
            this.tabPage_Petitions.ResumeLayout(false);
            this.tabPage_Petitions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Petitions)).EndInit();
            this.tabPage_CheckIn.ResumeLayout(false);
            this.tabPage_CheckIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FreePlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CitizensForCheckIn)).EndInit();
            this.tabPage_ChechOut.ResumeLayout(false);
            this.tabPage_ChechOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CitizensForCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Petitions;
        private System.Windows.Forms.TabPage tabPage_Petitions;
        private System.Windows.Forms.TabPage tabPage_CheckIn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataGridView_Petitions;
        private System.Windows.Forms.RichTextBox richTextBox_Message;
        private System.Windows.Forms.Button button_Reject;
        private System.Windows.Forms.Button button_Accept;
        private System.Windows.Forms.Button button_CheckInCitizen;
        private System.Windows.Forms.DataGridView dataGridView_CitizensForCheckIn;
        private System.Windows.Forms.DataGridView dataGridView_FreePlaces;
        private System.Windows.Forms.TabPage tabPage_ChechOut;
        private System.Windows.Forms.CheckBox checkBox_CheckOutWithPetitions;
        private System.Windows.Forms.DataGridView dataGridView_CitizensForCheckOut;
        private System.Windows.Forms.Button button_CheckOut;
        private System.Windows.Forms.RichTextBox richTextBox_textOfSelectedPetition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Label label_Содержимое;
        private System.Windows.Forms.Label label_LeavingReason;
        private System.Windows.Forms.Label label_typeOfPetition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_EmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}