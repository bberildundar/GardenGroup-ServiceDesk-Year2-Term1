
namespace UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Usernametxtbx = new System.Windows.Forms.TextBox();
            this.Passwordtxtbx = new System.Windows.Forms.TextBox();
            this.LoginUsernameLbl = new System.Windows.Forms.Label();
            this.PasswordLoginLbl = new System.Windows.Forms.Label();
            this.RemembermeCheckbx = new System.Windows.Forms.CheckBox();
            this.Forgotlinklbl = new System.Windows.Forms.LinkLabel();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginErrorLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(258, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 71);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Usernametxtbx
            // 
            this.Usernametxtbx.Location = new System.Drawing.Point(249, 165);
            this.Usernametxtbx.Multiline = true;
            this.Usernametxtbx.Name = "Usernametxtbx";
            this.Usernametxtbx.Size = new System.Drawing.Size(307, 34);
            this.Usernametxtbx.TabIndex = 2;
            // 
            // Passwordtxtbx
            // 
            this.Passwordtxtbx.Location = new System.Drawing.Point(246, 253);
            this.Passwordtxtbx.Multiline = true;
            this.Passwordtxtbx.Name = "Passwordtxtbx";
            this.Passwordtxtbx.PasswordChar = '*';
            this.Passwordtxtbx.Size = new System.Drawing.Size(307, 35);
            this.Passwordtxtbx.TabIndex = 3;
            // 
            // LoginUsernameLbl
            // 
            this.LoginUsernameLbl.AutoSize = true;
            this.LoginUsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUsernameLbl.Location = new System.Drawing.Point(246, 136);
            this.LoginUsernameLbl.Name = "LoginUsernameLbl";
            this.LoginUsernameLbl.Size = new System.Drawing.Size(138, 20);
            this.LoginUsernameLbl.TabIndex = 4;
            this.LoginUsernameLbl.Text = "Username/Email:";
            // 
            // PasswordLoginLbl
            // 
            this.PasswordLoginLbl.AutoSize = true;
            this.PasswordLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLoginLbl.Location = new System.Drawing.Point(246, 233);
            this.PasswordLoginLbl.Name = "PasswordLoginLbl";
            this.PasswordLoginLbl.Size = new System.Drawing.Size(88, 20);
            this.PasswordLoginLbl.TabIndex = 5;
            this.PasswordLoginLbl.Text = "Password:";
            // 
            // RemembermeCheckbx
            // 
            this.RemembermeCheckbx.AutoSize = true;
            this.RemembermeCheckbx.Location = new System.Drawing.Point(249, 294);
            this.RemembermeCheckbx.Name = "RemembermeCheckbx";
            this.RemembermeCheckbx.Size = new System.Drawing.Size(119, 20);
            this.RemembermeCheckbx.TabIndex = 6;
            this.RemembermeCheckbx.Text = "Remember me";
            this.RemembermeCheckbx.UseVisualStyleBackColor = true;
            // 
            // Forgotlinklbl
            // 
            this.Forgotlinklbl.AutoSize = true;
            this.Forgotlinklbl.Location = new System.Drawing.Point(417, 295);
            this.Forgotlinklbl.Name = "Forgotlinklbl";
            this.Forgotlinklbl.Size = new System.Drawing.Size(127, 16);
            this.Forgotlinklbl.TabIndex = 7;
            this.Forgotlinklbl.TabStop = true;
            this.Forgotlinklbl.Text = "Forgot Login Detail?";
            this.Forgotlinklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forgotlinklbl_LinkClicked);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginBtn.Location = new System.Drawing.Point(246, 366);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(310, 58);
            this.LoginBtn.TabIndex = 8;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginErrorLbl
            // 
            this.LoginErrorLbl.AutoSize = true;
            this.LoginErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LoginErrorLbl.Location = new System.Drawing.Point(336, 328);
            this.LoginErrorLbl.Name = "LoginErrorLbl";
            this.LoginErrorLbl.Size = new System.Drawing.Size(0, 16);
            this.LoginErrorLbl.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginErrorLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Forgotlinklbl);
            this.Controls.Add(this.RemembermeCheckbx);
            this.Controls.Add(this.PasswordLoginLbl);
            this.Controls.Add(this.LoginUsernameLbl);
            this.Controls.Add(this.Passwordtxtbx);
            this.Controls.Add(this.Usernametxtbx);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Usernametxtbx;
        private System.Windows.Forms.TextBox Passwordtxtbx;
        private System.Windows.Forms.Label LoginUsernameLbl;
        private System.Windows.Forms.Label PasswordLoginLbl;
        private System.Windows.Forms.CheckBox RemembermeCheckbx;
        private System.Windows.Forms.LinkLabel Forgotlinklbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label LoginErrorLbl;
    }
}