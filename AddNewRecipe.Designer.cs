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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.numUDPortion = new System.Windows.Forms.NumericUpDown();
            this.comBType = new System.Windows.Forms.ComboBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.comBStyle = new System.Windows.Forms.ComboBox();
            this.comBDiet = new System.Windows.Forms.ComboBox();
            this.lblCaloriesValue = new System.Windows.Forms.Label();
            this.txtSearchIngr = new System.Windows.Forms.TextBox();
            this.butSearchIngr = new System.Windows.Forms.Button();
            this.listVIngr = new System.Windows.Forms.ListView();
            this.ColumnIngr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtQuantityIngr = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.picBImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRecipe = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblIngrName = new System.Windows.Forms.Label();
            this.lblMeasure = new System.Windows.Forms.Label();
            this.butAddIngr = new System.Windows.Forms.Button();
            this.lblQuntIngr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPortion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtName.Location = new System.Drawing.Point(75, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtRecipe
            // 
            this.txtRecipe.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRecipe.Location = new System.Drawing.Point(292, 26);
            this.txtRecipe.Multiline = true;
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(330, 205);
            this.txtRecipe.TabIndex = 3;
            // 
            // numUDPortion
            // 
            this.numUDPortion.BackColor = System.Drawing.Color.LemonChiffon;
            this.numUDPortion.Location = new System.Drawing.Point(98, 169);
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
            // comBType
            // 
            this.comBType.BackColor = System.Drawing.Color.LemonChiffon;
            this.comBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBType.FormattingEnabled = true;
            this.comBType.Location = new System.Drawing.Point(87, 38);
            this.comBType.Name = "comBType";
            this.comBType.Size = new System.Drawing.Size(148, 21);
            this.comBType.TabIndex = 7;
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtTime.Location = new System.Drawing.Point(115, 134);
            this.txtTime.MaxLength = 4;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(45, 20);
            this.txtTime.TabIndex = 9;
            // 
            // comBStyle
            // 
            this.comBStyle.BackColor = System.Drawing.Color.LemonChiffon;
            this.comBStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBStyle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBStyle.FormattingEnabled = true;
            this.comBStyle.Location = new System.Drawing.Point(106, 71);
            this.comBStyle.Name = "comBStyle";
            this.comBStyle.Size = new System.Drawing.Size(129, 21);
            this.comBStyle.TabIndex = 11;
            // 
            // comBDiet
            // 
            this.comBDiet.BackColor = System.Drawing.Color.LemonChiffon;
            this.comBDiet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBDiet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBDiet.FormattingEnabled = true;
            this.comBDiet.Location = new System.Drawing.Point(106, 104);
            this.comBDiet.Name = "comBDiet";
            this.comBDiet.Size = new System.Drawing.Size(129, 21);
            this.comBDiet.TabIndex = 13;
            // 
            // lblCaloriesValue
            // 
            this.lblCaloriesValue.AutoSize = true;
            this.lblCaloriesValue.Font = new System.Drawing.Font("Microsoft Tai Le", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaloriesValue.Location = new System.Drawing.Point(74, 201);
            this.lblCaloriesValue.Name = "lblCaloriesValue";
            this.lblCaloriesValue.Size = new System.Drawing.Size(15, 16);
            this.lblCaloriesValue.TabIndex = 15;
            this.lblCaloriesValue.Text = "0";
            // 
            // txtSearchIngr
            // 
            this.txtSearchIngr.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtSearchIngr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearchIngr.Location = new System.Drawing.Point(376, 257);
            this.txtSearchIngr.Name = "txtSearchIngr";
            this.txtSearchIngr.Size = new System.Drawing.Size(107, 21);
            this.txtSearchIngr.TabIndex = 26;
            // 
            // butSearchIngr
            // 
            this.butSearchIngr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butSearchIngr.BackColor = System.Drawing.Color.SandyBrown;
            this.butSearchIngr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butSearchIngr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butSearchIngr.Location = new System.Drawing.Point(292, 256);
            this.butSearchIngr.Name = "butSearchIngr";
            this.butSearchIngr.Size = new System.Drawing.Size(78, 23);
            this.butSearchIngr.TabIndex = 25;
            this.butSearchIngr.Text = "Search";
            this.butSearchIngr.UseVisualStyleBackColor = false;
            this.butSearchIngr.Click += new System.EventHandler(this.ButSearchIngr_Click);
            // 
            // listVIngr
            // 
            this.listVIngr.BackColor = System.Drawing.Color.LemonChiffon;
            this.listVIngr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnIngr});
            this.listVIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listVIngr.FullRowSelect = true;
            this.listVIngr.GridLines = true;
            this.listVIngr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listVIngr.HideSelection = false;
            this.listVIngr.Location = new System.Drawing.Point(292, 285);
            this.listVIngr.MultiSelect = false;
            this.listVIngr.Name = "listVIngr";
            this.listVIngr.Size = new System.Drawing.Size(193, 124);
            this.listVIngr.TabIndex = 24;
            this.listVIngr.UseCompatibleStateImageBehavior = false;
            this.listVIngr.View = System.Windows.Forms.View.Details;
            this.listVIngr.DoubleClick += new System.EventHandler(this.ListVIngr_DoubleClick);
            // 
            // ColumnIngr
            // 
            this.ColumnIngr.Text = "Ingredient";
            this.ColumnIngr.Width = 152;
            // 
            // txtQuantityIngr
            // 
            this.txtQuantityIngr.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtQuantityIngr.Location = new System.Drawing.Point(494, 304);
            this.txtQuantityIngr.MaxLength = 6;
            this.txtQuantityIngr.Name = "txtQuantityIngr";
            this.txtQuantityIngr.Size = new System.Drawing.Size(45, 20);
            this.txtQuantityIngr.TabIndex = 27;
            this.txtQuantityIngr.Visible = false;
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.SandyBrown;
            this.butAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butAdd.Location = new System.Drawing.Point(485, 415);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(129, 70);
            this.butAdd.TabIndex = 28;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // picBImage
            // 
            this.picBImage.Image = ((System.Drawing.Image)(resources.GetObject("picBImage.Image")));
            this.picBImage.Location = new System.Drawing.Point(12, 256);
            this.picBImage.Name = "picBImage";
            this.picBImage.Size = new System.Drawing.Size(272, 153);
            this.picBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBImage.TabIndex = 29;
            this.picBImage.TabStop = false;
            this.picBImage.Click += new System.EventHandler(this.PicBImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Diet && Health -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Cooking Style -";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(11, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 18);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Name -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Prepering Time -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Dish Type -";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Calories -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Portion -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "minutes";
            // 
            // lblRecipe
            // 
            this.lblRecipe.AutoSize = true;
            this.lblRecipe.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipe.Location = new System.Drawing.Point(292, 5);
            this.lblRecipe.Name = "lblRecipe";
            this.lblRecipe.Size = new System.Drawing.Size(53, 18);
            this.lblRecipe.TabIndex = 40;
            this.lblRecipe.Text = "Recipe";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(292, 235);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(83, 18);
            this.lblIngredients.TabIndex = 41;
            this.lblIngredients.Text = "Ingredients";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(12, 235);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(50, 18);
            this.lblImage.TabIndex = 42;
            this.lblImage.Text = "Image";
            // 
            // lblIngrName
            // 
            this.lblIngrName.AutoSize = true;
            this.lblIngrName.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrName.Location = new System.Drawing.Point(491, 285);
            this.lblIngrName.Name = "lblIngrName";
            this.lblIngrName.Size = new System.Drawing.Size(77, 16);
            this.lblIngrName.TabIndex = 43;
            this.lblIngrName.Text = "lblIngrName";
            this.lblIngrName.Visible = false;
            // 
            // lblMeasure
            // 
            this.lblMeasure.AutoSize = true;
            this.lblMeasure.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasure.Location = new System.Drawing.Point(545, 306);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(69, 16);
            this.lblMeasure.TabIndex = 44;
            this.lblMeasure.Text = "lblMeasure";
            this.lblMeasure.Visible = false;
            // 
            // butAddIngr
            // 
            this.butAddIngr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butAddIngr.BackColor = System.Drawing.Color.SandyBrown;
            this.butAddIngr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddIngr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butAddIngr.Location = new System.Drawing.Point(494, 330);
            this.butAddIngr.Name = "butAddIngr";
            this.butAddIngr.Size = new System.Drawing.Size(120, 23);
            this.butAddIngr.TabIndex = 45;
            this.butAddIngr.Text = "Add Ingredient";
            this.butAddIngr.UseVisualStyleBackColor = false;
            this.butAddIngr.Visible = false;
            this.butAddIngr.Click += new System.EventHandler(this.ButAddIngr_Click);
            // 
            // lblQuntIngr
            // 
            this.lblQuntIngr.AutoSize = true;
            this.lblQuntIngr.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuntIngr.ForeColor = System.Drawing.Color.Brown;
            this.lblQuntIngr.Location = new System.Drawing.Point(492, 359);
            this.lblQuntIngr.Name = "lblQuntIngr";
            this.lblQuntIngr.Size = new System.Drawing.Size(101, 16);
            this.lblQuntIngr.TabIndex = 46;
            this.lblQuntIngr.Text = "Wrong Quantity!";
            this.lblQuntIngr.Visible = false;
            // 
            // AddNewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(627, 493);
            this.Controls.Add(this.lblQuntIngr);
            this.Controls.Add(this.butAddIngr);
            this.Controls.Add(this.lblMeasure);
            this.Controls.Add(this.lblIngrName);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblRecipe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.picBImage);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.txtQuantityIngr);
            this.Controls.Add(this.txtSearchIngr);
            this.Controls.Add(this.butSearchIngr);
            this.Controls.Add(this.listVIngr);
            this.Controls.Add(this.lblCaloriesValue);
            this.Controls.Add(this.comBDiet);
            this.Controls.Add(this.comBStyle);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.comBType);
            this.Controls.Add(this.numUDPortion);
            this.Controls.Add(this.txtRecipe);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddNewRecipe";
            this.Text = "Add Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.numUDPortion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.NumericUpDown numUDPortion;
        private System.Windows.Forms.ComboBox comBType;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.ComboBox comBStyle;
        private System.Windows.Forms.ComboBox comBDiet;
        private System.Windows.Forms.Label lblCaloriesValue;
        private System.Windows.Forms.TextBox txtSearchIngr;
        private System.Windows.Forms.Button butSearchIngr;
        private System.Windows.Forms.ListView listVIngr;
        private System.Windows.Forms.ColumnHeader ColumnIngr;
        private System.Windows.Forms.TextBox txtQuantityIngr;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.PictureBox picBImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRecipe;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblIngrName;
        private System.Windows.Forms.Label lblMeasure;
        private System.Windows.Forms.Button butAddIngr;
        private System.Windows.Forms.Label lblQuntIngr;
    }
}