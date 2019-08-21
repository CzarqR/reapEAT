namespace reapEAT
{
    partial class Recipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recipe));
            this.picDish = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblFav = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblDiet = new System.Windows.Forms.Label();
            this.numPortion = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butShopList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPortion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDish
            // 
            this.picDish.Location = new System.Drawing.Point(12, 32);
            this.picDish.Name = "picDish";
            this.picDish.Size = new System.Drawing.Size(320, 180);
            this.picDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDish.TabIndex = 0;
            this.picDish.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(12, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoEllipsis = true;
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Location = new System.Drawing.Point(9, 226);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(41, 13);
            this.lblRecipe.TabIndex = 2;
            this.lblRecipe.Text = "Recipe";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(410, 37);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(44, 13);
            this.lblCalories.TabIndex = 3;
            this.lblCalories.Text = "Calories";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(420, 101);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(448, 69);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // lblFav
            // 
            this.lblFav.AutoSize = true;
            this.lblFav.Location = new System.Drawing.Point(440, 197);
            this.lblFav.Name = "lblFav";
            this.lblFav.Size = new System.Drawing.Size(25, 13);
            this.lblFav.TabIndex = 7;
            this.lblFav.Text = "Fav";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(406, 5);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Author";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(441, 133);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(30, 13);
            this.lblStyle.TabIndex = 9;
            this.lblStyle.Text = "Style";
            // 
            // lblDiet
            // 
            this.lblDiet.AutoSize = true;
            this.lblDiet.Location = new System.Drawing.Point(439, 165);
            this.lblDiet.Name = "lblDiet";
            this.lblDiet.Size = new System.Drawing.Size(26, 13);
            this.lblDiet.TabIndex = 10;
            this.lblDiet.Text = "Diet";
            // 
            // numPortion
            // 
            this.numPortion.BackColor = System.Drawing.Color.SandyBrown;
            this.numPortion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPortion.DecimalPlaces = 2;
            this.numPortion.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numPortion.Location = new System.Drawing.Point(59, 10);
            this.numPortion.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numPortion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPortion.Name = "numPortion";
            this.numPortion.Size = new System.Drawing.Size(44, 16);
            this.numPortion.TabIndex = 11;
            this.numPortion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPortion.ValueChanged += new System.EventHandler(this.NumPortion_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Diet && Health -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cooking Style -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "Author -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "reapEAT Stars -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Portion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Prepering Time -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(349, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Dish Type -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(349, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Calories -";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.butShopList);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numPortion);
            this.panel1.Location = new System.Drawing.Point(337, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 359);
            this.panel1.TabIndex = 20;
            // 
            // butShopList
            // 
            this.butShopList.BackColor = System.Drawing.Color.SandyBrown;
            this.butShopList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butShopList.Location = new System.Drawing.Point(130, 3);
            this.butShopList.Name = "butShopList";
            this.butShopList.Size = new System.Drawing.Size(93, 23);
            this.butShopList.TabIndex = 16;
            this.butShopList.Text = "Shopping List";
            this.butShopList.UseVisualStyleBackColor = false;
            // 
            // Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(566, 577);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDiet);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblFav);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picDish);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Recipe";
            this.Text = "Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.picDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPortion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDish;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFav;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblDiet;
        private System.Windows.Forms.NumericUpDown numPortion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butShopList;
    }
}