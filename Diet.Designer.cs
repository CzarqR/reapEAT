namespace reapEAT
{
    partial class Diet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diet));
            this.listVDiets = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conMenDiets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butAddNewDiet = new System.Windows.Forms.Button();
            this.listVDiet = new System.Windows.Forms.ListView();
            this.columnNameD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.conMenDiet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.butAddMeal = new System.Windows.Forms.Button();
            this.chBOldMeals = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.butShopList = new System.Windows.Forms.Button();
            this.cheBDiets = new System.Windows.Forms.CheckedListBox();
            this.dateTPMax = new System.Windows.Forms.DateTimePicker();
            this.dateTPMin = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.butReturn = new System.Windows.Forms.Button();
            this.lblNameInfo = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.butConfirm = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.conMenDiets.SuspendLayout();
            this.conMenDiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // listVDiets
            // 
            this.listVDiets.BackColor = System.Drawing.Color.LemonChiffon;
            this.listVDiets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName});
            this.listVDiets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listVDiets.FullRowSelect = true;
            this.listVDiets.HideSelection = false;
            this.listVDiets.Location = new System.Drawing.Point(12, 32);
            this.listVDiets.Name = "listVDiets";
            this.listVDiets.Size = new System.Drawing.Size(121, 107);
            this.listVDiets.TabIndex = 0;
            this.listVDiets.UseCompatibleStateImageBehavior = false;
            this.listVDiets.View = System.Windows.Forms.View.Details;
            this.listVDiets.DoubleClick += new System.EventHandler(this.ListVDiets_DoubleClick);
            this.listVDiets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListVDiets_MouseClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 100;
            // 
            // conMenDiets
            // 
            this.conMenDiets.BackColor = System.Drawing.SystemColors.Info;
            this.conMenDiets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.conMenDiets.Name = "contextMenuStrip1";
            this.conMenDiets.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // butAddNewDiet
            // 
            this.butAddNewDiet.BackColor = System.Drawing.Color.SandyBrown;
            this.butAddNewDiet.Location = new System.Drawing.Point(139, 32);
            this.butAddNewDiet.Name = "butAddNewDiet";
            this.butAddNewDiet.Size = new System.Drawing.Size(113, 27);
            this.butAddNewDiet.TabIndex = 1;
            this.butAddNewDiet.Text = "Add new diet";
            this.butAddNewDiet.UseVisualStyleBackColor = false;
            this.butAddNewDiet.Click += new System.EventHandler(this.ButAddNewDiet_Click);
            // 
            // listVDiet
            // 
            this.listVDiet.BackColor = System.Drawing.Color.SandyBrown;
            this.listVDiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameD,
            this.columnDate});
            this.listVDiet.FullRowSelect = true;
            this.listVDiet.HideSelection = false;
            this.listVDiet.LargeImageList = this.imageList;
            this.listVDiet.Location = new System.Drawing.Point(12, 12);
            this.listVDiet.Name = "listVDiet";
            this.listVDiet.Size = new System.Drawing.Size(305, 392);
            this.listVDiet.SmallImageList = this.imageList;
            this.listVDiet.TabIndex = 3;
            this.listVDiet.UseCompatibleStateImageBehavior = false;
            this.listVDiet.View = System.Windows.Forms.View.Details;
            this.listVDiet.Visible = false;
            this.listVDiet.DoubleClick += new System.EventHandler(this.ListVDiet_DoubleClick);
            this.listVDiet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListVDiet_MouseClick);
            // 
            // columnNameD
            // 
            this.columnNameD.Text = "Name";
            this.columnNameD.Width = 184;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 89;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(80, 45);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // conMenDiet
            // 
            this.conMenDiet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.conMenDiet.Name = "conMenRec";
            this.conMenDiet.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click_1);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
            // 
            // butAddMeal
            // 
            this.butAddMeal.BackColor = System.Drawing.Color.SandyBrown;
            this.butAddMeal.Location = new System.Drawing.Point(322, 186);
            this.butAddMeal.Name = "butAddMeal";
            this.butAddMeal.Size = new System.Drawing.Size(90, 27);
            this.butAddMeal.TabIndex = 4;
            this.butAddMeal.Text = "Add meal";
            this.butAddMeal.UseVisualStyleBackColor = false;
            this.butAddMeal.Click += new System.EventHandler(this.ButAddMeal_Click);
            // 
            // chBOldMeals
            // 
            this.chBOldMeals.AutoSize = true;
            this.chBOldMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chBOldMeals.Location = new System.Drawing.Point(419, 192);
            this.chBOldMeals.Name = "chBOldMeals";
            this.chBOldMeals.Size = new System.Drawing.Size(114, 19);
            this.chBOldMeals.TabIndex = 5;
            this.chBOldMeals.Text = "Show old meals";
            this.chBOldMeals.UseVisualStyleBackColor = true;
            this.chBOldMeals.CheckedChanged += new System.EventHandler(this.ChBOldMeals_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtName.Location = new System.Drawing.Point(203, 64);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 20);
            this.txtName.TabIndex = 6;
            this.txtName.Visible = false;
            // 
            // butShopList
            // 
            this.butShopList.BackColor = System.Drawing.Color.SandyBrown;
            this.butShopList.Location = new System.Drawing.Point(322, 374);
            this.butShopList.Name = "butShopList";
            this.butShopList.Size = new System.Drawing.Size(147, 28);
            this.butShopList.TabIndex = 7;
            this.butShopList.Text = "Simple shopping List";
            this.butShopList.UseVisualStyleBackColor = false;
            this.butShopList.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cheBDiets
            // 
            this.cheBDiets.BackColor = System.Drawing.Color.LemonChiffon;
            this.cheBDiets.Location = new System.Drawing.Point(322, 274);
            this.cheBDiets.Name = "cheBDiets";
            this.cheBDiets.Size = new System.Drawing.Size(147, 94);
            this.cheBDiets.TabIndex = 8;
            // 
            // dateTPMax
            // 
            this.dateTPMax.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dateTPMax.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPMax.Location = new System.Drawing.Point(476, 348);
            this.dateTPMax.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTPMax.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTPMax.Name = "dateTPMax";
            this.dateTPMax.Size = new System.Drawing.Size(142, 20);
            this.dateTPMax.TabIndex = 9;
            // 
            // dateTPMin
            // 
            this.dateTPMin.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dateTPMin.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateTPMin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTPMin.Location = new System.Drawing.Point(476, 293);
            this.dateTPMin.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dateTPMin.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dateTPMin.Name = "dateTPMin";
            this.dateTPMin.Size = new System.Drawing.Size(142, 20);
            this.dateTPMin.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(139, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 17);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name - ";
            this.lblName.Visible = false;
            // 
            // butReturn
            // 
            this.butReturn.BackColor = System.Drawing.Color.SandyBrown;
            this.butReturn.Location = new System.Drawing.Point(258, 32);
            this.butReturn.Name = "butReturn";
            this.butReturn.Size = new System.Drawing.Size(59, 27);
            this.butReturn.TabIndex = 12;
            this.butReturn.Text = "Return";
            this.butReturn.UseVisualStyleBackColor = false;
            this.butReturn.Click += new System.EventHandler(this.ButReturn_Click);
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameInfo.ForeColor = System.Drawing.Color.Brown;
            this.lblNameInfo.Location = new System.Drawing.Point(12, 142);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(72, 14);
            this.lblNameInfo.TabIndex = 47;
            this.lblNameInfo.Text = "lblNameInfo";
            this.lblNameInfo.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblInfo.Location = new System.Drawing.Point(45, 12);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(225, 17);
            this.lblInfo.TabIndex = 48;
            this.lblInfo.Text = "Choose a diet or create a new one";
            // 
            // butConfirm
            // 
            this.butConfirm.BackColor = System.Drawing.Color.SandyBrown;
            this.butConfirm.Location = new System.Drawing.Point(139, 90);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(113, 27);
            this.butConfirm.TabIndex = 49;
            this.butConfirm.Text = "Confirm";
            this.butConfirm.UseVisualStyleBackColor = false;
            this.butConfirm.Visible = false;
            this.butConfirm.Click += new System.EventHandler(this.ButConfirm_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 50;
            this.label3.Text = "Beginning date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "End date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(327, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Select diets you want to include in shopping list\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Location = new System.Drawing.Point(471, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 28);
            this.button1.TabIndex = 55;
            this.button1.Text = "Detailed shopping List";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Diet
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(630, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listVDiet);
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblNameInfo);
            this.Controls.Add(this.butReturn);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dateTPMin);
            this.Controls.Add(this.dateTPMax);
            this.Controls.Add(this.cheBDiets);
            this.Controls.Add(this.butShopList);
            this.Controls.Add(this.chBOldMeals);
            this.Controls.Add(this.butAddMeal);
            this.Controls.Add(this.butAddNewDiet);
            this.Controls.Add(this.listVDiets);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Diet";
            this.Text = "Diet";
            this.conMenDiets.ResumeLayout(false);
            this.conMenDiet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listVDiets;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.Button butAddNewDiet;
        private System.Windows.Forms.ListView listVDiet;
        private System.Windows.Forms.ColumnHeader columnNameD;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.Button butAddMeal;
        private System.Windows.Forms.ContextMenuStrip conMenDiets;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip conMenDiet;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.CheckBox chBOldMeals;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button butShopList;
        private System.Windows.Forms.CheckedListBox cheBDiets;
        private System.Windows.Forms.DateTimePicker dateTPMax;
        private System.Windows.Forms.DateTimePicker dateTPMin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button butReturn;
        private System.Windows.Forms.Label lblNameInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button butConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}