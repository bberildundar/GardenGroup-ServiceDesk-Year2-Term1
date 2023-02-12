namespace UI
{
    partial class AddTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTicket));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblIncidentDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmTicket = new System.Windows.Forms.Button();
            this.lblIncidentSubject = new System.Windows.Forms.Label();
            this.txtIncidentSubject = new System.Windows.Forms.TextBox();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.lblResolvedBy = new System.Windows.Forms.Label();
            this.cbResolvedBy = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(703, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(924, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "NoDesk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 76);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblIncidentDescription
            // 
            this.lblIncidentDescription.AutoSize = true;
            this.lblIncidentDescription.Location = new System.Drawing.Point(584, 210);
            this.lblIncidentDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncidentDescription.Name = "lblIncidentDescription";
            this.lblIncidentDescription.Size = new System.Drawing.Size(127, 16);
            this.lblIncidentDescription.TabIndex = 19;
            this.lblIncidentDescription.Text = "Incident Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(588, 229);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(455, 276);
            this.txtDescription.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 172);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 29;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 153);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(133, 16);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "E-mail of the reporter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Deadline:";
            // 
            // btnConfirmTicket
            // 
            this.btnConfirmTicket.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmTicket.Location = new System.Drawing.Point(155, 455);
            this.btnConfirmTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmTicket.Name = "btnConfirmTicket";
            this.btnConfirmTicket.Size = new System.Drawing.Size(237, 63);
            this.btnConfirmTicket.TabIndex = 34;
            this.btnConfirmTicket.Text = "OPEN TICKET";
            this.btnConfirmTicket.UseVisualStyleBackColor = false;
            this.btnConfirmTicket.Click += new System.EventHandler(this.btnConfirmTicket_Click);
            // 
            // lblIncidentSubject
            // 
            this.lblIncidentSubject.AutoSize = true;
            this.lblIncidentSubject.Location = new System.Drawing.Point(584, 153);
            this.lblIncidentSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncidentSubject.Name = "lblIncidentSubject";
            this.lblIncidentSubject.Size = new System.Drawing.Size(104, 16);
            this.lblIncidentSubject.TabIndex = 35;
            this.lblIncidentSubject.Text = "Incident Subject:";
            // 
            // txtIncidentSubject
            // 
            this.txtIncidentSubject.Location = new System.Drawing.Point(587, 174);
            this.txtIncidentSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIncidentSubject.Name = "txtIncidentSubject";
            this.txtIncidentSubject.Size = new System.Drawing.Size(455, 22);
            this.txtIncidentSubject.TabIndex = 36;
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(15, 222);
            this.dateTimePickerDeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(232, 22);
            this.dateTimePickerDeadline.TabIndex = 37;
            this.dateTimePickerDeadline.Value = new System.DateTime(2022, 10, 24, 0, 0, 0, 0);
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(11, 246);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(51, 16);
            this.lblPriority.TabIndex = 38;
            this.lblPriority.Text = "Priority:";
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(13, 266);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(121, 24);
            this.cbPriority.TabIndex = 39;
            // 
            // lblResolvedBy
            // 
            this.lblResolvedBy.AutoSize = true;
            this.lblResolvedBy.Location = new System.Drawing.Point(11, 299);
            this.lblResolvedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResolvedBy.Name = "lblResolvedBy";
            this.lblResolvedBy.Size = new System.Drawing.Size(88, 16);
            this.lblResolvedBy.TabIndex = 40;
            this.lblResolvedBy.Text = "Resolved By:";
            // 
            // cbResolvedBy
            // 
            this.cbResolvedBy.FormattingEnabled = true;
            this.cbResolvedBy.Location = new System.Drawing.Point(15, 319);
            this.cbResolvedBy.Name = "cbResolvedBy";
            this.cbResolvedBy.Size = new System.Drawing.Size(121, 24);
            this.cbResolvedBy.TabIndex = 41;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(15, 374);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Status:";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(930, 72);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 28);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 532);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbResolvedBy);
            this.Controls.Add(this.lblResolvedBy);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.dateTimePickerDeadline);
            this.Controls.Add(this.txtIncidentSubject);
            this.Controls.Add(this.lblIncidentSubject);
            this.Controls.Add(this.btnConfirmTicket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblIncidentDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddTicket";
            this.Text = "AddTicket";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblIncidentDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmTicket;
        private System.Windows.Forms.Label lblIncidentSubject;
        private System.Windows.Forms.TextBox txtIncidentSubject;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label lblResolvedBy;
        private System.Windows.Forms.ComboBox cbResolvedBy;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}