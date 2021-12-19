namespace OtdelZasel
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
            this.richTextBox_Message = new System.Windows.Forms.RichTextBox();
            this.button_Reject = new System.Windows.Forms.Button();
            this.button_Accept = new System.Windows.Forms.Button();
            this.qwertty = new System.Windows.Forms.Label();
            this.dataGridView_Petitions = new System.Windows.Forms.DataGridView();
            this.tabPage_CheckIn = new System.Windows.Forms.TabPage();
            this.dataGridView_FreePlaces = new System.Windows.Forms.DataGridView();
            this.button_CheckInCitizen = new System.Windows.Forms.Button();
            this.dataGridView_CitizensForCheckIn = new System.Windows.Forms.DataGridView();
            this.tabPage_ChechOut = new System.Windows.Forms.TabPage();
            this.button_CheckOut = new System.Windows.Forms.Button();
            this.checkBox_CheckOutWithPetitions = new System.Windows.Forms.CheckBox();
            this.dataGridView_CitizensForCheckOut = new System.Windows.Forms.DataGridView();
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
            this.tabControl_Petitions.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Petitions.Name = "tabControl_Petitions";
            this.tabControl_Petitions.SelectedIndex = 0;
            this.tabControl_Petitions.Size = new System.Drawing.Size(1162, 643);
            this.tabControl_Petitions.TabIndex = 0;
            // 
            // tabPage_Petitions
            // 
            this.tabPage_Petitions.Controls.Add(this.richTextBox_Message);
            this.tabPage_Petitions.Controls.Add(this.button_Reject);
            this.tabPage_Petitions.Controls.Add(this.button_Accept);
            this.tabPage_Petitions.Controls.Add(this.qwertty);
            this.tabPage_Petitions.Controls.Add(this.dataGridView_Petitions);
            this.tabPage_Petitions.Location = new System.Drawing.Point(4, 24);
            this.tabPage_Petitions.Name = "tabPage_Petitions";
            this.tabPage_Petitions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Petitions.Size = new System.Drawing.Size(1154, 615);
            this.tabPage_Petitions.TabIndex = 0;
            this.tabPage_Petitions.Text = "Заявления";
            this.tabPage_Petitions.UseVisualStyleBackColor = true;
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
            // 
            // button_Accept
            // 
            this.button_Accept.Location = new System.Drawing.Point(674, 532);
            this.button_Accept.Name = "button_Accept";
            this.button_Accept.Size = new System.Drawing.Size(145, 41);
            this.button_Accept.TabIndex = 2;
            this.button_Accept.Text = "Принять";
            this.button_Accept.UseVisualStyleBackColor = true;
            // 
            // qwertty
            // 
            this.qwertty.AutoSize = true;
            this.qwertty.Location = new System.Drawing.Point(674, 19);
            this.qwertty.Name = "qwertty";
            this.qwertty.Size = new System.Drawing.Size(36, 15);
            this.qwertty.TabIndex = 1;
            this.qwertty.Text = "Поля";
            // 
            // dataGridView_Petitions
            // 
            this.dataGridView_Petitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Petitions.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_Petitions.Name = "dataGridView_Petitions";
            this.dataGridView_Petitions.RowTemplate.Height = 25;
            this.dataGridView_Petitions.Size = new System.Drawing.Size(628, 570);
            this.dataGridView_Petitions.TabIndex = 0;
            // 
            // tabPage_CheckIn
            // 
            this.tabPage_CheckIn.Controls.Add(this.dataGridView_FreePlaces);
            this.tabPage_CheckIn.Controls.Add(this.button_CheckInCitizen);
            this.tabPage_CheckIn.Controls.Add(this.dataGridView_CitizensForCheckIn);
            this.tabPage_CheckIn.Location = new System.Drawing.Point(4, 24);
            this.tabPage_CheckIn.Name = "tabPage_CheckIn";
            this.tabPage_CheckIn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_CheckIn.Size = new System.Drawing.Size(1154, 615);
            this.tabPage_CheckIn.TabIndex = 1;
            this.tabPage_CheckIn.Text = "Заселение";
            this.tabPage_CheckIn.UseVisualStyleBackColor = true;
            // 
            // dataGridView_FreePlaces
            // 
            this.dataGridView_FreePlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FreePlaces.Location = new System.Drawing.Point(625, 3);
            this.dataGridView_FreePlaces.Name = "dataGridView_FreePlaces";
            this.dataGridView_FreePlaces.RowTemplate.Height = 25;
            this.dataGridView_FreePlaces.Size = new System.Drawing.Size(526, 406);
            this.dataGridView_FreePlaces.TabIndex = 2;
            // 
            // button_CheckInCitizen
            // 
            this.button_CheckInCitizen.Location = new System.Drawing.Point(14, 551);
            this.button_CheckInCitizen.Name = "button_CheckInCitizen";
            this.button_CheckInCitizen.Size = new System.Drawing.Size(161, 52);
            this.button_CheckInCitizen.TabIndex = 1;
            this.button_CheckInCitizen.Text = "Заселить";
            this.button_CheckInCitizen.UseVisualStyleBackColor = true;
            // 
            // dataGridView_CitizensForCheckIn
            // 
            this.dataGridView_CitizensForCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CitizensForCheckIn.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_CitizensForCheckIn.Name = "dataGridView_CitizensForCheckIn";
            this.dataGridView_CitizensForCheckIn.RowTemplate.Height = 25;
            this.dataGridView_CitizensForCheckIn.Size = new System.Drawing.Size(573, 406);
            this.dataGridView_CitizensForCheckIn.TabIndex = 0;
            // 
            // tabPage_ChechOut
            // 
            this.tabPage_ChechOut.Controls.Add(this.button_CheckOut);
            this.tabPage_ChechOut.Controls.Add(this.checkBox_CheckOutWithPetitions);
            this.tabPage_ChechOut.Controls.Add(this.dataGridView_CitizensForCheckOut);
            this.tabPage_ChechOut.Location = new System.Drawing.Point(4, 24);
            this.tabPage_ChechOut.Name = "tabPage_ChechOut";
            this.tabPage_ChechOut.Size = new System.Drawing.Size(1154, 615);
            this.tabPage_ChechOut.TabIndex = 2;
            this.tabPage_ChechOut.Text = "Выселение";
            this.tabPage_ChechOut.UseVisualStyleBackColor = true;
            // 
            // button_CheckOut
            // 
            this.button_CheckOut.Location = new System.Drawing.Point(84, 486);
            this.button_CheckOut.Name = "button_CheckOut";
            this.button_CheckOut.Size = new System.Drawing.Size(241, 64);
            this.button_CheckOut.TabIndex = 2;
            this.button_CheckOut.Text = "Выселить";
            this.button_CheckOut.UseVisualStyleBackColor = true;
            // 
            // checkBox_CheckOutWithPetitions
            // 
            this.checkBox_CheckOutWithPetitions.AutoSize = true;
            this.checkBox_CheckOutWithPetitions.Checked = true;
            this.checkBox_CheckOutWithPetitions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CheckOutWithPetitions.Location = new System.Drawing.Point(3, 424);
            this.checkBox_CheckOutWithPetitions.Name = "checkBox_CheckOutWithPetitions";
            this.checkBox_CheckOutWithPetitions.Size = new System.Drawing.Size(158, 19);
            this.checkBox_CheckOutWithPetitions.TabIndex = 1;
            this.checkBox_CheckOutWithPetitions.Text = "Выселять по заявлению";
            this.checkBox_CheckOutWithPetitions.UseVisualStyleBackColor = true;
            // 
            // dataGridView_CitizensForCheckOut
            // 
            this.dataGridView_CitizensForCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CitizensForCheckOut.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_CitizensForCheckOut.Name = "dataGridView_CitizensForCheckOut";
            this.dataGridView_CitizensForCheckOut.RowTemplate.Height = 25;
            this.dataGridView_CitizensForCheckOut.Size = new System.Drawing.Size(531, 415);
            this.dataGridView_CitizensForCheckOut.TabIndex = 0;
            // 
            // WorkerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 667);
            this.Controls.Add(this.tabControl_Petitions);
            this.Name = "WorkerWindow";
            this.Text = "Режим работника";
            this.Load += new System.EventHandler(this.WorkerWindow_Load);
            this.tabControl_Petitions.ResumeLayout(false);
            this.tabPage_Petitions.ResumeLayout(false);
            this.tabPage_Petitions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Petitions)).EndInit();
            this.tabPage_CheckIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FreePlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CitizensForCheckIn)).EndInit();
            this.tabPage_ChechOut.ResumeLayout(false);
            this.tabPage_ChechOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CitizensForCheckOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Petitions;
        private System.Windows.Forms.TabPage tabPage_Petitions;
        private System.Windows.Forms.TabPage tabPage_CheckIn;
        private System.Windows.Forms.Label qwertty;
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
    }
}