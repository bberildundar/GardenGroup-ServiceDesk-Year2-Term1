
namespace UI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.liscensedLblinDashboardForm = new System.Windows.Forms.Label();
            this.NoDeskLblDashboardForm = new System.Windows.Forms.Label();
            this.btnUserManagementInDashBoardForm = new System.Windows.Forms.Button();
            this.btnIncidentManagementInDashboardForm = new System.Windows.Forms.Button();
            this.btnDashboardInDashboardForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CurrentIncidentsLbl = new System.Windows.Forms.Label();
            this.listViewTicketsByUser = new System.Windows.Forms.ListView();
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chartTickets = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEditTicket = new System.Windows.Forms.Button();
            this.sortBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // liscensedLblinDashboardForm
            // 
            this.liscensedLblinDashboardForm.AutoSize = true;
            this.liscensedLblinDashboardForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liscensedLblinDashboardForm.Location = new System.Drawing.Point(706, 33);
            this.liscensedLblinDashboardForm.Name = "liscensedLblinDashboardForm";
            this.liscensedLblinDashboardForm.Size = new System.Drawing.Size(316, 25);
            this.liscensedLblinDashboardForm.TabIndex = 12;
            this.liscensedLblinDashboardForm.Text = "Licensed to: The Garden Group";
            // 
            // NoDeskLblDashboardForm
            // 
            this.NoDeskLblDashboardForm.AutoSize = true;
            this.NoDeskLblDashboardForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoDeskLblDashboardForm.Location = new System.Drawing.Point(904, 2);
            this.NoDeskLblDashboardForm.Name = "NoDeskLblDashboardForm";
            this.NoDeskLblDashboardForm.Size = new System.Drawing.Size(118, 31);
            this.NoDeskLblDashboardForm.TabIndex = 11;
            this.NoDeskLblDashboardForm.Text = "NoDesk";
            // 
            // btnUserManagementInDashBoardForm
            // 
            this.btnUserManagementInDashBoardForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagementInDashBoardForm.Location = new System.Drawing.Point(698, 72);
            this.btnUserManagementInDashBoardForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUserManagementInDashBoardForm.Name = "btnUserManagementInDashBoardForm";
            this.btnUserManagementInDashBoardForm.Size = new System.Drawing.Size(324, 46);
            this.btnUserManagementInDashBoardForm.TabIndex = 10;
            this.btnUserManagementInDashBoardForm.Text = "UserManagement";
            this.btnUserManagementInDashBoardForm.UseVisualStyleBackColor = true;
            this.btnUserManagementInDashBoardForm.Click += new System.EventHandler(this.btnUserManagementInDashBoardForm_Click);
            // 
            // btnIncidentManagementInDashboardForm
            // 
            this.btnIncidentManagementInDashboardForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncidentManagementInDashboardForm.Location = new System.Drawing.Point(353, 72);
            this.btnIncidentManagementInDashboardForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIncidentManagementInDashboardForm.Name = "btnIncidentManagementInDashboardForm";
            this.btnIncidentManagementInDashboardForm.Size = new System.Drawing.Size(324, 46);
            this.btnIncidentManagementInDashboardForm.TabIndex = 9;
            this.btnIncidentManagementInDashboardForm.Text = "Incident Management";
            this.btnIncidentManagementInDashboardForm.UseVisualStyleBackColor = true;
            this.btnIncidentManagementInDashboardForm.Click += new System.EventHandler(this.btnIncidentManagementInDashboardForm_Click);
            // 
            // btnDashboardInDashboardForm
            // 
            this.btnDashboardInDashboardForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardInDashboardForm.Location = new System.Drawing.Point(5, 72);
            this.btnDashboardInDashboardForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboardInDashboardForm.Name = "btnDashboardInDashboardForm";
            this.btnDashboardInDashboardForm.Size = new System.Drawing.Size(324, 46);
            this.btnDashboardInDashboardForm.TabIndex = 8;
            this.btnDashboardInDashboardForm.Text = "Dashboard";
            this.btnDashboardInDashboardForm.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 62);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // CurrentIncidentsLbl
            // 
            this.CurrentIncidentsLbl.AutoSize = true;
            this.CurrentIncidentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentIncidentsLbl.Location = new System.Drawing.Point(17, 126);
            this.CurrentIncidentsLbl.Name = "CurrentIncidentsLbl";
            this.CurrentIncidentsLbl.Size = new System.Drawing.Size(381, 32);
            this.CurrentIncidentsLbl.TabIndex = 14;
            this.CurrentIncidentsLbl.Text = "Current Incidents and Tickets";
            // 
            // listViewTicketsByUser
            // 
            this.listViewTicketsByUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Subject,
            this.Description,
            this.Date,
            this.Status,
            this.Priority});
            this.listViewTicketsByUser.FullRowSelect = true;
            this.listViewTicketsByUser.HideSelection = false;
            this.listViewTicketsByUser.Location = new System.Drawing.Point(24, 477);
            this.listViewTicketsByUser.Margin = new System.Windows.Forms.Padding(4);
            this.listViewTicketsByUser.Name = "listViewTicketsByUser";
            this.listViewTicketsByUser.Size = new System.Drawing.Size(998, 237);
            this.listViewTicketsByUser.TabIndex = 15;
            this.listViewTicketsByUser.UseCompatibleStateImageBehavior = false;
            this.listViewTicketsByUser.SelectedIndexChanged += new System.EventHandler(this.listViewTicketsByUser_SelectedIndexChanged);
            // 
            // Subject
            // 
            this.Subject.Text = "Subject";
            this.Subject.Width = 80;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 200;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 200;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 150;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 150;
            // 
            // chartTickets
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTickets.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTickets.Legends.Add(legend1);
            this.chartTickets.Location = new System.Drawing.Point(24, 176);
            this.chartTickets.Margin = new System.Windows.Forms.Padding(4);
            this.chartTickets.Name = "chartTickets";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTickets.Series.Add(series1);
            this.chartTickets.Size = new System.Drawing.Size(998, 293);
            this.chartTickets.TabIndex = 16;
            this.chartTickets.Text = "chart1";
            // 
            // btnEditTicket
            // 
            this.btnEditTicket.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTicket.Location = new System.Drawing.Point(23, 722);
            this.btnEditTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditTicket.Name = "btnEditTicket";
            this.btnEditTicket.Size = new System.Drawing.Size(148, 33);
            this.btnEditTicket.TabIndex = 17;
            this.btnEditTicket.Text = "Edit Ticket";
            this.btnEditTicket.UseVisualStyleBackColor = false;
            this.btnEditTicket.Click += new System.EventHandler(this.btnEditTicket_Click);
            // 
            // sortBox
            // 
            this.sortBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "By priority",
            "Undo"});
            this.sortBox.Location = new System.Drawing.Point(901, 727);
            this.sortBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(121, 30);
            this.sortBox.TabIndex = 18;
            this.sortBox.Text = "Sort";
            this.sortBox.SelectedIndexChanged += new System.EventHandler(this.sortBox_SelectedIndexChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 792);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.btnEditTicket);
            this.Controls.Add(this.chartTickets);
            this.Controls.Add(this.listViewTicketsByUser);
            this.Controls.Add(this.CurrentIncidentsLbl);
            this.Controls.Add(this.liscensedLblinDashboardForm);
            this.Controls.Add(this.NoDeskLblDashboardForm);
            this.Controls.Add(this.btnUserManagementInDashBoardForm);
            this.Controls.Add(this.btnIncidentManagementInDashboardForm);
            this.Controls.Add(this.btnDashboardInDashboardForm);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label liscensedLblinDashboardForm;
        private System.Windows.Forms.Label NoDeskLblDashboardForm;
        private System.Windows.Forms.Button btnUserManagementInDashBoardForm;
        private System.Windows.Forms.Button btnIncidentManagementInDashboardForm;
        private System.Windows.Forms.Button btnDashboardInDashboardForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label CurrentIncidentsLbl;
        private System.Windows.Forms.ListView listViewTicketsByUser;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTickets;
        private System.Windows.Forms.Button btnEditTicket;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.ComboBox sortBox;
    }
}