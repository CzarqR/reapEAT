namespace reapEAT
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listVSearcher = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCalories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDishType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFavourites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDiet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLBFoodType = new System.Windows.Forms.CheckedListBox();
            this.chLBStyle = new System.Windows.Forms.CheckedListBox();
            this.chLBDiet = new System.Windows.Forms.CheckedListBox();
            this.txtCalMin = new System.Windows.Forms.TextBox();
            this.txtCalMax = new System.Windows.Forms.TextBox();
            this.txtTimeMin = new System.Windows.Forms.TextBox();
            this.txtTimeMax = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butTEST = new System.Windows.Forms.Button();
            this.lblCalMin = new System.Windows.Forms.Label();
            this.lblCalMax = new System.Windows.Forms.Label();
            this.lblTimeMin = new System.Windows.Forms.Label();
            this.lblTimeMax = new System.Windows.Forms.Label();
            this.listVIngr = new System.Windows.Forms.ListView();
            this.ColumnIngr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butSearchIngr = new System.Windows.Forms.Button();
            this.txtSearchIngr = new System.Windows.Forms.TextBox();
            this.LBLTEST = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(128, 72);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listVSearcher
            // 
            this.listVSearcher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnCalories,
            this.columnDishType,
            this.columnStyle,
            this.columnTime,
            this.columnFavourites,
            this.columnDiet});
            this.listVSearcher.FullRowSelect = true;
            this.listVSearcher.HideSelection = false;
            this.listVSearcher.LargeImageList = this.imageList;
            this.listVSearcher.Location = new System.Drawing.Point(15, 12);
            this.listVSearcher.Name = "listVSearcher";
            this.listVSearcher.Size = new System.Drawing.Size(790, 413);
            this.listVSearcher.SmallImageList = this.imageList;
            this.listVSearcher.TabIndex = 4;
            this.listVSearcher.UseCompatibleStateImageBehavior = false;
            this.listVSearcher.View = System.Windows.Forms.View.Details;
            this.listVSearcher.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnSort);
            this.listVSearcher.DoubleClick += new System.EventHandler(this.ListVSearcher_DoubleClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 190;
            // 
            // columnCalories
            // 
            this.columnCalories.Text = "Calories";
            this.columnCalories.Width = 75;
            // 
            // columnDishType
            // 
            this.columnDishType.Text = "Dish Type";
            this.columnDishType.Width = 100;
            // 
            // columnStyle
            // 
            this.columnStyle.Text = "Style";
            this.columnStyle.Width = 125;
            // 
            // columnTime
            // 
            this.columnTime.Text = "Time";
            this.columnTime.Width = 75;
            // 
            // columnFavourites
            // 
            this.columnFavourites.Text = "Favourites";
            this.columnFavourites.Width = 75;
            // 
            // columnDiet
            // 
            this.columnDiet.Text = "Diet";
            this.columnDiet.Width = 128;
            // 
            // chLBFoodType
            // 
            this.chLBFoodType.CheckOnClick = true;
            this.chLBFoodType.FormattingEnabled = true;
            this.chLBFoodType.Location = new System.Drawing.Point(808, 146);
            this.chLBFoodType.Name = "chLBFoodType";
            this.chLBFoodType.Size = new System.Drawing.Size(117, 64);
            this.chLBFoodType.TabIndex = 5;
            // 
            // chLBStyle
            // 
            this.chLBStyle.CheckOnClick = true;
            this.chLBStyle.FormattingEnabled = true;
            this.chLBStyle.Location = new System.Drawing.Point(808, 223);
            this.chLBStyle.Name = "chLBStyle";
            this.chLBStyle.Size = new System.Drawing.Size(117, 64);
            this.chLBStyle.TabIndex = 6;
            // 
            // chLBDiet
            // 
            this.chLBDiet.CheckOnClick = true;
            this.chLBDiet.FormattingEnabled = true;
            this.chLBDiet.Location = new System.Drawing.Point(811, 361);
            this.chLBDiet.Name = "chLBDiet";
            this.chLBDiet.Size = new System.Drawing.Size(114, 64);
            this.chLBDiet.TabIndex = 7;
            // 
            // txtCalMin
            // 
            this.txtCalMin.Location = new System.Drawing.Point(877, 81);
            this.txtCalMin.MaxLength = 5;
            this.txtCalMin.Name = "txtCalMin";
            this.txtCalMin.Size = new System.Drawing.Size(48, 20);
            this.txtCalMin.TabIndex = 8;
            // 
            // txtCalMax
            // 
            this.txtCalMax.Location = new System.Drawing.Point(877, 110);
            this.txtCalMax.MaxLength = 5;
            this.txtCalMax.Name = "txtCalMax";
            this.txtCalMax.Size = new System.Drawing.Size(48, 20);
            this.txtCalMax.TabIndex = 9;
            // 
            // txtTimeMin
            // 
            this.txtTimeMin.Location = new System.Drawing.Point(863, 298);
            this.txtTimeMin.MaxLength = 5;
            this.txtTimeMin.Name = "txtTimeMin";
            this.txtTimeMin.Size = new System.Drawing.Size(62, 20);
            this.txtTimeMin.TabIndex = 10;
            // 
            // txtTimeMax
            // 
            this.txtTimeMax.Location = new System.Drawing.Point(863, 331);
            this.txtTimeMax.MaxLength = 5;
            this.txtTimeMax.Name = "txtTimeMax";
            this.txtTimeMax.Size = new System.Drawing.Size(62, 20);
            this.txtTimeMax.TabIndex = 11;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(808, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(117, 20);
            this.txtSearch.TabIndex = 12;
            // 
            // butSearch
            // 
            this.butSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butSearch.Location = new System.Drawing.Point(808, 12);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(117, 26);
            this.butSearch.TabIndex = 14;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            this.butSearch.Click += new System.EventHandler(this.ButSearch_Click);
            // 
            // butTEST
            // 
            this.butTEST.Location = new System.Drawing.Point(12, 549);
            this.butTEST.Name = "butTEST";
            this.butTEST.Size = new System.Drawing.Size(100, 38);
            this.butTEST.TabIndex = 15;
            this.butTEST.Text = "TEST";
            this.butTEST.UseVisualStyleBackColor = true;
            this.butTEST.Click += new System.EventHandler(this.ButTEST_Click);
            // 
            // lblCalMin
            // 
            this.lblCalMin.AutoSize = true;
            this.lblCalMin.Location = new System.Drawing.Point(808, 84);
            this.lblCalMin.Name = "lblCalMin";
            this.lblCalMin.Size = new System.Drawing.Size(66, 13);
            this.lblCalMin.TabIndex = 16;
            this.lblCalMin.Text = "Calories min:";
            // 
            // lblCalMax
            // 
            this.lblCalMax.AutoSize = true;
            this.lblCalMax.Location = new System.Drawing.Point(808, 113);
            this.lblCalMax.Name = "lblCalMax";
            this.lblCalMax.Size = new System.Drawing.Size(69, 13);
            this.lblCalMax.TabIndex = 17;
            this.lblCalMax.Text = "Calories max:";
            // 
            // lblTimeMin
            // 
            this.lblTimeMin.AutoSize = true;
            this.lblTimeMin.Location = new System.Drawing.Point(808, 301);
            this.lblTimeMin.Name = "lblTimeMin";
            this.lblTimeMin.Size = new System.Drawing.Size(52, 13);
            this.lblTimeMin.TabIndex = 18;
            this.lblTimeMin.Text = "Time min:";
            // 
            // lblTimeMax
            // 
            this.lblTimeMax.AutoSize = true;
            this.lblTimeMax.Location = new System.Drawing.Point(808, 334);
            this.lblTimeMax.Name = "lblTimeMax";
            this.lblTimeMax.Size = new System.Drawing.Size(55, 13);
            this.lblTimeMax.TabIndex = 19;
            this.lblTimeMax.Text = "Time max:";
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
            this.listVIngr.Location = new System.Drawing.Point(765, 454);
            this.listVIngr.MultiSelect = false;
            this.listVIngr.Name = "listVIngr";
            this.listVIngr.Size = new System.Drawing.Size(160, 123);
            this.listVIngr.TabIndex = 21;
            this.listVIngr.UseCompatibleStateImageBehavior = false;
            this.listVIngr.View = System.Windows.Forms.View.Details;
            this.listVIngr.DoubleClick += new System.EventHandler(this.ListVIngr_DoubleClick);
            // 
            // ColumnIngr
            // 
            this.ColumnIngr.Text = "Ingredient";
            this.ColumnIngr.Width = 134;
            // 
            // butSearchIngr
            // 
            this.butSearchIngr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butSearchIngr.Location = new System.Drawing.Point(629, 454);
            this.butSearchIngr.Name = "butSearchIngr";
            this.butSearchIngr.Size = new System.Drawing.Size(117, 26);
            this.butSearchIngr.TabIndex = 22;
            this.butSearchIngr.Text = "Search";
            this.butSearchIngr.UseVisualStyleBackColor = true;
            this.butSearchIngr.Click += new System.EventHandler(this.ButSearchIngr_Click);
            // 
            // txtSearchIngr
            // 
            this.txtSearchIngr.Location = new System.Drawing.Point(629, 486);
            this.txtSearchIngr.Name = "txtSearchIngr";
            this.txtSearchIngr.Size = new System.Drawing.Size(117, 20);
            this.txtSearchIngr.TabIndex = 23;
            // 
            // LBLTEST
            // 
            this.LBLTEST.AutoSize = true;
            this.LBLTEST.BackColor = System.Drawing.Color.Orange;
            this.LBLTEST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLTEST.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBLTEST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBLTEST.Location = new System.Drawing.Point(12, 507);
            this.LBLTEST.Name = "LBLTEST";
            this.LBLTEST.Size = new System.Drawing.Size(86, 22);
            this.LBLTEST.TabIndex = 24;
            this.LBLTEST.Text = "Napis Test";
            this.LBLTEST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 600);
            this.Controls.Add(this.LBLTEST);
            this.Controls.Add(this.txtSearchIngr);
            this.Controls.Add(this.butSearchIngr);
            this.Controls.Add(this.listVIngr);
            this.Controls.Add(this.lblTimeMax);
            this.Controls.Add(this.lblTimeMin);
            this.Controls.Add(this.lblCalMax);
            this.Controls.Add(this.lblCalMin);
            this.Controls.Add(this.butTEST);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTimeMax);
            this.Controls.Add(this.txtTimeMin);
            this.Controls.Add(this.txtCalMax);
            this.Controls.Add(this.txtCalMin);
            this.Controls.Add(this.chLBDiet);
            this.Controls.Add(this.chLBStyle);
            this.Controls.Add(this.chLBFoodType);
            this.Controls.Add(this.listVSearcher);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView listVSearcher;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCalories;
        private System.Windows.Forms.ColumnHeader columnDishType;
        private System.Windows.Forms.ColumnHeader columnStyle;
        private System.Windows.Forms.ColumnHeader columnTime;
        private System.Windows.Forms.ColumnHeader columnFavourites;
        private System.Windows.Forms.ColumnHeader columnDiet;
        private System.Windows.Forms.CheckedListBox chLBFoodType;
        private System.Windows.Forms.CheckedListBox chLBStyle;
        private System.Windows.Forms.CheckedListBox chLBDiet;
        private System.Windows.Forms.TextBox txtCalMin;
        private System.Windows.Forms.TextBox txtCalMax;
        private System.Windows.Forms.TextBox txtTimeMin;
        private System.Windows.Forms.TextBox txtTimeMax;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butTEST;
        private System.Windows.Forms.Label lblCalMin;
        private System.Windows.Forms.Label lblCalMax;
        private System.Windows.Forms.Label lblTimeMin;
        private System.Windows.Forms.Label lblTimeMax;
        private System.Windows.Forms.ListView listVIngr;
        private System.Windows.Forms.ColumnHeader ColumnIngr;
        private System.Windows.Forms.Button butSearchIngr;
        private System.Windows.Forms.TextBox txtSearchIngr;
        private System.Windows.Forms.Label LBLTEST;
    }
}