namespace reapEAT
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
            this.lblSwitchLogReg = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRepPass = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.butConfirm = new System.Windows.Forms.Button();
            this.lblEmailInfo = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblPassInfo = new System.Windows.Forms.Label();
            this.lblLogInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSwitchLogReg
            // 
            this.lblSwitchLogReg.AutoSize = true;
            this.lblSwitchLogReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSwitchLogReg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSwitchLogReg.Location = new System.Drawing.Point(85, 275);
            this.lblSwitchLogReg.Name = "lblSwitchLogReg";
            this.lblSwitchLogReg.Size = new System.Drawing.Size(176, 13);
            this.lblSwitchLogReg.TabIndex = 0;
            this.lblSwitchLogReg.Text = "Don,t have account? Register now!";
            this.lblSwitchLogReg.Click += new System.EventHandler(this.LblSwitchLogReg_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(11, 45);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(105, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Visible = false;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(11, 88);
            this.txtNick.MaxLength = 10;
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(105, 20);
            this.txtNick.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(11, 143);
            this.txtPass.MaxLength = 20;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(105, 20);
            this.txtPass.TabIndex = 3;
            // 
            // txtRepPass
            // 
            this.txtRepPass.Location = new System.Drawing.Point(11, 192);
            this.txtRepPass.MaxLength = 20;
            this.txtRepPass.Name = "txtRepPass";
            this.txtRepPass.PasswordChar = '*';
            this.txtRepPass.Size = new System.Drawing.Size(105, 20);
            this.txtRepPass.TabIndex = 4;
            this.txtRepPass.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(145, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 22);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Login";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 29);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(11, 72);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(11, 124);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Location = new System.Drawing.Point(11, 176);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(91, 13);
            this.lblRepeatPassword.TabIndex = 9;
            this.lblRepeatPassword.Text = "Repeat Password";
            this.lblRepeatPassword.Visible = false;
            // 
            // butConfirm
            // 
            this.butConfirm.Location = new System.Drawing.Point(11, 231);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(105, 24);
            this.butConfirm.TabIndex = 10;
            this.butConfirm.Text = "Log in";
            this.butConfirm.UseVisualStyleBackColor = true;
            this.butConfirm.Click += new System.EventHandler(this.ButConfirm_Click);
            // 
            // lblEmailInfo
            // 
            this.lblEmailInfo.AutoSize = true;
            this.lblEmailInfo.ForeColor = System.Drawing.Color.Red;
            this.lblEmailInfo.Location = new System.Drawing.Point(122, 48);
            this.lblEmailInfo.Name = "lblEmailInfo";
            this.lblEmailInfo.Size = new System.Drawing.Size(99, 13);
            this.lblEmailInfo.TabIndex = 11;
            this.lblEmailInfo.Text = "Email is alreay used";
            this.lblEmailInfo.Visible = false;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.ForeColor = System.Drawing.Color.Red;
            this.lblUserInfo.Location = new System.Drawing.Point(122, 91);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(128, 13);
            this.lblUserInfo.TabIndex = 12;
            this.lblUserInfo.Text = "Username is already used";
            this.lblUserInfo.Visible = false;
            // 
            // lblPassInfo
            // 
            this.lblPassInfo.AutoSize = true;
            this.lblPassInfo.ForeColor = System.Drawing.Color.Red;
            this.lblPassInfo.Location = new System.Drawing.Point(122, 146);
            this.lblPassInfo.Name = "lblPassInfo";
            this.lblPassInfo.Size = new System.Drawing.Size(128, 13);
            this.lblPassInfo.TabIndex = 13;
            this.lblPassInfo.Text = "Password aren\'t the same";
            this.lblPassInfo.Visible = false;
            // 
            // lblLogInfo
            // 
            this.lblLogInfo.AutoSize = true;
            this.lblLogInfo.ForeColor = System.Drawing.Color.Red;
            this.lblLogInfo.Location = new System.Drawing.Point(122, 237);
            this.lblLogInfo.Name = "lblLogInfo";
            this.lblLogInfo.Size = new System.Drawing.Size(148, 13);
            this.lblLogInfo.TabIndex = 14;
            this.lblLogInfo.Text = "Wrong nickname or password";
            this.lblLogInfo.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 307);
            this.Controls.Add(this.lblLogInfo);
            this.Controls.Add(this.lblPassInfo);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.lblEmailInfo);
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.lblRepeatPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtRepPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSwitchLogReg);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSwitchLogReg;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRepPass;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.Button butConfirm;
        private System.Windows.Forms.Label lblEmailInfo;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblPassInfo;
        private System.Windows.Forms.Label lblLogInfo;
    }
}