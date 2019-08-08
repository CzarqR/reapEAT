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
            this.picDish = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPortion = new System.Windows.Forms.Label();
            this.lblFav = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblDiet = new System.Windows.Forms.Label();
            this.numPortion = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPortion)).BeginInit();
            this.SuspendLayout();
            // 
            // picDish
            // 
            this.picDish.Location = new System.Drawing.Point(12, 12);
            this.picDish.Name = "picDish";
            this.picDish.Size = new System.Drawing.Size(320, 180);
            this.picDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDish.TabIndex = 0;
            this.picDish.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(372, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoEllipsis = true;
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Location = new System.Drawing.Point(373, 55);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(41, 13);
            this.lblRecipe.TabIndex = 2;
            this.lblRecipe.Text = "Recipe";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(12, 215);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(44, 13);
            this.lblCalories.TabIndex = 3;
            this.lblCalories.Text = "Calories";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 311);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 279);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time";
            // 
            // lblPortion
            // 
            this.lblPortion.AutoSize = true;
            this.lblPortion.Location = new System.Drawing.Point(12, 375);
            this.lblPortion.Name = "lblPortion";
            this.lblPortion.Size = new System.Drawing.Size(40, 13);
            this.lblPortion.TabIndex = 6;
            this.lblPortion.Text = "Portion";
            // 
            // lblFav
            // 
            this.lblFav.AutoSize = true;
            this.lblFav.Location = new System.Drawing.Point(12, 407);
            this.lblFav.Name = "lblFav";
            this.lblFav.Size = new System.Drawing.Size(25, 13);
            this.lblFav.TabIndex = 7;
            this.lblFav.Text = "Fav";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(12, 247);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Author";
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Location = new System.Drawing.Point(12, 343);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(30, 13);
            this.lblStyle.TabIndex = 9;
            this.lblStyle.Text = "Style";
            // 
            // lblDiet
            // 
            this.lblDiet.AutoSize = true;
            this.lblDiet.Location = new System.Drawing.Point(12, 439);
            this.lblDiet.Name = "lblDiet";
            this.lblDiet.Size = new System.Drawing.Size(26, 13);
            this.lblDiet.TabIndex = 10;
            this.lblDiet.Text = "Diet";
            // 
            // numPortion
            // 
            this.numPortion.Location = new System.Drawing.Point(58, 373);
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
            this.numPortion.Size = new System.Drawing.Size(40, 20);
            this.numPortion.TabIndex = 11;
            this.numPortion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPortion.ValueChanged += new System.EventHandler(this.NumPortion_ValueChanged);
            // 
            // Recipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 631);
            this.Controls.Add(this.numPortion);
            this.Controls.Add(this.lblDiet);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblFav);
            this.Controls.Add(this.lblPortion);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picDish);
            this.Name = "Recipe";
            this.Text = "Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.picDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPortion)).EndInit();
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
        private System.Windows.Forms.Label lblPortion;
        private System.Windows.Forms.Label lblFav;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblDiet;
        private System.Windows.Forms.NumericUpDown numPortion;
    }
}