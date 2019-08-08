namespace reapEAT
{
    partial class Fridge
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
            this.listVFridge = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnExpirationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butAdd = new System.Windows.Forms.Button();
            this.butDeleteFood = new System.Windows.Forms.Button();
            this.butBarcode = new System.Windows.Forms.Button();
            this.butFind = new System.Windows.Forms.Button();
            this.txtFoodToFind = new System.Windows.Forms.TextBox();
            this.datePickerExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.lblMeasure = new System.Windows.Forms.Label();
            this.lblFoundFood = new System.Windows.Forms.Label();
            this.butChechAdd = new System.Windows.Forms.Button();
            this.comBFoundFood = new System.Windows.Forms.ComboBox();
            this.listVSameFood = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butEditFood = new System.Windows.Forms.Button();
            this.butJustAdd = new System.Windows.Forms.Button();
            this.butUpdate = new System.Windows.Forms.Button();
            this.lblNoFoodInDB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listVFridge
            // 
            this.listVFridge.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnQuantity,
            this.columnComment,
            this.columnExpirationDate});
            this.listVFridge.FullRowSelect = true;
            this.listVFridge.HideSelection = false;
            this.listVFridge.Location = new System.Drawing.Point(12, 12);
            this.listVFridge.Name = "listVFridge";
            this.listVFridge.Size = new System.Drawing.Size(367, 169);
            this.listVFridge.TabIndex = 0;
            this.listVFridge.UseCompatibleStateImageBehavior = false;
            this.listVFridge.View = System.Windows.Forms.View.Details;
            this.listVFridge.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListVFridge_ColumnClick);
            this.listVFridge.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListVFridge_ItemSelectionChanged);
            this.listVFridge.DoubleClick += new System.EventHandler(this.ListVFridge_DoubleClick);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnQuantity
            // 
            this.columnQuantity.Text = "Quantity";
            this.columnQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnComment
            // 
            this.columnComment.Text = "Comment";
            this.columnComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnComment.Width = 140;
            // 
            // columnExpirationDate
            // 
            this.columnExpirationDate.Text = "Expiration Date";
            this.columnExpirationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnExpirationDate.Width = 84;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(12, 210);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(76, 38);
            this.butAdd.TabIndex = 2;
            this.butAdd.Text = "Add food";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.ButAdd_Click);
            // 
            // butDeleteFood
            // 
            this.butDeleteFood.Enabled = false;
            this.butDeleteFood.Location = new System.Drawing.Point(391, 12);
            this.butDeleteFood.Name = "butDeleteFood";
            this.butDeleteFood.Size = new System.Drawing.Size(76, 38);
            this.butDeleteFood.TabIndex = 3;
            this.butDeleteFood.Text = "Delete food";
            this.butDeleteFood.UseVisualStyleBackColor = true;
            this.butDeleteFood.Click += new System.EventHandler(this.ButDeleteFood_Click);
            // 
            // butBarcode
            // 
            this.butBarcode.Location = new System.Drawing.Point(94, 189);
            this.butBarcode.Name = "butBarcode";
            this.butBarcode.Size = new System.Drawing.Size(91, 38);
            this.butBarcode.TabIndex = 4;
            this.butBarcode.Text = "By Barcode";
            this.butBarcode.UseVisualStyleBackColor = true;
            // 
            // butFind
            // 
            this.butFind.Location = new System.Drawing.Point(94, 233);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(91, 38);
            this.butFind.TabIndex = 5;
            this.butFind.Text = "Find food";
            this.butFind.UseVisualStyleBackColor = true;
            this.butFind.Click += new System.EventHandler(this.ButFind_Click);
            // 
            // txtFoodToFind
            // 
            this.txtFoodToFind.Location = new System.Drawing.Point(191, 221);
            this.txtFoodToFind.Name = "txtFoodToFind";
            this.txtFoodToFind.Size = new System.Drawing.Size(100, 20);
            this.txtFoodToFind.TabIndex = 6;
            this.txtFoodToFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBarcode_KeyPress);
            // 
            // datePickerExpirationDate
            // 
            this.datePickerExpirationDate.Checked = false;
            this.datePickerExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerExpirationDate.Location = new System.Drawing.Point(412, 289);
            this.datePickerExpirationDate.MaxDate = new System.DateTime(2499, 12, 31, 0, 0, 0, 0);
            this.datePickerExpirationDate.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.datePickerExpirationDate.Name = "datePickerExpirationDate";
            this.datePickerExpirationDate.ShowCheckBox = true;
            this.datePickerExpirationDate.Size = new System.Drawing.Size(113, 20);
            this.datePickerExpirationDate.TabIndex = 7;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(379, 263);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(146, 20);
            this.txtComment.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(379, 237);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(81, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(324, 240);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(324, 266);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(54, 13);
            this.lblComment.TabIndex = 11;
            this.lblComment.Text = "Comment:";
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(324, 294);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(82, 13);
            this.lblExpirationDate.TabIndex = 12;
            this.lblExpirationDate.Text = "Expiration Date:";
            // 
            // lblMeasure
            // 
            this.lblMeasure.AutoSize = true;
            this.lblMeasure.Location = new System.Drawing.Point(466, 240);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(48, 13);
            this.lblMeasure.TabIndex = 13;
            this.lblMeasure.Text = "Measure";
            // 
            // lblFoundFood
            // 
            this.lblFoundFood.AutoSize = true;
            this.lblFoundFood.Location = new System.Drawing.Point(324, 217);
            this.lblFoundFood.Name = "lblFoundFood";
            this.lblFoundFood.Size = new System.Drawing.Size(64, 13);
            this.lblFoundFood.TabIndex = 14;
            this.lblFoundFood.Text = "Found Food";
            // 
            // butChechAdd
            // 
            this.butChechAdd.Location = new System.Drawing.Point(677, 223);
            this.butChechAdd.Name = "butChechAdd";
            this.butChechAdd.Size = new System.Drawing.Size(88, 28);
            this.butChechAdd.TabIndex = 15;
            this.butChechAdd.Text = "Check && Add";
            this.butChechAdd.UseVisualStyleBackColor = true;
            this.butChechAdd.Click += new System.EventHandler(this.ButConfirm_Click);
            // 
            // comBFoundFood
            // 
            this.comBFoundFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBFoundFood.FormattingEnabled = true;
            this.comBFoundFood.Location = new System.Drawing.Point(393, 210);
            this.comBFoundFood.Name = "comBFoundFood";
            this.comBFoundFood.Size = new System.Drawing.Size(132, 21);
            this.comBFoundFood.TabIndex = 17;
            this.comBFoundFood.SelectedIndexChanged += new System.EventHandler(this.ComBFoundFood_SelectedIndexChanged);
            // 
            // listVSameFood
            // 
            this.listVSameFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listVSameFood.FullRowSelect = true;
            this.listVSameFood.HideSelection = false;
            this.listVSameFood.Location = new System.Drawing.Point(306, 341);
            this.listVSameFood.Name = "listVSameFood";
            this.listVSameFood.Size = new System.Drawing.Size(373, 97);
            this.listVSameFood.TabIndex = 18;
            this.listVSameFood.UseCompatibleStateImageBehavior = false;
            this.listVSameFood.View = System.Windows.Forms.View.Details;
            this.listVSameFood.DoubleClick += new System.EventHandler(this.ListVSameFood_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Comment";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Expiration Date";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 84;
            // 
            // butEditFood
            // 
            this.butEditFood.Enabled = false;
            this.butEditFood.Location = new System.Drawing.Point(392, 59);
            this.butEditFood.Name = "butEditFood";
            this.butEditFood.Size = new System.Drawing.Size(74, 39);
            this.butEditFood.TabIndex = 19;
            this.butEditFood.Text = "Edit Food";
            this.butEditFood.UseVisualStyleBackColor = true;
            this.butEditFood.Click += new System.EventHandler(this.ButEditFood_Click);
            // 
            // butJustAdd
            // 
            this.butJustAdd.Location = new System.Drawing.Point(677, 181);
            this.butJustAdd.Name = "butJustAdd";
            this.butJustAdd.Size = new System.Drawing.Size(88, 29);
            this.butJustAdd.TabIndex = 20;
            this.butJustAdd.Text = "Just Add";
            this.butJustAdd.UseVisualStyleBackColor = true;
            this.butJustAdd.Click += new System.EventHandler(this.ButJustAdd_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.Location = new System.Drawing.Point(392, 114);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(74, 34);
            this.butUpdate.TabIndex = 21;
            this.butUpdate.Text = "Update";
            this.butUpdate.UseVisualStyleBackColor = true;
            this.butUpdate.Click += new System.EventHandler(this.ButUpdate_Click);
            // 
            // lblNoFoodInDB
            // 
            this.lblNoFoodInDB.AutoSize = true;
            this.lblNoFoodInDB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNoFoodInDB.Location = new System.Drawing.Point(324, 189);
            this.lblNoFoodInDB.Name = "lblNoFoodInDB";
            this.lblNoFoodInDB.Size = new System.Drawing.Size(214, 13);
            this.lblNoFoodInDB.TabIndex = 22;
            this.lblNoFoodInDB.Text = "There is no food here that you want to add?";
            // 
            // Fridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNoFoodInDB);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.butJustAdd);
            this.Controls.Add(this.butEditFood);
            this.Controls.Add(this.listVSameFood);
            this.Controls.Add(this.comBFoundFood);
            this.Controls.Add(this.butChechAdd);
            this.Controls.Add(this.lblFoundFood);
            this.Controls.Add(this.lblMeasure);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.datePickerExpirationDate);
            this.Controls.Add(this.txtFoodToFind);
            this.Controls.Add(this.butFind);
            this.Controls.Add(this.butBarcode);
            this.Controls.Add(this.butDeleteFood);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.listVFridge);
            this.Name = "Fridge";
            this.Text = "Fridge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listVFridge;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnQuantity;
        private System.Windows.Forms.ColumnHeader columnExpirationDate;
        private System.Windows.Forms.ColumnHeader columnComment;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDeleteFood;
        private System.Windows.Forms.Button butBarcode;
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.TextBox txtFoodToFind;
        private System.Windows.Forms.DateTimePicker datePickerExpirationDate;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label lblMeasure;
        private System.Windows.Forms.Label lblFoundFood;
        private System.Windows.Forms.Button butChechAdd;
        private System.Windows.Forms.ComboBox comBFoundFood;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listVSameFood;
        private System.Windows.Forms.Button butEditFood;
        private System.Windows.Forms.Button butJustAdd;
        private System.Windows.Forms.Button butUpdate;
        private System.Windows.Forms.Label lblNoFoodInDB;
    }
}