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
            this.listVDiets = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.conMenDiets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.butAddNewDiet = new System.Windows.Forms.Button();
            this.butManage = new System.Windows.Forms.Button();
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
            this.conMenDiets.SuspendLayout();
            this.conMenDiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // listVDiets
            // 
            this.listVDiets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName});
            this.listVDiets.FullRowSelect = true;
            this.listVDiets.HideSelection = false;
            this.listVDiets.Location = new System.Drawing.Point(12, 12);
            this.listVDiets.Name = "listVDiets";
            this.listVDiets.Size = new System.Drawing.Size(121, 80);
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
            this.butAddNewDiet.Location = new System.Drawing.Point(306, 12);
            this.butAddNewDiet.Name = "butAddNewDiet";
            this.butAddNewDiet.Size = new System.Drawing.Size(90, 27);
            this.butAddNewDiet.TabIndex = 1;
            this.butAddNewDiet.Text = "Add new diet";
            this.butAddNewDiet.UseVisualStyleBackColor = true;
            this.butAddNewDiet.Click += new System.EventHandler(this.ButAddNewDiet_Click);
            // 
            // butManage
            // 
            this.butManage.Location = new System.Drawing.Point(517, 131);
            this.butManage.Name = "butManage";
            this.butManage.Size = new System.Drawing.Size(90, 27);
            this.butManage.TabIndex = 2;
            this.butManage.Text = "Manage";
            this.butManage.UseVisualStyleBackColor = true;
            // 
            // listVDiet
            // 
            this.listVDiet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNameD,
            this.columnDate});
            this.listVDiet.FullRowSelect = true;
            this.listVDiet.HideSelection = false;
            this.listVDiet.LargeImageList = this.imageList;
            this.listVDiet.Location = new System.Drawing.Point(12, 111);
            this.listVDiet.Name = "listVDiet";
            this.listVDiet.Size = new System.Drawing.Size(298, 318);
            this.listVDiet.SmallImageList = this.imageList;
            this.listVDiet.TabIndex = 3;
            this.listVDiet.UseCompatibleStateImageBehavior = false;
            this.listVDiet.View = System.Windows.Forms.View.Details;
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
            this.imageList.ImageSize = new System.Drawing.Size(64, 36);
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
            this.butAddMeal.Location = new System.Drawing.Point(316, 402);
            this.butAddMeal.Name = "butAddMeal";
            this.butAddMeal.Size = new System.Drawing.Size(90, 27);
            this.butAddMeal.TabIndex = 4;
            this.butAddMeal.Text = "Add meal";
            this.butAddMeal.UseVisualStyleBackColor = true;
            this.butAddMeal.Click += new System.EventHandler(this.ButAddMeal_Click);
            // 
            // chBOldMeals
            // 
            this.chBOldMeals.AutoSize = true;
            this.chBOldMeals.Location = new System.Drawing.Point(139, 75);
            this.chBOldMeals.Name = "chBOldMeals";
            this.chBOldMeals.Size = new System.Drawing.Size(100, 17);
            this.chBOldMeals.TabIndex = 5;
            this.chBOldMeals.Text = "Show old meals";
            this.chBOldMeals.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(412, 16);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(101, 20);
            this.txtName.TabIndex = 6;
            // 
            // Diet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 441);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.chBOldMeals);
            this.Controls.Add(this.butAddMeal);
            this.Controls.Add(this.listVDiet);
            this.Controls.Add(this.butManage);
            this.Controls.Add(this.butAddNewDiet);
            this.Controls.Add(this.listVDiets);
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
        private System.Windows.Forms.Button butManage;
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
    }
}