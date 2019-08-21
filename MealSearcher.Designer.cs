namespace reapEAT
{
    partial class MealSearcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealSearcher));
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
            this.lblCalMin = new System.Windows.Forms.Label();
            this.lblCalMax = new System.Windows.Forms.Label();
            this.lblTimeMin = new System.Windows.Forms.Label();
            this.lblTimeMax = new System.Windows.Forms.Label();
            this.listVIngr = new System.Windows.Forms.ListView();
            this.ColumnIngr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butSearchIngr = new System.Windows.Forms.Button();
            this.txtSearchIngr = new System.Windows.Forms.TextBox();
            this.butAddNewRec = new System.Windows.Forms.Button();
            this.chBVerified = new System.Windows.Forms.CheckBox();
            this.numUDPage = new System.Windows.Forms.NumericUpDown();
            this.lblPrev = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.butShowFilters = new System.Windows.Forms.Button();
            this.butHideFilters = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.butAddMeal = new System.Windows.Forms.Button();
            this.datTimPickDate = new System.Windows.Forms.DateTimePicker();
            this.lblChoseDate = new System.Windows.Forms.Label();
            this.numUpPortion = new System.Windows.Forms.NumericUpDown();
            this.lblSelectPortion = new System.Windows.Forms.Label();
            this.lblAdded = new System.Windows.Forms.Label();
            this.butReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpPortion)).BeginInit();
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
            this.listVSearcher.BackColor = System.Drawing.Color.SandyBrown;
            this.listVSearcher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnCalories,
            this.columnDishType,
            this.columnStyle,
            this.columnTime,
            this.columnFavourites,
            this.columnDiet});
            this.listVSearcher.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listVSearcher.FullRowSelect = true;
            this.listVSearcher.HideSelection = false;
            this.listVSearcher.LargeImageList = this.imageList;
            this.listVSearcher.Location = new System.Drawing.Point(12, 44);
            this.listVSearcher.Name = "listVSearcher";
            this.listVSearcher.Size = new System.Drawing.Size(794, 513);
            this.listVSearcher.SmallImageList = this.imageList;
            this.listVSearcher.TabIndex = 22;
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
            this.columnDiet.Width = 129;
            // 
            // chLBFoodType
            // 
            this.chLBFoodType.BackColor = System.Drawing.Color.LemonChiffon;
            this.chLBFoodType.CheckOnClick = true;
            this.chLBFoodType.FormattingEnabled = true;
            this.chLBFoodType.Location = new System.Drawing.Point(938, 26);
            this.chLBFoodType.Name = "chLBFoodType";
            this.chLBFoodType.Size = new System.Drawing.Size(114, 124);
            this.chLBFoodType.TabIndex = 13;
            this.chLBFoodType.SelectedIndexChanged += new System.EventHandler(this.ChLBFoodType_SelectedIndexChanged);
            // 
            // chLBStyle
            // 
            this.chLBStyle.BackColor = System.Drawing.Color.LemonChiffon;
            this.chLBStyle.CheckOnClick = true;
            this.chLBStyle.FormattingEnabled = true;
            this.chLBStyle.Location = new System.Drawing.Point(938, 169);
            this.chLBStyle.Name = "chLBStyle";
            this.chLBStyle.Size = new System.Drawing.Size(114, 124);
            this.chLBStyle.TabIndex = 15;
            // 
            // chLBDiet
            // 
            this.chLBDiet.BackColor = System.Drawing.Color.LemonChiffon;
            this.chLBDiet.CheckOnClick = true;
            this.chLBDiet.FormattingEnabled = true;
            this.chLBDiet.Location = new System.Drawing.Point(818, 169);
            this.chLBDiet.Name = "chLBDiet";
            this.chLBDiet.Size = new System.Drawing.Size(114, 124);
            this.chLBDiet.TabIndex = 14;
            // 
            // txtCalMin
            // 
            this.txtCalMin.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCalMin.Location = new System.Drawing.Point(884, 49);
            this.txtCalMin.MaxLength = 5;
            this.txtCalMin.Name = "txtCalMin";
            this.txtCalMin.Size = new System.Drawing.Size(48, 20);
            this.txtCalMin.TabIndex = 9;
            // 
            // txtCalMax
            // 
            this.txtCalMax.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCalMax.Location = new System.Drawing.Point(884, 76);
            this.txtCalMax.MaxLength = 5;
            this.txtCalMax.Name = "txtCalMax";
            this.txtCalMax.Size = new System.Drawing.Size(48, 20);
            this.txtCalMax.TabIndex = 10;
            // 
            // txtTimeMin
            // 
            this.txtTimeMin.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtTimeMin.Location = new System.Drawing.Point(870, 103);
            this.txtTimeMin.MaxLength = 5;
            this.txtTimeMin.Name = "txtTimeMin";
            this.txtTimeMin.Size = new System.Drawing.Size(62, 20);
            this.txtTimeMin.TabIndex = 11;
            // 
            // txtTimeMax
            // 
            this.txtTimeMax.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtTimeMax.Location = new System.Drawing.Point(870, 130);
            this.txtTimeMax.MaxLength = 5;
            this.txtTimeMax.Name = "txtTimeMax";
            this.txtTimeMax.Size = new System.Drawing.Size(62, 20);
            this.txtTimeMax.TabIndex = 12;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearch.Location = new System.Drawing.Point(200, 12);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // butSearch
            // 
            this.butSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butSearch.BackColor = System.Drawing.Color.SandyBrown;
            this.butSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butSearch.Location = new System.Drawing.Point(77, 12);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(117, 26);
            this.butSearch.TabIndex = 1;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = false;
            this.butSearch.Click += new System.EventHandler(this.ButSearch_Click);
            // 
            // lblCalMin
            // 
            this.lblCalMin.AutoSize = true;
            this.lblCalMin.Location = new System.Drawing.Point(815, 52);
            this.lblCalMin.Name = "lblCalMin";
            this.lblCalMin.Size = new System.Drawing.Size(66, 13);
            this.lblCalMin.TabIndex = 16;
            this.lblCalMin.Text = "Calories min:";
            // 
            // lblCalMax
            // 
            this.lblCalMax.AutoSize = true;
            this.lblCalMax.Location = new System.Drawing.Point(815, 79);
            this.lblCalMax.Name = "lblCalMax";
            this.lblCalMax.Size = new System.Drawing.Size(69, 13);
            this.lblCalMax.TabIndex = 17;
            this.lblCalMax.Text = "Calories max:";
            // 
            // lblTimeMin
            // 
            this.lblTimeMin.AutoSize = true;
            this.lblTimeMin.Location = new System.Drawing.Point(815, 106);
            this.lblTimeMin.Name = "lblTimeMin";
            this.lblTimeMin.Size = new System.Drawing.Size(52, 13);
            this.lblTimeMin.TabIndex = 18;
            this.lblTimeMin.Text = "Time min:";
            // 
            // lblTimeMax
            // 
            this.lblTimeMax.AutoSize = true;
            this.lblTimeMax.Location = new System.Drawing.Point(815, 133);
            this.lblTimeMax.Name = "lblTimeMax";
            this.lblTimeMax.Size = new System.Drawing.Size(55, 13);
            this.lblTimeMax.TabIndex = 19;
            this.lblTimeMax.Text = "Time max:";
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
            this.listVIngr.Location = new System.Drawing.Point(818, 354);
            this.listVIngr.MultiSelect = false;
            this.listVIngr.Name = "listVIngr";
            this.listVIngr.Size = new System.Drawing.Size(159, 203);
            this.listVIngr.TabIndex = 18;
            this.listVIngr.UseCompatibleStateImageBehavior = false;
            this.listVIngr.View = System.Windows.Forms.View.Details;
            this.listVIngr.DoubleClick += new System.EventHandler(this.ListVIngr_DoubleClick);
            // 
            // ColumnIngr
            // 
            this.ColumnIngr.Text = "Ingredient";
            this.ColumnIngr.Width = 131;
            // 
            // butSearchIngr
            // 
            this.butSearchIngr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butSearchIngr.BackColor = System.Drawing.Color.SandyBrown;
            this.butSearchIngr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butSearchIngr.Location = new System.Drawing.Point(818, 322);
            this.butSearchIngr.Name = "butSearchIngr";
            this.butSearchIngr.Size = new System.Drawing.Size(80, 26);
            this.butSearchIngr.TabIndex = 16;
            this.butSearchIngr.Text = "Search";
            this.butSearchIngr.UseVisualStyleBackColor = false;
            this.butSearchIngr.Click += new System.EventHandler(this.ButSearchIngr_Click);
            // 
            // txtSearchIngr
            // 
            this.txtSearchIngr.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtSearchIngr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSearchIngr.Location = new System.Drawing.Point(901, 323);
            this.txtSearchIngr.Name = "txtSearchIngr";
            this.txtSearchIngr.Size = new System.Drawing.Size(147, 24);
            this.txtSearchIngr.TabIndex = 17;
            // 
            // butAddNewRec
            // 
            this.butAddNewRec.BackColor = System.Drawing.Color.SandyBrown;
            this.butAddNewRec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butAddNewRec.Location = new System.Drawing.Point(441, 12);
            this.butAddNewRec.Name = "butAddNewRec";
            this.butAddNewRec.Size = new System.Drawing.Size(116, 26);
            this.butAddNewRec.TabIndex = 3;
            this.butAddNewRec.Text = "Add new recipe";
            this.butAddNewRec.UseVisualStyleBackColor = false;
            this.butAddNewRec.Click += new System.EventHandler(this.ButAddNewRec_Click);
            // 
            // chBVerified
            // 
            this.chBVerified.AutoSize = true;
            this.chBVerified.BackColor = System.Drawing.Color.LightSeaGreen;
            this.chBVerified.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chBVerified.Location = new System.Drawing.Point(815, 21);
            this.chBVerified.Name = "chBVerified";
            this.chBVerified.Size = new System.Drawing.Size(61, 17);
            this.chBVerified.TabIndex = 8;
            this.chBVerified.Text = "Verified";
            this.chBVerified.UseVisualStyleBackColor = false;
            // 
            // numUDPage
            // 
            this.numUDPage.Location = new System.Drawing.Point(636, 12);
            this.numUDPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDPage.Name = "numUDPage";
            this.numUDPage.Size = new System.Drawing.Size(39, 20);
            this.numUDPage.TabIndex = 5;
            this.numUDPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDPage.ValueChanged += new System.EventHandler(this.NumUDPage_ValueChanged);
            // 
            // lblPrev
            // 
            this.lblPrev.AutoSize = true;
            this.lblPrev.BackColor = System.Drawing.Color.SandyBrown;
            this.lblPrev.Location = new System.Drawing.Point(570, 16);
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.Size = new System.Drawing.Size(60, 13);
            this.lblPrev.TabIndex = 4;
            this.lblPrev.Text = "<<Previous";
            this.lblPrev.Click += new System.EventHandler(this.LblPrev_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.BackColor = System.Drawing.Color.SandyBrown;
            this.lblNext.Location = new System.Drawing.Point(681, 16);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(41, 13);
            this.lblNext.TabIndex = 6;
            this.lblNext.Text = "Next>>";
            this.lblNext.Click += new System.EventHandler(this.LblNext_Click);
            // 
            // butShowFilters
            // 
            this.butShowFilters.BackColor = System.Drawing.Color.SandyBrown;
            this.butShowFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butShowFilters.Location = new System.Drawing.Point(728, 14);
            this.butShowFilters.Name = "butShowFilters";
            this.butShowFilters.Size = new System.Drawing.Size(78, 22);
            this.butShowFilters.TabIndex = 7;
            this.butShowFilters.Text = "Show filters";
            this.butShowFilters.UseVisualStyleBackColor = false;
            this.butShowFilters.Click += new System.EventHandler(this.Button1_Click);
            // 
            // butHideFilters
            // 
            this.butHideFilters.BackColor = System.Drawing.Color.SandyBrown;
            this.butHideFilters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butHideFilters.Location = new System.Drawing.Point(980, 517);
            this.butHideFilters.Name = "butHideFilters";
            this.butHideFilters.Size = new System.Drawing.Size(78, 40);
            this.butHideFilters.TabIndex = 19;
            this.butHideFilters.Text = "Clear all filters";
            this.butHideFilters.UseVisualStyleBackColor = false;
            this.butHideFilters.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 587);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 72);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.LemonChiffon;
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(12, 563);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 16);
            this.lblName.TabIndex = 38;
            this.lblName.Text = "lblName";
            this.lblName.Visible = false;
            // 
            // butAddMeal
            // 
            this.butAddMeal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butAddMeal.BackColor = System.Drawing.Color.SandyBrown;
            this.butAddMeal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butAddMeal.Location = new System.Drawing.Point(266, 563);
            this.butAddMeal.Name = "butAddMeal";
            this.butAddMeal.Size = new System.Drawing.Size(80, 26);
            this.butAddMeal.TabIndex = 22;
            this.butAddMeal.Text = "Add Meal";
            this.butAddMeal.UseVisualStyleBackColor = false;
            this.butAddMeal.Visible = false;
            this.butAddMeal.Click += new System.EventHandler(this.ButAddMeal_Click);
            // 
            // datTimPickDate
            // 
            this.datTimPickDate.Location = new System.Drawing.Point(146, 639);
            this.datTimPickDate.Name = "datTimPickDate";
            this.datTimPickDate.Size = new System.Drawing.Size(200, 20);
            this.datTimPickDate.TabIndex = 21;
            this.datTimPickDate.Visible = false;
            // 
            // lblChoseDate
            // 
            this.lblChoseDate.AutoSize = true;
            this.lblChoseDate.Location = new System.Drawing.Point(146, 623);
            this.lblChoseDate.Name = "lblChoseDate";
            this.lblChoseDate.Size = new System.Drawing.Size(61, 13);
            this.lblChoseDate.TabIndex = 41;
            this.lblChoseDate.Text = "Select date";
            this.lblChoseDate.Visible = false;
            // 
            // numUpPortion
            // 
            this.numUpPortion.BackColor = System.Drawing.Color.LemonChiffon;
            this.numUpPortion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numUpPortion.DecimalPlaces = 2;
            this.numUpPortion.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numUpPortion.Location = new System.Drawing.Point(224, 595);
            this.numUpPortion.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUpPortion.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numUpPortion.Name = "numUpPortion";
            this.numUpPortion.Size = new System.Drawing.Size(58, 20);
            this.numUpPortion.TabIndex = 20;
            this.numUpPortion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpPortion.Visible = false;
            // 
            // lblSelectPortion
            // 
            this.lblSelectPortion.AutoSize = true;
            this.lblSelectPortion.Location = new System.Drawing.Point(146, 597);
            this.lblSelectPortion.Name = "lblSelectPortion";
            this.lblSelectPortion.Size = new System.Drawing.Size(72, 13);
            this.lblSelectPortion.TabIndex = 43;
            this.lblSelectPortion.Text = "Select portion";
            this.lblSelectPortion.Visible = false;
            // 
            // lblAdded
            // 
            this.lblAdded.AutoSize = true;
            this.lblAdded.BackColor = System.Drawing.Color.Gold;
            this.lblAdded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAdded.Location = new System.Drawing.Point(302, 602);
            this.lblAdded.Name = "lblAdded";
            this.lblAdded.Size = new System.Drawing.Size(41, 13);
            this.lblAdded.TabIndex = 44;
            this.lblAdded.Text = "Added!";
            // 
            // butReturn
            // 
            this.butReturn.BackColor = System.Drawing.Color.SandyBrown;
            this.butReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butReturn.Location = new System.Drawing.Point(12, 12);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(59, 26);
            this.butReturn.TabIndex = 0;
            this.butReturn.Text = "Return";
            this.butReturn.UseVisualStyleBackColor = false;
            this.butReturn.Click += new System.EventHandler(this.ButReturn_Click);
            // 
            // MealSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1060, 671);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.lblAdded);
            this.Controls.Add(this.lblSelectPortion);
            this.Controls.Add(this.numUpPortion);
            this.Controls.Add(this.lblChoseDate);
            this.Controls.Add(this.datTimPickDate);
            this.Controls.Add(this.butAddMeal);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butHideFilters);
            this.Controls.Add(this.butShowFilters);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblPrev);
            this.Controls.Add(this.numUDPage);
            this.Controls.Add(this.chBVerified);
            this.Controls.Add(this.butAddNewRec);
            this.Controls.Add(this.txtSearchIngr);
            this.Controls.Add(this.butSearchIngr);
            this.Controls.Add(this.listVIngr);
            this.Controls.Add(this.lblTimeMax);
            this.Controls.Add(this.lblTimeMin);
            this.Controls.Add(this.lblCalMax);
            this.Controls.Add(this.lblCalMin);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MealSearcher";
            this.Text = "Find meal to Your diet";
            ((System.ComponentModel.ISupportInitialize)(this.numUDPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpPortion)).EndInit();
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
        private System.Windows.Forms.Label lblCalMin;
        private System.Windows.Forms.Label lblCalMax;
        private System.Windows.Forms.Label lblTimeMin;
        private System.Windows.Forms.Label lblTimeMax;
        private System.Windows.Forms.ListView listVIngr;
        private System.Windows.Forms.ColumnHeader ColumnIngr;
        private System.Windows.Forms.Button butSearchIngr;
        private System.Windows.Forms.TextBox txtSearchIngr;
        private System.Windows.Forms.Button butAddNewRec;
        private System.Windows.Forms.CheckBox chBVerified;
        private System.Windows.Forms.NumericUpDown numUDPage;
        private System.Windows.Forms.Label lblPrev;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button butShowFilters;
        private System.Windows.Forms.Button butHideFilters;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button butAddMeal;
        private System.Windows.Forms.DateTimePicker datTimPickDate;
        private System.Windows.Forms.Label lblChoseDate;
        private System.Windows.Forms.NumericUpDown numUpPortion;
        private System.Windows.Forms.Label lblSelectPortion;
        private System.Windows.Forms.Label lblAdded;
        private System.Windows.Forms.Button butReturn;
    }
}

