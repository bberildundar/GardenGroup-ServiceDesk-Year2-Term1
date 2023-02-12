namespace UI
{
    partial class Ticket_Overview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket_Overview));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashboardInTicketOverviewForm = new System.Windows.Forms.Button();
            this.btnIncidentManagementInTicketOverviewForm = new System.Windows.Forms.Button();
            this.btnUserManagementInTicketOverviewForm = new System.Windows.Forms.Button();
            this.lblTicketOverview = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailToFilter = new System.Windows.Forms.TextBox();
            this.btnManageTicketInTicketOverview = new System.Windows.Forms.Button();
            this.listviewIncidentsOverview = new System.Windows.Forms.ListView();
            this.IncidentSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IncidentUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IncidentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IncidentStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateTicketInTicketOverview = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listviewTicketOverview = new System.Windows.Forms.ListView();
            this.TicketSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnArchivingInTicketOverviewForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDashboardInTicketOverviewForm
            // 
            this.btnDashboardInTicketOverviewForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardInTicketOverviewForm.Location = new System.Drawing.Point(8, 72);
            this.btnDashboardInTicketOverviewForm.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDashboardInTicketOverviewForm.Name = "btnDashboardInTicketOverviewForm";
            this.btnDashboardInTicketOverviewForm.Size = new System.Drawing.Size(243, 36);
            this.btnDashboardInTicketOverviewForm.TabIndex = 1;
            this.btnDashboardInTicketOverviewForm.Text = "Dashboard";
            this.btnDashboardInTicketOverviewForm.UseVisualStyleBackColor = true;
            this.btnDashboardInTicketOverviewForm.Click += new System.EventHandler(this.btnDashboardInTicketOverviewForm_Click);
            // 
            // btnIncidentManagementInTicketOverviewForm
            // 
            this.btnIncidentManagementInTicketOverviewForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidentManagementInTicketOverviewForm.Location = new System.Drawing.Point(305, 72);
            this.btnIncidentManagementInTicketOverviewForm.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnIncidentManagementInTicketOverviewForm.Name = "btnIncidentManagementInTicketOverviewForm";
            this.btnIncidentManagementInTicketOverviewForm.Size = new System.Drawing.Size(243, 36);
            this.btnIncidentManagementInTicketOverviewForm.TabIndex = 2;
            this.btnIncidentManagementInTicketOverviewForm.Text = "Incident Management";
            this.btnIncidentManagementInTicketOverviewForm.UseVisualStyleBackColor = true;
            // 
            // btnUserManagementInTicketOverviewForm
            // 
            this.btnUserManagementInTicketOverviewForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagementInTicketOverviewForm.Location = new System.Drawing.Point(586, 72);
            this.btnUserManagementInTicketOverviewForm.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUserManagementInTicketOverviewForm.Name = "btnUserManagementInTicketOverviewForm";
            this.btnUserManagementInTicketOverviewForm.Size = new System.Drawing.Size(243, 36);
            this.btnUserManagementInTicketOverviewForm.TabIndex = 3;
            this.btnUserManagementInTicketOverviewForm.Text = "UserManagement";
            this.btnUserManagementInTicketOverviewForm.UseVisualStyleBackColor = true;
            this.btnUserManagementInTicketOverviewForm.Click += new System.EventHandler(this.btnUserManagementInTicketOverviewForm_Click);
            // 
            // lblTicketOverview
            // 
            this.lblTicketOverview.AutoSize = true;
            this.lblTicketOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketOverview.Location = new System.Drawing.Point(8, 122);
            this.lblTicketOverview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketOverview.Name = "lblTicketOverview";
            this.lblTicketOverview.Size = new System.Drawing.Size(177, 26);
            this.lblTicketOverview.TabIndex = 4;
            this.lblTicketOverview.Text = "Overview Tickets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(734, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "NoDesk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(592, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // txtEmailToFilter
            // 
            this.txtEmailToFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailToFilter.Location = new System.Drawing.Point(586, 121);
            this.txtEmailToFilter.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtEmailToFilter.Name = "txtEmailToFilter";
            this.txtEmailToFilter.Size = new System.Drawing.Size(243, 29);
            this.txtEmailToFilter.TabIndex = 7;
            this.txtEmailToFilter.Text = "Filter by email";
            this.txtEmailToFilter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmailToFilter.Click += new System.EventHandler(this.txtEmailToFilter_OnClick);
            this.txtEmailToFilter.TextChanged += new System.EventHandler(this.txtEmailToFilter_TextChanged);
            // 
            // btnManageTicketInTicketOverview
            // 
            this.btnManageTicketInTicketOverview.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnManageTicketInTicketOverview.FlatAppearance.BorderSize = 2;
            this.btnManageTicketInTicketOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTicketInTicketOverview.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnManageTicketInTicketOverview.Location = new System.Drawing.Point(676, 176);
            this.btnManageTicketInTicketOverview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnManageTicketInTicketOverview.Name = "btnManageTicketInTicketOverview";
            this.btnManageTicketInTicketOverview.Size = new System.Drawing.Size(153, 36);
            this.btnManageTicketInTicketOverview.TabIndex = 8;
            this.btnManageTicketInTicketOverview.Text = "MANAGE TICKET";
            this.btnManageTicketInTicketOverview.UseVisualStyleBackColor = false;
            this.btnManageTicketInTicketOverview.Click += new System.EventHandler(this.btnManageTicketInTicketOverview_Click);
            // 
            // listviewIncidentsOverview
            // 
            this.listviewIncidentsOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IncidentSubject,
            this.IncidentUser,
            this.IncidentDate,
            this.IncidentStatus});
            this.listviewIncidentsOverview.FullRowSelect = true;
            this.listviewIncidentsOverview.HideSelection = false;
            this.listviewIncidentsOverview.Location = new System.Drawing.Point(8, 243);
            this.listviewIncidentsOverview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listviewIncidentsOverview.MultiSelect = false;
            this.listviewIncidentsOverview.Name = "listviewIncidentsOverview";
            this.listviewIncidentsOverview.Size = new System.Drawing.Size(380, 245);
            this.listviewIncidentsOverview.TabIndex = 9;
            this.listviewIncidentsOverview.UseCompatibleStateImageBehavior = false;
            // 
            // IncidentSubject
            // 
            this.IncidentSubject.Text = "Subject";
            this.IncidentSubject.Width = 80;
            // 
            // IncidentUser
            // 
            this.IncidentUser.Text = "User";
            this.IncidentUser.Width = 100;
            // 
            // IncidentDate
            // 
            this.IncidentDate.Text = "Requested On";
            this.IncidentDate.Width = 100;
            // 
            // IncidentStatus
            // 
            this.IncidentStatus.Text = "Status";
            this.IncidentStatus.Width = 100;
            // 
            // btnCreateTicketInTicketOverview
            // 
            this.btnCreateTicketInTicketOverview.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCreateTicketInTicketOverview.FlatAppearance.BorderSize = 2;
            this.btnCreateTicketInTicketOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTicketInTicketOverview.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCreateTicketInTicketOverview.Location = new System.Drawing.Point(234, 176);
            this.btnCreateTicketInTicketOverview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnCreateTicketInTicketOverview.Name = "btnCreateTicketInTicketOverview";
            this.btnCreateTicketInTicketOverview.Size = new System.Drawing.Size(153, 36);
            this.btnCreateTicketInTicketOverview.TabIndex = 11;
            this.btnCreateTicketInTicketOverview.Text = "CREATE TICKET";
            this.btnCreateTicketInTicketOverview.UseVisualStyleBackColor = false;
            this.btnCreateTicketInTicketOverview.Click += new System.EventHandler(this.btnCreateTicketInTicketOverview_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Open incidents";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Open tickets";
            // 
            // listviewTicketOverview
            // 
            this.listviewTicketOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TicketSubject,
            this.TicketUser,
            this.TicketDate,
            this.TicketStatus,
            this.TicketPriority});
            this.listviewTicketOverview.FullRowSelect = true;
            this.listviewTicketOverview.HideSelection = false;
            this.listviewTicketOverview.Location = new System.Drawing.Point(415, 243);
            this.listviewTicketOverview.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listviewTicketOverview.Name = "listviewTicketOverview";
            this.listviewTicketOverview.Size = new System.Drawing.Size(416, 245);
            this.listviewTicketOverview.TabIndex = 14;
            this.listviewTicketOverview.UseCompatibleStateImageBehavior = false;
            this.listviewTicketOverview.SelectedIndexChanged += new System.EventHandler(this.listviewTicketOverview_SelectedIndexChanged);
            // 
            // TicketSubject
            // 
            this.TicketSubject.Tag = "";
            this.TicketSubject.Text = "Subject";
            this.TicketSubject.Width = 80;
            // 
            // TicketUser
            // 
            this.TicketUser.Text = "User";
            this.TicketUser.Width = 100;
            // 
            // TicketDate
            // 
            this.TicketDate.Text = "Deadline";
            this.TicketDate.Width = 80;
            // 
            // TicketStatus
            // 
            this.TicketStatus.Text = "Status";
            // 
            // TicketPriority
            // 
            this.TicketPriority.Text = "Priority";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Select an incident to convert it to ticket";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Select ticket to manage it";
            // 
            // btnArchivingInTicketOverviewForm
            // 
            this.btnArchivingInTicketOverviewForm.BackColor = System.Drawing.Color.BurlyWood;
            this.btnArchivingInTicketOverviewForm.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivingInTicketOverviewForm.ForeColor = System.Drawing.Color.Black;
            this.btnArchivingInTicketOverviewForm.Location = new System.Drawing.Point(8, 506);
            this.btnArchivingInTicketOverviewForm.Name = "btnArchivingInTicketOverviewForm";
            this.btnArchivingInTicketOverviewForm.Size = new System.Drawing.Size(155, 34);
            this.btnArchivingInTicketOverviewForm.TabIndex = 18;
            this.btnArchivingInTicketOverviewForm.Text = "Archiving Options";
            this.btnArchivingInTicketOverviewForm.UseVisualStyleBackColor = false;
            this.btnArchivingInTicketOverviewForm.Click += new System.EventHandler(this.btnArchivingInTicketOverviewForm_Click);
            // 
            // Ticket_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 548);
            this.Controls.Add(this.btnArchivingInTicketOverviewForm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listviewTicketOverview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreateTicketInTicketOverview);
            this.Controls.Add(this.listviewIncidentsOverview);
            this.Controls.Add(this.btnManageTicketInTicketOverview);
            this.Controls.Add(this.txtEmailToFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTicketOverview);
            this.Controls.Add(this.btnUserManagementInTicketOverviewForm);
            this.Controls.Add(this.btnIncidentManagementInTicketOverviewForm);
            this.Controls.Add(this.btnDashboardInTicketOverviewForm);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Ticket_Overview";
            this.Text = "Ticket_Overview";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboardInTicketOverviewForm;
        private System.Windows.Forms.Button btnIncidentManagementInTicketOverviewForm;
        private System.Windows.Forms.Button btnUserManagementInTicketOverviewForm;
        private System.Windows.Forms.Label lblTicketOverview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailToFilter;
        private System.Windows.Forms.Button btnManageTicketInTicketOverview;
        private System.Windows.Forms.ListView listviewIncidentsOverview;
        private System.Windows.Forms.ColumnHeader IncidentSubject;
        private System.Windows.Forms.ColumnHeader IncidentUser;
        private System.Windows.Forms.ColumnHeader IncidentDate;
        private System.Windows.Forms.ColumnHeader IncidentStatus;
        private System.Windows.Forms.Button btnCreateTicketInTicketOverview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listviewTicketOverview;
        private System.Windows.Forms.ColumnHeader TicketSubject;
        private System.Windows.Forms.ColumnHeader TicketUser;
        private System.Windows.Forms.ColumnHeader TicketDate;
        private System.Windows.Forms.ColumnHeader TicketStatus;
        private System.Windows.Forms.ColumnHeader TicketPriority;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnArchivingInTicketOverviewForm;
    }
}