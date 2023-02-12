namespace UI
{
    partial class UserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            this.listViewUserManagement = new System.Windows.Forms.ListView();
            this.columnIDInUserList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmailInUserList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFirstNameInUserList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastNameInUserList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTicketsInUserList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddNewUserInUserManagementForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTicketOverviewInUserManagementForm = new System.Windows.Forms.Label();
            this.btnUserManagementInUserManagementForm = new System.Windows.Forms.Button();
            this.btnIncidentManagementInUserManagementForm = new System.Windows.Forms.Button();
            this.btnDashboardInUserManagementForm = new System.Windows.Forms.Button();
            this.imgBoxUserManagementLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxUserManagementLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewUserManagement
            // 
            this.listViewUserManagement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnIDInUserList,
            this.columnEmailInUserList,
            this.columnFirstNameInUserList,
            this.columnLastNameInUserList,
            this.columnTicketsInUserList});
            this.listViewUserManagement.HideSelection = false;
            this.listViewUserManagement.Location = new System.Drawing.Point(17, 174);
            this.listViewUserManagement.Margin = new System.Windows.Forms.Padding(2);
            this.listViewUserManagement.Name = "listViewUserManagement";
            this.listViewUserManagement.Size = new System.Drawing.Size(732, 265);
            this.listViewUserManagement.TabIndex = 19;
            this.listViewUserManagement.UseCompatibleStateImageBehavior = false;
            this.listViewUserManagement.View = System.Windows.Forms.View.Details;
            // 
            // columnIDInUserList
            // 
            this.columnIDInUserList.Text = "ID";
            this.columnIDInUserList.Width = 200;
            // 
            // columnEmailInUserList
            // 
            this.columnEmailInUserList.Text = "Email";
            this.columnEmailInUserList.Width = 150;
            // 
            // columnFirstNameInUserList
            // 
            this.columnFirstNameInUserList.Text = "First Name";
            this.columnFirstNameInUserList.Width = 85;
            // 
            // columnLastNameInUserList
            // 
            this.columnLastNameInUserList.Text = "LastName";
            this.columnLastNameInUserList.Width = 100;
            // 
            // columnTicketsInUserList
            // 
            this.columnTicketsInUserList.Text = "# tickets";
            this.columnTicketsInUserList.Width = 70;
            // 
            // btnAddNewUserInUserManagementForm
            // 
            this.btnAddNewUserInUserManagementForm.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddNewUserInUserManagementForm.FlatAppearance.BorderSize = 2;
            this.btnAddNewUserInUserManagementForm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNewUserInUserManagementForm.Location = new System.Drawing.Point(596, 134);
            this.btnAddNewUserInUserManagementForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewUserInUserManagementForm.Name = "btnAddNewUserInUserManagementForm";
            this.btnAddNewUserInUserManagementForm.Size = new System.Drawing.Size(153, 36);
            this.btnAddNewUserInUserManagementForm.TabIndex = 18;
            this.btnAddNewUserInUserManagementForm.Text = "+ ADD NEW USER";
            this.btnAddNewUserInUserManagementForm.UseVisualStyleBackColor = false;
            this.btnAddNewUserInUserManagementForm.Click += new System.EventHandler(this.btnAddNewUserInUserManagementForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Licensed to: The Garden Group";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "NoDesk";
            // 
            // lblTicketOverviewInUserManagementForm
            // 
            this.lblTicketOverviewInUserManagementForm.AutoSize = true;
            this.lblTicketOverviewInUserManagementForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketOverviewInUserManagementForm.Location = new System.Drawing.Point(11, 137);
            this.lblTicketOverviewInUserManagementForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTicketOverviewInUserManagementForm.Name = "lblTicketOverviewInUserManagementForm";
            this.lblTicketOverviewInUserManagementForm.Size = new System.Drawing.Size(206, 26);
            this.lblTicketOverviewInUserManagementForm.TabIndex = 14;
            this.lblTicketOverviewInUserManagementForm.Text = "User Management";
            // 
            // btnUserManagementInUserManagementForm
            // 
            this.btnUserManagementInUserManagementForm.Location = new System.Drawing.Point(505, 86);
            this.btnUserManagementInUserManagementForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnUserManagementInUserManagementForm.Name = "btnUserManagementInUserManagementForm";
            this.btnUserManagementInUserManagementForm.Size = new System.Drawing.Size(243, 36);
            this.btnUserManagementInUserManagementForm.TabIndex = 13;
            this.btnUserManagementInUserManagementForm.Text = "User Management";
            this.btnUserManagementInUserManagementForm.UseVisualStyleBackColor = true;
            // 
            // btnIncidentManagementInUserManagementForm
            // 
            this.btnIncidentManagementInUserManagementForm.Location = new System.Drawing.Point(258, 86);
            this.btnIncidentManagementInUserManagementForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnIncidentManagementInUserManagementForm.Name = "btnIncidentManagementInUserManagementForm";
            this.btnIncidentManagementInUserManagementForm.Size = new System.Drawing.Size(243, 36);
            this.btnIncidentManagementInUserManagementForm.TabIndex = 12;
            this.btnIncidentManagementInUserManagementForm.Text = "Incident Management";
            this.btnIncidentManagementInUserManagementForm.UseVisualStyleBackColor = true;
            this.btnIncidentManagementInUserManagementForm.Click += new System.EventHandler(this.btnIncidentManagementInUserManagementForm_Click);
            // 
            // btnDashboardInUserManagementForm
            // 
            this.btnDashboardInUserManagementForm.Location = new System.Drawing.Point(11, 86);
            this.btnDashboardInUserManagementForm.Margin = new System.Windows.Forms.Padding(2);
            this.btnDashboardInUserManagementForm.Name = "btnDashboardInUserManagementForm";
            this.btnDashboardInUserManagementForm.Size = new System.Drawing.Size(243, 36);
            this.btnDashboardInUserManagementForm.TabIndex = 11;
            this.btnDashboardInUserManagementForm.Text = "Dashboard";
            this.btnDashboardInUserManagementForm.UseVisualStyleBackColor = true;
            this.btnDashboardInUserManagementForm.Click += new System.EventHandler(this.btnDashboardInUserManagementForm_Click);
            // 
            // imgBoxUserManagementLogo
            // 
            this.imgBoxUserManagementLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgBoxUserManagementLogo.Image")));
            this.imgBoxUserManagementLogo.Location = new System.Drawing.Point(11, 14);
            this.imgBoxUserManagementLogo.Margin = new System.Windows.Forms.Padding(2);
            this.imgBoxUserManagementLogo.Name = "imgBoxUserManagementLogo";
            this.imgBoxUserManagementLogo.Size = new System.Drawing.Size(283, 68);
            this.imgBoxUserManagementLogo.TabIndex = 10;
            this.imgBoxUserManagementLogo.TabStop = false;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.listViewUserManagement);
            this.Controls.Add(this.btnAddNewUserInUserManagementForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTicketOverviewInUserManagementForm);
            this.Controls.Add(this.btnUserManagementInUserManagementForm);
            this.Controls.Add(this.btnIncidentManagementInUserManagementForm);
            this.Controls.Add(this.btnDashboardInUserManagementForm);
            this.Controls.Add(this.imgBoxUserManagementLogo);
            this.Name = "UserManagement";
            this.Text = "UserManagement";
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxUserManagementLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewUserManagement;
        private System.Windows.Forms.ColumnHeader columnIDInUserList;
        private System.Windows.Forms.ColumnHeader columnEmailInUserList;
        private System.Windows.Forms.ColumnHeader columnFirstNameInUserList;
        private System.Windows.Forms.ColumnHeader columnLastNameInUserList;
        private System.Windows.Forms.ColumnHeader columnTicketsInUserList;
        private System.Windows.Forms.Button btnAddNewUserInUserManagementForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTicketOverviewInUserManagementForm;
        private System.Windows.Forms.Button btnUserManagementInUserManagementForm;
        private System.Windows.Forms.Button btnIncidentManagementInUserManagementForm;
        private System.Windows.Forms.Button btnDashboardInUserManagementForm;
        private System.Windows.Forms.PictureBox imgBoxUserManagementLogo;
    }
}