//namespace reapEAT
//{
//    partial class MealSearcher
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.imageList = new System.Windows.Forms.ImageList(this.components);
//            this.listVSearcher = new System.Windows.Forms.ListView();
//            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.columnCalories = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.columnDishType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.columnStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.columnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.columnFavourites = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.columnDiet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.chLBFoodType = new System.Windows.Forms.CheckedListBox();
//            this.chLBStyle = new System.Windows.Forms.CheckedListBox();
//            this.chLBDiet = new System.Windows.Forms.CheckedListBox();
//            this.txtCalMin = new System.Windows.Forms.TextBox();
//            this.txtCalMax = new System.Windows.Forms.TextBox();
//            this.txtTimeMin = new System.Windows.Forms.TextBox();
//            this.txtTimeMax = new System.Windows.Forms.TextBox();
//            this.txtSearch = new System.Windows.Forms.TextBox();
//            this.butSearch = new System.Windows.Forms.Button();
//            this.lblCalMin = new System.Windows.Forms.Label();
//            this.lblCalMax = new System.Windows.Forms.Label();
//            this.lblTimeMin = new System.Windows.Forms.Label();
//            this.lblTimeMax = new System.Windows.Forms.Label();
//            this.listVIngr = new System.Windows.Forms.ListView();
//            this.ColumnIngr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
//            this.butSearchIngr = new System.Windows.Forms.Button();
//            this.txtSearchIngr = new System.Windows.Forms.TextBox();
//            this.datTimPickDate = new System.Windows.Forms.DateTimePicker();
//            this.butAdd = new System.Windows.Forms.Button();
//            this.lblName = new System.Windows.Forms.Label();
//            this.numUpPortion = new System.Windows.Forms.NumericUpDown();
//            this.picBMeal = new System.Windows.Forms.PictureBox();
//            this.chBVerified = new System.Windows.Forms.CheckBox();
//            this.numUDPage = new System.Windows.Forms.NumericUpDown();
//            ((System.ComponentModel.ISupportInitialize)(this.numUpPortion)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.picBMeal)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.numUDPage)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // imageList
//            // 
//            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
//            this.imageList.ImageSize = new System.Drawing.Size(128, 72);
//            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
//            // 
//            // listVSearcher
//            // 
//            this.listVSearcher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
//            this.columnName,
//            this.columnCalories,
//            this.columnDishType,
//            this.columnStyle,
//            this.columnTime,
//            this.columnFavourites,
//            this.columnDiet});
//            this.listVSearcher.FullRowSelect = true;
//            this.listVSearcher.HideSelection = false;
//            this.listVSearcher.LargeImageList = this.imageList;
//            this.listVSearcher.Location = new System.Drawing.Point(15, 12);
//            this.listVSearcher.Name = "listVSearcher";
//            this.listVSearcher.Size = new System.Drawing.Size(790, 413);
//            this.listVSearcher.SmallImageList = this.imageList;
//            this.listVSearcher.TabIndex = 4;
//            this.listVSearcher.UseCompatibleStateImageBehavior = false;
//            this.listVSearcher.View = System.Windows.Forms.View.Details;
//            this.listVSearcher.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnSort);
//            this.listVSearcher.DoubleClick += new System.EventHandler(this.ListVSearcher_DoubleClick);
//            // 
//            // columnName
//            // 
//            this.columnName.Text = "Name";
//            this.columnName.Width = 190;
//            // 
//            // columnCalories
//            // 
//            this.columnCalories.Text = "Calories";
//            this.columnCalories.Width = 75;
//            // 
//            // columnDishType
//            // 
//            this.columnDishType.Text = "Dish Type";
//            this.columnDishType.Width = 100;
//            // 
//            // columnStyle
//            // 
//            this.columnStyle.Text = "Style";
//            this.columnStyle.Width = 125;
//            // 
//            // columnTime
//            // 
//            this.columnTime.Text = "Time";
//            this.columnTime.Width = 75;
//            // 
//            // columnFavourites
//            // 
//            this.columnFavourites.Text = "Favourites";
//            this.columnFavourites.Width = 75;
//            // 
//            // columnDiet
//            // 
//            this.columnDiet.Text = "Diet";
//            this.columnDiet.Width = 129;
//            // 
//            // chLBFoodType
//            // 
//            this.chLBFoodType.CheckOnClick = true;
//            this.chLBFoodType.FormattingEnabled = true;
//            this.chLBFoodType.Location = new System.Drawing.Point(808, 146);
//            this.chLBFoodType.Name = "chLBFoodType";
//            this.chLBFoodType.Size = new System.Drawing.Size(117, 64);
//            this.chLBFoodType.TabIndex = 5;
//            // 
//            // chLBStyle
//            // 
//            this.chLBStyle.CheckOnClick = true;
//            this.chLBStyle.FormattingEnabled = true;
//            this.chLBStyle.Location = new System.Drawing.Point(808, 223);
//            this.chLBStyle.Name = "chLBStyle";
//            this.chLBStyle.Size = new System.Drawing.Size(117, 64);
//            this.chLBStyle.TabIndex = 6;
//            // 
//            // chLBDiet
//            // 
//            this.chLBDiet.CheckOnClick = true;
//            this.chLBDiet.FormattingEnabled = true;
//            this.chLBDiet.Location = new System.Drawing.Point(811, 361);
//            this.chLBDiet.Name = "chLBDiet";
//            this.chLBDiet.Size = new System.Drawing.Size(114, 64);
//            this.chLBDiet.TabIndex = 7;
//            // 
//            // txtCalMin
//            // 
//            this.txtCalMin.Location = new System.Drawing.Point(877, 81);
//            this.txtCalMin.MaxLength = 5;
//            this.txtCalMin.Name = "txtCalMin";
//            this.txtCalMin.Size = new System.Drawing.Size(48, 20);
//            this.txtCalMin.TabIndex = 8;
//            // 
//            // txtCalMax
//            // 
//            this.txtCalMax.Location = new System.Drawing.Point(877, 110);
//            this.txtCalMax.MaxLength = 5;
//            this.txtCalMax.Name = "txtCalMax";
//            this.txtCalMax.Size = new System.Drawing.Size(48, 20);
//            this.txtCalMax.TabIndex = 9;
//            // 
//            // txtTimeMin
//            // 
//            this.txtTimeMin.Location = new System.Drawing.Point(863, 298);
//            this.txtTimeMin.MaxLength = 5;
//            this.txtTimeMin.Name = "txtTimeMin";
//            this.txtTimeMin.Size = new System.Drawing.Size(62, 20);
//            this.txtTimeMin.TabIndex = 10;
//            // 
//            // txtTimeMax
//            // 
//            this.txtTimeMax.Location = new System.Drawing.Point(863, 331);
//            this.txtTimeMax.MaxLength = 5;
//            this.txtTimeMax.Name = "txtTimeMax";
//            this.txtTimeMax.Size = new System.Drawing.Size(62, 20);
//            this.txtTimeMax.TabIndex = 11;
//            // 
//            // txtSearch
//            // 
//            this.txtSearch.Location = new System.Drawing.Point(808, 44);
//            this.txtSearch.Name = "txtSearch";
//            this.txtSearch.Size = new System.Drawing.Size(117, 20);
//            this.txtSearch.TabIndex = 12;
//            // 
//            // butSearch
//            // 
//            this.butSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
//            this.butSearch.Location = new System.Drawing.Point(808, 12);
//            this.butSearch.Name = "butSearch";
//            this.butSearch.Size = new System.Drawing.Size(117, 26);
//            this.butSearch.TabIndex = 14;
//            this.butSearch.Text = "Search";
//            this.butSearch.UseVisualStyleBackColor = true;
//            this.butSearch.Click += new System.EventHandler(this.ButSearch_Click);
//            // 
//            // lblCalMin
//            // 
//            this.lblCalMin.AutoSize = true;
//            this.lblCalMin.Location = new System.Drawing.Point(808, 84);
//            this.lblCalMin.Name = "lblCalMin";
//            this.lblCalMin.Size = new System.Drawing.Size(66, 13);
//            this.lblCalMin.TabIndex = 16;
//            this.lblCalMin.Text = "Calories min:";
//            // 
//            // lblCalMax
//            // 
//            this.lblCalMax.AutoSize = true;
//            this.lblCalMax.Location = new System.Drawing.Point(808, 113);
//            this.lblCalMax.Name = "lblCalMax";
//            this.lblCalMax.Size = new System.Drawing.Size(69, 13);
//            this.lblCalMax.TabIndex = 17;
//            this.lblCalMax.Text = "Calories max:";
//            // 
//            // lblTimeMin
//            // 
//            this.lblTimeMin.AutoSize = true;
//            this.lblTimeMin.Location = new System.Drawing.Point(808, 301);
//            this.lblTimeMin.Name = "lblTimeMin";
//            this.lblTimeMin.Size = new System.Drawing.Size(52, 13);
//            this.lblTimeMin.TabIndex = 18;
//            this.lblTimeMin.Text = "Time min:";
//            // 
//            // lblTimeMax
//            // 
//            this.lblTimeMax.AutoSize = true;
//            this.lblTimeMax.Location = new System.Drawing.Point(808, 334);
//            this.lblTimeMax.Name = "lblTimeMax";
//            this.lblTimeMax.Size = new System.Drawing.Size(55, 13);
//            this.lblTimeMax.TabIndex = 19;
//            this.lblTimeMax.Text = "Time max:";
//            // 
//            // listVIngr
//            // 
//            this.listVIngr.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
//            this.ColumnIngr});
//            this.listVIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
//            this.listVIngr.FullRowSelect = true;
//            this.listVIngr.GridLines = true;
//            this.listVIngr.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
//            this.listVIngr.HideSelection = false;
//            this.listVIngr.Location = new System.Drawing.Point(765, 454);
//            this.listVIngr.MultiSelect = false;
//            this.listVIngr.Name = "listVIngr";
//            this.listVIngr.Size = new System.Drawing.Size(160, 123);
//            this.listVIngr.TabIndex = 21;
//            this.listVIngr.UseCompatibleStateImageBehavior = false;
//            this.listVIngr.View = System.Windows.Forms.View.Details;
//            this.listVIngr.DoubleClick += new System.EventHandler(this.ListVIngr_DoubleClick);
//            // 
//            // ColumnIngr
//            // 
//            this.ColumnIngr.Text = "Ingredient";
//            this.ColumnIngr.Width = 134;
//            // 
//            // butSearchIngr
//            // 
//            this.butSearchIngr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
//            this.butSearchIngr.Location = new System.Drawing.Point(629, 454);
//            this.butSearchIngr.Name = "butSearchIngr";
//            this.butSearchIngr.Size = new System.Drawing.Size(117, 26);
//            this.butSearchIngr.TabIndex = 22;
//            this.butSearchIngr.Text = "Search";
//            this.butSearchIngr.UseVisualStyleBackColor = true;
//            this.butSearchIngr.Click += new System.EventHandler(this.ButSearchIngr_Click);
//            // 
//            // txtSearchIngr
//            // 
//            this.txtSearchIngr.Location = new System.Drawing.Point(629, 486);
//            this.txtSearchIngr.Name = "txtSearchIngr";
//            this.txtSearchIngr.Size = new System.Drawing.Size(117, 20);
//            this.txtSearchIngr.TabIndex = 23;
//            // 
//            // datTimPickDate
//            // 
//            this.datTimPickDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
//            this.datTimPickDate.Location = new System.Drawing.Point(242, 561);
//            this.datTimPickDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
//            this.datTimPickDate.Name = "datTimPickDate";
//            this.datTimPickDate.Size = new System.Drawing.Size(236, 20);
//            this.datTimPickDate.TabIndex = 25;
//            // 
//            // butAdd
//            // 
//            this.butAdd.Location = new System.Drawing.Point(561, 563);
//            this.butAdd.Name = "butAdd";
//            this.butAdd.Size = new System.Drawing.Size(87, 20);
//            this.butAdd.TabIndex = 26;
//            this.butAdd.Text = "Add";
//            this.butAdd.UseVisualStyleBackColor = true;
//            this.butAdd.Click += new System.EventHandler(this.ButAdd_Click);
//            // 
//            // lblName
//            // 
//            this.lblName.AutoSize = true;
//            this.lblName.Location = new System.Drawing.Point(12, 439);
//            this.lblName.Name = "lblName";
//            this.lblName.Size = new System.Drawing.Size(35, 13);
//            this.lblName.TabIndex = 27;
//            this.lblName.Text = "Name";
//            // 
//            // numUpPortion
//            // 
//            this.numUpPortion.DecimalPlaces = 2;
//            this.numUpPortion.Increment = new decimal(new int[] {
//            25,
//            0,
//            0,
//            131072});
//            this.numUpPortion.Location = new System.Drawing.Point(242, 535);
//            this.numUpPortion.Maximum = new decimal(new int[] {
//            255,
//            0,
//            0,
//            0});
//            this.numUpPortion.Minimum = new decimal(new int[] {
//            25,
//            0,
//            0,
//            131072});
//            this.numUpPortion.Name = "numUpPortion";
//            this.numUpPortion.Size = new System.Drawing.Size(69, 20);
//            this.numUpPortion.TabIndex = 28;
//            this.numUpPortion.Value = new decimal(new int[] {
//            1,
//            0,
//            0,
//            0});
//            // 
//            // picBMeal
//            // 
//            this.picBMeal.Location = new System.Drawing.Point(12, 455);
//            this.picBMeal.Name = "picBMeal";
//            this.picBMeal.Size = new System.Drawing.Size(224, 126);
//            this.picBMeal.TabIndex = 29;
//            this.picBMeal.TabStop = false;
//            // 
//            // chBVerified
//            // 
//            this.chBVerified.AutoSize = true;
//            this.chBVerified.Location = new System.Drawing.Point(811, 431);
//            this.chBVerified.Name = "chBVerified";
//            this.chBVerified.Size = new System.Drawing.Size(61, 17);
//            this.chBVerified.TabIndex = 30;
//            this.chBVerified.Text = "Verified";
//            this.chBVerified.UseVisualStyleBackColor = true;
//            // 
//            // numUDPage
//            // 
//            this.numUDPage.Location = new System.Drawing.Point(382, 432);
//            this.numUDPage.Minimum = new decimal(new int[] {
//            1,
//            0,
//            0,
//            0});
//            this.numUDPage.Name = "numUDPage";
//            this.numUDPage.Size = new System.Drawing.Size(39, 20);
//            this.numUDPage.TabIndex = 31;
//            this.numUDPage.Value = new decimal(new int[] {
//            1,
//            0,
//            0,
//            0});
//            // 
//            // MealSearcher
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(979, 600);
//            this.Controls.Add(this.numUDPage);
//            this.Controls.Add(this.chBVerified);
//            this.Controls.Add(this.picBMeal);
//            this.Controls.Add(this.numUpPortion);
//            this.Controls.Add(this.lblName);
//            this.Controls.Add(this.butAdd);
//            this.Controls.Add(this.datTimPickDate);
//            this.Controls.Add(this.txtSearchIngr);
//            this.Controls.Add(this.butSearchIngr);
//            this.Controls.Add(this.listVIngr);
//            this.Controls.Add(this.lblTimeMax);
//            this.Controls.Add(this.lblTimeMin);
//            this.Controls.Add(this.lblCalMax);
//            this.Controls.Add(this.lblCalMin);
//            this.Controls.Add(this.butSearch);
//            this.Controls.Add(this.txtSearch);
//            this.Controls.Add(this.txtTimeMax);
//            this.Controls.Add(this.txtTimeMin);
//            this.Controls.Add(this.txtCalMax);
//            this.Controls.Add(this.txtCalMin);
//            this.Controls.Add(this.chLBDiet);
//            this.Controls.Add(this.chLBStyle);
//            this.Controls.Add(this.chLBFoodType);
//            this.Controls.Add(this.listVSearcher);
//            this.Name = "MealSearcher";
//            this.Text = "Main";
//            ((System.ComponentModel.ISupportInitialize)(this.numUpPortion)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.picBMeal)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.numUDPage)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion
//        private System.Windows.Forms.ImageList imageList;
//        private System.Windows.Forms.ListView listVSearcher;
//        private System.Windows.Forms.ColumnHeader columnName;
//        private System.Windows.Forms.ColumnHeader columnCalories;
//        private System.Windows.Forms.ColumnHeader columnDishType;
//        private System.Windows.Forms.ColumnHeader columnStyle;
//        private System.Windows.Forms.ColumnHeader columnTime;
//        private System.Windows.Forms.ColumnHeader columnFavourites;
//        private System.Windows.Forms.ColumnHeader columnDiet;
//        private System.Windows.Forms.CheckedListBox chLBFoodType;
//        private System.Windows.Forms.CheckedListBox chLBStyle;
//        private System.Windows.Forms.CheckedListBox chLBDiet;
//        private System.Windows.Forms.TextBox txtCalMin;
//        private System.Windows.Forms.TextBox txtCalMax;
//        private System.Windows.Forms.TextBox txtTimeMin;
//        private System.Windows.Forms.TextBox txtTimeMax;
//        private System.Windows.Forms.TextBox txtSearch;
//        private System.Windows.Forms.Button butSearch;
//        private System.Windows.Forms.Label lblCalMin;
//        private System.Windows.Forms.Label lblCalMax;
//        private System.Windows.Forms.Label lblTimeMin;
//        private System.Windows.Forms.Label lblTimeMax;
//        private System.Windows.Forms.ListView listVIngr;
//        private System.Windows.Forms.ColumnHeader ColumnIngr;
//        private System.Windows.Forms.Button butSearchIngr;
//        private System.Windows.Forms.TextBox txtSearchIngr;
//        private System.Windows.Forms.DateTimePicker datTimPickDate;
//        private System.Windows.Forms.Button butAdd;
//        private System.Windows.Forms.Label lblName;
//        private System.Windows.Forms.NumericUpDown numUpPortion;
//        private System.Windows.Forms.PictureBox picBMeal;
//        private System.Windows.Forms.CheckBox chBVerified;
//        private System.Windows.Forms.NumericUpDown numUDPage;
//    }
//}