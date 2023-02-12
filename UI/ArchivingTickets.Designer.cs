namespace UI
{
    partial class ArchivingTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivingTickets));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgBoxUserManagementLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datePickerArchiveTickets = new System.Windows.Forms.DateTimePicker();
            this.btnArchiveBefore = new System.Windows.Forms.Button();
            this.btnArchiveAll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxUserManagementLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(651, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "NoDesk";
            // 
            // imgBoxUserManagementLogo
            // 
            this.imgBoxUserManagementLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgBoxUserManagementLogo.Image")));
            this.imgBoxUserManagementLogo.Location = new System.Drawing.Point(11, 11);
            this.imgBoxUserManagementLogo.Margin = new System.Windows.Forms.Padding(2);
            this.imgBoxUserManagementLogo.Name = "imgBoxUserManagementLogo";
            this.imgBoxUserManagementLogo.Size = new System.Drawing.Size(283, 68);
            this.imgBoxUserManagementLogo.TabIndex = 17;
            this.imgBoxUserManagementLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "TICKET ARCHIVING OPTIONS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Or, select a date to archive all tickets created before:";
            // 
            // datePickerArchiveTickets
            // 
            this.datePickerArchiveTickets.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerArchiveTickets.CustomFormat = "dd-MM-yyyy";
            this.datePickerArchiveTickets.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerArchiveTickets.Location = new System.Drawing.Point(78, 332);
            this.datePickerArchiveTickets.Name = "datePickerArchiveTickets";
            this.datePickerArchiveTickets.Size = new System.Drawing.Size(119, 20);
            this.datePickerArchiveTickets.TabIndex = 19;
            // 
            // btnArchiveBefore
            // 
            this.btnArchiveBefore.BackColor = System.Drawing.Color.Thistle;
            this.btnArchiveBefore.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveBefore.Location = new System.Drawing.Point(77, 368);
            this.btnArchiveBefore.Name = "btnArchiveBefore";
            this.btnArchiveBefore.Size = new System.Drawing.Size(251, 51);
            this.btnArchiveBefore.TabIndex = 23;
            this.btnArchiveBefore.Text = "Archive Tickets Before That Date";
            this.btnArchiveBefore.UseVisualStyleBackColor = false;
            this.btnArchiveBefore.Click += new System.EventHandler(this.btnArchiveBefore_Click);
            // 
            // btnArchiveAll
            // 
            this.btnArchiveAll.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnArchiveAll.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveAll.Location = new System.Drawing.Point(78, 219);
            this.btnArchiveAll.Name = "btnArchiveAll";
            this.btnArchiveAll.Size = new System.Drawing.Size(251, 50);
            this.btnArchiveAll.TabIndex = 24;
            this.btnArchiveAll.Text = "Archive All Closed Tickets";
            this.btnArchiveAll.UseVisualStyleBackColor = false;
            this.btnArchiveAll.Click += new System.EventHandler(this.btnArchiveAll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Archive all closed tickets with only one click:";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGoBack.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(11, 94);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(185, 31);
            this.btnGoBack.TabIndex = 26;
            this.btnGoBack.Text = "< Go back to Ticket Overview";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // ArchivingTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnArchiveAll);
            this.Controls.Add(this.btnArchiveBefore);
            this.Controls.Add(this.datePickerArchiveTickets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgBoxUserManagementLogo);
            this.Name = "ArchivingTickets";
            this.Text = "ArchivingTickets";
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxUserManagementLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgBoxUserManagementLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePickerArchiveTickets;
        private System.Windows.Forms.Button btnArchiveBefore;
        private System.Windows.Forms.Button btnArchiveAll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGoBack;
    }
}