namespace reapEAT
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.butMeal = new System.Windows.Forms.Button();
            this.butCredits = new System.Windows.Forms.Button();
            this.butFridge = new System.Windows.Forms.Button();
            this.butDiets = new System.Windows.Forms.Button();
            this.butSettings = new System.Windows.Forms.Button();
            this.butProfile = new System.Windows.Forms.Button();
            this.butLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butMeal
            // 
            this.butMeal.BackColor = System.Drawing.Color.HotPink;
            this.butMeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butMeal.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMeal.Location = new System.Drawing.Point(12, 12);
            this.butMeal.Name = "butMeal";
            this.butMeal.Size = new System.Drawing.Size(260, 141);
            this.butMeal.TabIndex = 0;
            this.butMeal.Text = "Find Meal";
            this.butMeal.UseVisualStyleBackColor = false;
            this.butMeal.Click += new System.EventHandler(this.ButMeal_Click);
            // 
            // butCredits
            // 
            this.butCredits.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCredits.Location = new System.Drawing.Point(278, 12);
            this.butCredits.Name = "butCredits";
            this.butCredits.Size = new System.Drawing.Size(98, 97);
            this.butCredits.TabIndex = 4;
            this.butCredits.Text = "Credits";
            this.butCredits.UseVisualStyleBackColor = true;
            this.butCredits.Click += new System.EventHandler(this.ButCredits_Click);
            // 
            // butFridge
            // 
            this.butFridge.BackColor = System.Drawing.Color.RoyalBlue;
            this.butFridge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butFridge.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butFridge.Location = new System.Drawing.Point(184, 159);
            this.butFridge.Name = "butFridge";
            this.butFridge.Size = new System.Drawing.Size(284, 111);
            this.butFridge.TabIndex = 2;
            this.butFridge.Text = "Fridge";
            this.butFridge.UseVisualStyleBackColor = false;
            this.butFridge.Click += new System.EventHandler(this.ButFridge_Click);
            // 
            // butDiets
            // 
            this.butDiets.BackColor = System.Drawing.Color.Crimson;
            this.butDiets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butDiets.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDiets.Location = new System.Drawing.Point(12, 159);
            this.butDiets.Name = "butDiets";
            this.butDiets.Size = new System.Drawing.Size(166, 111);
            this.butDiets.TabIndex = 1;
            this.butDiets.Text = "Diet";
            this.butDiets.UseVisualStyleBackColor = false;
            this.butDiets.Click += new System.EventHandler(this.ButDiets_Click);
            // 
            // butSettings
            // 
            this.butSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSettings.Location = new System.Drawing.Point(278, 115);
            this.butSettings.Name = "butSettings";
            this.butSettings.Size = new System.Drawing.Size(98, 38);
            this.butSettings.TabIndex = 5;
            this.butSettings.Text = "Settings";
            this.butSettings.UseVisualStyleBackColor = true;
            this.butSettings.Click += new System.EventHandler(this.ButSettings_Click);
            // 
            // butProfile
            // 
            this.butProfile.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butProfile.Location = new System.Drawing.Point(382, 49);
            this.butProfile.Name = "butProfile";
            this.butProfile.Size = new System.Drawing.Size(86, 104);
            this.butProfile.TabIndex = 3;
            this.butProfile.Text = "Profile";
            this.butProfile.UseVisualStyleBackColor = true;
            this.butProfile.Click += new System.EventHandler(this.ButProfile_Click);
            // 
            // butLogOut
            // 
            this.butLogOut.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogOut.Location = new System.Drawing.Point(382, 12);
            this.butLogOut.Name = "butLogOut";
            this.butLogOut.Size = new System.Drawing.Size(86, 31);
            this.butLogOut.TabIndex = 6;
            this.butLogOut.Text = "Log Out";
            this.butLogOut.UseVisualStyleBackColor = true;
            this.butLogOut.Click += new System.EventHandler(this.ButLogOut_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(480, 282);
            this.Controls.Add(this.butLogOut);
            this.Controls.Add(this.butProfile);
            this.Controls.Add(this.butSettings);
            this.Controls.Add(this.butDiets);
            this.Controls.Add(this.butFridge);
            this.Controls.Add(this.butCredits);
            this.Controls.Add(this.butMeal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butMeal;
        private System.Windows.Forms.Button butCredits;
        private System.Windows.Forms.Button butFridge;
        private System.Windows.Forms.Button butDiets;
        private System.Windows.Forms.Button butSettings;
        private System.Windows.Forms.Button butProfile;
        private System.Windows.Forms.Button butLogOut;
    }
}