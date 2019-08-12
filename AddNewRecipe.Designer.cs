namespace reapEAT
{
    partial class AddNewRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewRecipe));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lblPortion = new System.Windows.Forms.Label();
            this.numUDPortion = new System.Windows.Forms.NumericUpDown();
            this.lblType = new System.Windows.Forms.Label();
            this.comBType = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.comBStyle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comBDiet = new System.Windows.Forms.ComboBox();
            this.lblDiet = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblCaloriesValue = new System.Windows.Forms.Label();
            this.txtSearchIngr = new System.Windows.Forms.TextBox();
            this.butSearchIngr = new System.Windows.Forms.Button();
            this.listVIngr = new System.Windows.Forms.ListView();
            this.ColumnIngr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtQuantityIngr = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.picBImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPortion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtRecipe
            // 
            this.txtRecipe.Location = new System.Drawing.Point(311, 27);
            this.txtRecipe.Multiline = true;
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(336, 220);
            this.txtRecipe.TabIndex = 3;
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Location = new System.Drawing.Point(308, 9);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(41, 13);
            this.lblRecipe.TabIndex = 2;
            this.lblRecipe.Text = "Recipe";
            // 
            // lblPortion
            // 
            this.lblPortion.AutoSize = true;
            this.lblPortion.Location = new System.Drawing.Point(19, 112);
            this.lblPortion.Name = "lblPortion";
            this.lblPortion.Size = new System.Drawing.Size(40, 13);
            this.lblPortion.TabIndex = 4;
            this.lblPortion.Text = "Portion";
            // 
            // numUDPortion
            // 
            this.numUDPortion.Location = new System.Drawing.Point(65, 110);
            this.numUDPortion.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDPortion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDPortion.Name = "numUDPortion";
            this.numUDPortion.Size = new System.Drawing.Size(48, 20);
            this.numUDPortion.TabIndex = 5;
            this.numUDPortion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDPortion.ValueChanged += new System.EventHandler(this.NumUDPortion_ValueChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(19, 64);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            // 
            // comBType
            // 
            this.comBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBType.FormattingEnabled = true;
            this.comBType.Location = new System.Drawing.Point(60, 56);
            this.comBType.Name = "comBType";
            this.comBType.Size = new System.Drawing.Size(129, 21);
            this.comBType.TabIndex = 7;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(99, 83);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(90, 20);
            this.txtTime.TabIndex = 9;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(19, 86);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Prepering time";
            // 
            // comBStyle
            // 
            this.comBStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBStyle.FormattingEnabled = true;
            this.comBStyle.Location = new System.Drawing.Point(60, 136);
            this.comBStyle.Name = "comBStyle";
            this.comBStyle.Size = new System.Drawing.Size(129, 21);
            this.comBStyle.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Style";
            // 
            // comBDiet
            // 
            this.comBDiet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBDiet.FormattingEnabled = true;
            this.comBDiet.Location = new System.Drawing.Point(60, 163);
            this.comBDiet.Name = "comBDiet";
            this.comBDiet.Size = new System.Drawing.Size(129, 21);
            this.comBDiet.TabIndex = 13;
            // 
            // lblDiet
            // 
            this.lblDiet.AutoSize = true;
            this.lblDiet.Location = new System.Drawing.Point(19, 171);
            this.lblDiet.Name = "lblDiet";
            this.lblDiet.Size = new System.Drawing.Size(26, 13);
            this.lblDiet.TabIndex = 12;
            this.lblDiet.Text = "Diet";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(19, 199);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(44, 13);
            this.lblCalories.TabIndex = 14;
            this.lblCalories.Text = "Calories";
            // 
            // lblCaloriesValue
            // 
            this.lblCaloriesValue.AutoSize = true;
            this.lblCaloriesValue.Location = new System.Drawing.Point(69, 199);
            this.lblCaloriesValue.Name = "lblCaloriesValue";
            this.lblCaloriesValue.Size = new System.Drawing.Size(13, 13);
            this.lblCaloriesValue.TabIndex = 15;
            this.lblCaloriesValue.Text = "0";
            // 
            // txtSearchIngr
            // 
            this.txtSearchIngr.Location = new System.Drawing.Point(351, 302);
            this.txtSearchIngr.Name = "txtSearchIngr";
            this.txtSearchIngr.Size = new System.Drawing.Size(117, 20);
            this.txtSearchIngr.TabIndex = 26;
            // 
            // butSearchIngr
            // 
            this.butSearchIngr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butSearchIngr.Location = new System.Drawing.Point(351, 270);
            this.butSearchIngr.Name = "butSearchIngr";
            this.butSearchIngr.Size = new System.Drawing.Size(117, 26);
            this.butSearchIngr.TabIndex = 25;
            this.butSearchIngr.Text = "Search";
            this.butSearchIngr.UseVisualStyleBackColor = true;
            this.butSearchIngr.Click += new System.EventHandler(this.ButSearchIngr_Click);
            // 
            // listVIngr
            // 
            this.listVIngr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnIngr});
            this.listVIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listVIngr.FullRowSelect = true;
            this.listVIngr.GridLines = true;
            this.listVIngr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listVIngr.HideSelection = false;
            this.listVIngr.Location = new System.Drawing.Point(487, 270);
            this.listVIngr.MultiSelect = false;
            this.listVIngr.Name = "listVIngr";
            this.listVIngr.Size = new System.Drawing.Size(160, 123);
            this.listVIngr.TabIndex = 24;
            this.listVIngr.UseCompatibleStateImageBehavior = false;
            this.listVIngr.View = System.Windows.Forms.View.Details;
            this.listVIngr.DoubleClick += new System.EventHandler(this.ListVIngr_DoubleClick);
            // 
            // ColumnIngr
            // 
            this.ColumnIngr.Text = "Ingredient";
            this.ColumnIngr.Width = 134;
            // 
            // txtQuantityIngr
            // 
            this.txtQuantityIngr.Location = new System.Drawing.Point(368, 364);
            this.txtQuantityIngr.Name = "txtQuantityIngr";
            this.txtQuantityIngr.Size = new System.Drawing.Size(100, 20);
            this.txtQuantityIngr.TabIndex = 27;
            this.txtQuantityIngr.Text = "1";
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(505, 586);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(142, 61);
            this.butAdd.TabIndex = 28;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // picBImage
            // 
            this.picBImage.Image = ((System.Drawing.Image)(resources.GetObject("picBImage.Image")));
            this.picBImage.Location = new System.Drawing.Point(399, 411);
            this.picBImage.Name = "picBImage";
            this.picBImage.Size = new System.Drawing.Size(248, 144);
            this.picBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBImage.TabIndex = 29;
            this.picBImage.TabStop = false;
            this.picBImage.Click += new System.EventHandler(this.PicBImage_Click);
            // 
            // AddNewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 659);
            this.Controls.Add(this.picBImage);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.txtQuantityIngr);
            this.Controls.Add(this.txtSearchIngr);
            this.Controls.Add(this.butSearchIngr);
            this.Controls.Add(this.listVIngr);
            this.Controls.Add(this.lblCaloriesValue);
            this.Controls.Add(this.lblCalories);
            this.Controls.Add(this.comBDiet);
            this.Controls.Add(this.lblDiet);
            this.Controls.Add(this.comBStyle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.comBType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.numUDPortion);
            this.Controls.Add(this.lblPortion);
            this.Controls.Add(this.txtRecipe);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "AddNewRecipe";
            this.Text = "AddNewRecipe";
            ((System.ComponentModel.ISupportInitialize)(this.numUDPortion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.Label lblPortion;
        private System.Windows.Forms.NumericUpDown numUDPortion;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comBType;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ComboBox comBStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBDiet;
        private System.Windows.Forms.Label lblDiet;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.Label lblCaloriesValue;
        private System.Windows.Forms.TextBox txtSearchIngr;
        private System.Windows.Forms.Button butSearchIngr;
        private System.Windows.Forms.ListView listVIngr;
        private System.Windows.Forms.ColumnHeader ColumnIngr;
        private System.Windows.Forms.TextBox txtQuantityIngr;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.PictureBox picBImage;
    }
}