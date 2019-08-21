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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblSwitchLogReg = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRepPass = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRepeatPassword = new System.Windows.Forms.Label();
            this.butConfirm = new System.Windows.Forms.Button();
            this.lblEmailInfo = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.lblPassInfo = new System.Windows.Forms.Label();
            this.lblLogInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblForgetPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSwitchLogReg
            // 
            this.lblSwitchLogReg.AutoSize = true;
            this.lblSwitchLogReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSwitchLogReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSwitchLogReg.ForeColor = System.Drawing.Color.Gold;
            this.lblSwitchLogReg.Location = new System.Drawing.Point(51, 302);
            this.lblSwitchLogReg.Name = "lblSwitchLogReg";
            this.lblSwitchLogReg.Size = new System.Drawing.Size(256, 20);
            this.lblSwitchLogReg.TabIndex = 0;
            this.lblSwitchLogReg.Text = "Don\'t have account? Register now!";
            this.lblSwitchLogReg.Click += new System.EventHandler(this.LblSwitchLogReg_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(168, 468);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(125, 19);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Visible = false;
            // 
            // txtNick
            // 
            this.txtNick.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtNick.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNick.Location = new System.Drawing.Point(12, 174);
            this.txtNick.MaxLength = 10;
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(125, 19);
            this.txtNick.TabIndex = 2;
            this.txtNick.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNick_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPass.Location = new System.Drawing.Point(12, 217);
            this.txtPass.MaxLength = 20;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(125, 19);
            this.txtPass.TabIndex = 3;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPass_KeyPress);
            // 
            // txtRepPass
            // 
            this.txtRepPass.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtRepPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRepPass.Location = new System.Drawing.Point(168, 528);
            this.txtRepPass.MaxLength = 20;
            this.txtRepPass.Name = "txtRepPass";
            this.txtRepPass.PasswordChar = '*';
            this.txtRepPass.Size = new System.Drawing.Size(125, 19);
            this.txtRepPass.TabIndex = 4;
            this.txtRepPass.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.Location = new System.Drawing.Point(168, 447);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.Location = new System.Drawing.Point(11, 153);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 15);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassword.Location = new System.Drawing.Point(12, 196);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.AutoSize = true;
            this.lblRepeatPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRepeatPassword.Location = new System.Drawing.Point(165, 498);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(104, 15);
            this.lblRepeatPassword.TabIndex = 9;
            this.lblRepeatPassword.Text = "Repeat Password";
            this.lblRepeatPassword.Visible = false;
            // 
            // butConfirm
            // 
            this.butConfirm.BackColor = System.Drawing.Color.SandyBrown;
            this.butConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butConfirm.Location = new System.Drawing.Point(12, 255);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(125, 30);
            this.butConfirm.TabIndex = 5;
            this.butConfirm.Text = "Log in";
            this.butConfirm.UseVisualStyleBackColor = false;
            this.butConfirm.Click += new System.EventHandler(this.ButConfirm_Click);
            // 
            // lblEmailInfo
            // 
            this.lblEmailInfo.AutoSize = true;
            this.lblEmailInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmailInfo.ForeColor = System.Drawing.Color.Brown;
            this.lblEmailInfo.Location = new System.Drawing.Point(213, 447);
            this.lblEmailInfo.Name = "lblEmailInfo";
            this.lblEmailInfo.Size = new System.Drawing.Size(137, 16);
            this.lblEmailInfo.TabIndex = 11;
            this.lblEmailInfo.Text = "Email is already used";
            this.lblEmailInfo.Visible = false;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.Brown;
            this.lblUserInfo.Location = new System.Drawing.Point(82, 152);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(166, 16);
            this.lblUserInfo.TabIndex = 12;
            this.lblUserInfo.Text = "Username is already used";
            this.lblUserInfo.Visible = false;
            // 
            // lblPassInfo
            // 
            this.lblPassInfo.AutoSize = true;
            this.lblPassInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassInfo.ForeColor = System.Drawing.Color.Brown;
            this.lblPassInfo.Location = new System.Drawing.Point(79, 196);
            this.lblPassInfo.Name = "lblPassInfo";
            this.lblPassInfo.Size = new System.Drawing.Size(169, 16);
            this.lblPassInfo.TabIndex = 13;
            this.lblPassInfo.Text = "Passwords aren\'t the same";
            this.lblPassInfo.Visible = false;
            // 
            // lblLogInfo
            // 
            this.lblLogInfo.AutoSize = true;
            this.lblLogInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogInfo.ForeColor = System.Drawing.Color.Brown;
            this.lblLogInfo.Location = new System.Drawing.Point(143, 262);
            this.lblLogInfo.Name = "lblLogInfo";
            this.lblLogInfo.Size = new System.Drawing.Size(186, 16);
            this.lblLogInfo.TabIndex = 14;
            this.lblLogInfo.Text = "Wrong nickname or password";
            this.lblLogInfo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblForgetPassword.ForeColor = System.Drawing.Color.Gold;
            this.lblForgetPassword.Location = new System.Drawing.Point(259, 337);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(99, 15);
            this.lblForgetPassword.TabIndex = 16;
            this.lblForgetPassword.Text = "Forget Password";
            this.lblForgetPassword.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(326, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(370, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblForgetPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLogInfo);
            this.Controls.Add(this.lblPassInfo);
            this.Controls.Add(this.lblUserInfo);
            this.Controls.Add(this.lblEmailInfo);
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.lblRepeatPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtRepPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblSwitchLogReg);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSwitchLogReg;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRepPass;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRepeatPassword;
        private System.Windows.Forms.Button butConfirm;
        private System.Windows.Forms.Label lblEmailInfo;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Label lblPassInfo;
        private System.Windows.Forms.Label lblLogInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblForgetPassword;
        private System.Windows.Forms.Button button1;
    }


}