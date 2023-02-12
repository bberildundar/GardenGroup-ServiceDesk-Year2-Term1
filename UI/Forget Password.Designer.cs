namespace UI
{
    partial class Forget_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forget_Password));
            this.btnUsed = new System.Windows.Forms.Button();
            this.lblUsed = new System.Windows.Forms.Label();
            this.txtUsed = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblFourDigitCode = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUsed
            // 
            this.btnUsed.BackColor = System.Drawing.Color.MediumPurple;
            this.btnUsed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsed.Location = new System.Drawing.Point(319, 353);
            this.btnUsed.Name = "btnUsed";
            this.btnUsed.Size = new System.Drawing.Size(140, 62);
            this.btnUsed.TabIndex = 17;
            this.btnUsed.UseVisualStyleBackColor = false;
            this.btnUsed.Click += new System.EventHandler(this.btnUsed_Click);
            // 
            // lblUsed
            // 
            this.lblUsed.AutoSize = true;
            this.lblUsed.Location = new System.Drawing.Point(245, 179);
            this.lblUsed.Name = "lblUsed";
            this.lblUsed.Size = new System.Drawing.Size(82, 16);
            this.lblUsed.TabIndex = 13;
            this.lblUsed.Text = "Enter E-mail:";
            // 
            // txtUsed
            // 
            this.txtUsed.Location = new System.Drawing.Point(245, 199);
            this.txtUsed.Name = "txtUsed";
            this.txtUsed.Size = new System.Drawing.Size(307, 22);
            this.txtUsed.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 71);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.MediumPurple;
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Location = new System.Drawing.Point(12, 395);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(110, 43);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return to Login";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblFourDigitCode
            // 
            this.lblFourDigitCode.AutoSize = true;
            this.lblFourDigitCode.Location = new System.Drawing.Point(242, 259);
            this.lblFourDigitCode.Name = "lblFourDigitCode";
            this.lblFourDigitCode.Size = new System.Drawing.Size(0, 16);
            this.lblFourDigitCode.TabIndex = 19;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(245, 233);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(118, 16);
            this.lblConfirm.TabIndex = 21;
            this.lblConfirm.Text = "Confirm Password:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(245, 253);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.PasswordChar = '*';
            this.txtConfirm.Size = new System.Drawing.Size(307, 22);
            this.txtConfirm.TabIndex = 20;
            // 
            // Forget_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblFourDigitCode);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUsed);
            this.Controls.Add(this.lblUsed);
            this.Controls.Add(this.txtUsed);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Forget_Password";
            this.Text = "Forget_Password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUsed;
        private System.Windows.Forms.Label lblUsed;
        private System.Windows.Forms.TextBox txtUsed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblFourDigitCode;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
    }
}