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
            this.butDeleteFood = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.butConfirm = new System.Windows.Forms.Button();
            this.butTakeOut = new System.Windows.Forms.Button();
            this.butAll = new System.Windows.Forms.Button();
            this.but1o2 = new System.Windows.Forms.Button();
            this.but1o4 = new System.Windows.Forms.Button();
            this.but1o3 = new System.Windows.Forms.Button();
            this.txtNewQuantEdit = new System.Windows.Forms.TextBox();
            this.butConfNewEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listVFridge
            // 
            this.listVFridge.BackColor = System.Drawing.Color.SandyBrown;
            this.listVFridge.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnQuantity,
            this.columnComment,
            this.columnExpirationDate});
            this.listVFridge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listVFridge.FullRowSelect = true;
            this.listVFridge.HideSelection = false;
            this.listVFridge.Location = new System.Drawing.Point(12, 12);
            this.listVFridge.Name = "listVFridge";
            this.listVFridge.Size = new System.Drawing.Size(380, 449);
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
            // butDeleteFood
            // 
            this.butDeleteFood.BackColor = System.Drawing.Color.SandyBrown;
            this.butDeleteFood.Enabled = false;
            this.butDeleteFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butDeleteFood.Location = new System.Drawing.Point(508, 12);
            this.butDeleteFood.Name = "butDeleteFood";
            this.butDeleteFood.Size = new System.Drawing.Size(100, 35);
            this.butDeleteFood.TabIndex = 3;
            this.butDeleteFood.Text = "Delete";
            this.butDeleteFood.UseVisualStyleBackColor = false;
            this.butDeleteFood.Click += new System.EventHandler(this.ButDeleteFood_Click);
            // 
            // butFind
            // 
            this.butFind.BackColor = System.Drawing.Color.SandyBrown;
            this.butFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butFind.Location = new System.Drawing.Point(402, 53);
            this.butFind.Name = "butFind";
            this.butFind.Size = new System.Drawing.Size(100, 35);
            this.butFind.TabIndex = 5;
            this.butFind.Text = "Find food";
            this.butFind.UseVisualStyleBackColor = false;
            this.butFind.Click += new System.EventHandler(this.ButFind_Click);
            // 
            // txtFoodToFind
            // 
            this.txtFoodToFind.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtFoodToFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFoodToFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtFoodToFind.Location = new System.Drawing.Point(514, 60);
            this.txtFoodToFind.Name = "txtFoodToFind";
            this.txtFoodToFind.Size = new System.Drawing.Size(142, 21);
            this.txtFoodToFind.TabIndex = 6;
            this.txtFoodToFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBarcode_KeyPress);
            // 
            // datePickerExpirationDate
            // 
            this.datePickerExpirationDate.Checked = false;
            this.datePickerExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerExpirationDate.Location = new System.Drawing.Point(487, 186);
            this.datePickerExpirationDate.MaxDate = new System.DateTime(2499, 12, 31, 0, 0, 0, 0);
            this.datePickerExpirationDate.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.datePickerExpirationDate.Name = "datePickerExpirationDate";
            this.datePickerExpirationDate.ShowCheckBox = true;
            this.datePickerExpirationDate.Size = new System.Drawing.Size(113, 20);
            this.datePickerExpirationDate.TabIndex = 7;
            this.datePickerExpirationDate.Visible = false;
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Location = new System.Drawing.Point(459, 160);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(235, 20);
            this.txtComment.TabIndex = 8;
            this.txtComment.Visible = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(454, 130);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(81, 20);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.Visible = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(402, 134);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 10;
            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.Visible = false;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(402, 163);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(54, 13);
            this.lblComment.TabIndex = 11;
            this.lblComment.Text = "Comment:";
            this.lblComment.Visible = false;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(402, 192);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(82, 13);
            this.lblExpirationDate.TabIndex = 12;
            this.lblExpirationDate.Text = "Expiration Date:";
            this.lblExpirationDate.Visible = false;
            // 
            // lblMeasure
            // 
            this.lblMeasure.AutoSize = true;
            this.lblMeasure.Location = new System.Drawing.Point(541, 134);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(48, 13);
            this.lblMeasure.TabIndex = 13;
            this.lblMeasure.Text = "Measure";
            this.lblMeasure.Visible = false;
            // 
            // lblFoundFood
            // 
            this.lblFoundFood.AutoSize = true;
            this.lblFoundFood.Location = new System.Drawing.Point(402, 105);
            this.lblFoundFood.Name = "lblFoundFood";
            this.lblFoundFood.Size = new System.Drawing.Size(64, 13);
            this.lblFoundFood.TabIndex = 14;
            this.lblFoundFood.Text = "Found Food";
            this.lblFoundFood.Visible = false;
            // 
            // butChechAdd
            // 
            this.butChechAdd.BackColor = System.Drawing.Color.SandyBrown;
            this.butChechAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butChechAdd.Location = new System.Drawing.Point(497, 223);
            this.butChechAdd.Name = "butChechAdd";
            this.butChechAdd.Size = new System.Drawing.Size(90, 35);
            this.butChechAdd.TabIndex = 15;
            this.butChechAdd.Text = "Check && Add";
            this.butChechAdd.UseVisualStyleBackColor = false;
            this.butChechAdd.Visible = false;
            this.butChechAdd.Click += new System.EventHandler(this.ButConfirm_Click);
            // 
            // comBFoundFood
            // 
            this.comBFoundFood.BackColor = System.Drawing.Color.LemonChiffon;
            this.comBFoundFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBFoundFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBFoundFood.FormattingEnabled = true;
            this.comBFoundFood.Location = new System.Drawing.Point(468, 97);
            this.comBFoundFood.Name = "comBFoundFood";
            this.comBFoundFood.Size = new System.Drawing.Size(182, 21);
            this.comBFoundFood.TabIndex = 17;
            this.comBFoundFood.Visible = false;
            this.comBFoundFood.SelectedIndexChanged += new System.EventHandler(this.ComBFoundFood_SelectedIndexChanged);
            // 
            // listVSameFood
            // 
            this.listVSameFood.BackColor = System.Drawing.Color.SandyBrown;
            this.listVSameFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listVSameFood.FullRowSelect = true;
            this.listVSameFood.HideSelection = false;
            this.listVSameFood.Location = new System.Drawing.Point(402, 97);
            this.listVSameFood.Name = "listVSameFood";
            this.listVSameFood.Size = new System.Drawing.Size(363, 129);
            this.listVSameFood.TabIndex = 18;
            this.listVSameFood.UseCompatibleStateImageBehavior = false;
            this.listVSameFood.View = System.Windows.Forms.View.Details;
            this.listVSameFood.Visible = false;
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
            this.butEditFood.BackColor = System.Drawing.Color.SandyBrown;
            this.butEditFood.Enabled = false;
            this.butEditFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butEditFood.Location = new System.Drawing.Point(402, 12);
            this.butEditFood.Name = "butEditFood";
            this.butEditFood.Size = new System.Drawing.Size(100, 35);
            this.butEditFood.TabIndex = 19;
            this.butEditFood.Text = "Edit";
            this.butEditFood.UseVisualStyleBackColor = false;
            this.butEditFood.Click += new System.EventHandler(this.ButEditFood_Click);
            // 
            // butJustAdd
            // 
            this.butJustAdd.BackColor = System.Drawing.Color.SandyBrown;
            this.butJustAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butJustAdd.Location = new System.Drawing.Point(402, 223);
            this.butJustAdd.Name = "butJustAdd";
            this.butJustAdd.Size = new System.Drawing.Size(89, 35);
            this.butJustAdd.TabIndex = 20;
            this.butJustAdd.Text = "Just Add";
            this.butJustAdd.UseVisualStyleBackColor = false;
            this.butJustAdd.Visible = false;
            this.butJustAdd.Click += new System.EventHandler(this.ButJustAdd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(398, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // butConfirm
            // 
            this.butConfirm.BackColor = System.Drawing.Color.SandyBrown;
            this.butConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butConfirm.Location = new System.Drawing.Point(402, 223);
            this.butConfirm.Name = "butConfirm";
            this.butConfirm.Size = new System.Drawing.Size(90, 35);
            this.butConfirm.TabIndex = 22;
            this.butConfirm.Text = "Confirm";
            this.butConfirm.UseVisualStyleBackColor = false;
            this.butConfirm.Visible = false;
            this.butConfirm.Click += new System.EventHandler(this.ButConfirm_Click_1);
            // 
            // butTakeOut
            // 
            this.butTakeOut.BackColor = System.Drawing.Color.SandyBrown;
            this.butTakeOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butTakeOut.Location = new System.Drawing.Point(665, 53);
            this.butTakeOut.Name = "butTakeOut";
            this.butTakeOut.Size = new System.Drawing.Size(100, 35);
            this.butTakeOut.TabIndex = 23;
            this.butTakeOut.Text = "Take out food";
            this.butTakeOut.UseVisualStyleBackColor = false;
            this.butTakeOut.Click += new System.EventHandler(this.ButTakeOut_Click);
            // 
            // butAll
            // 
            this.butAll.BackColor = System.Drawing.Color.SandyBrown;
            this.butAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butAll.Location = new System.Drawing.Point(402, 229);
            this.butAll.Name = "butAll";
            this.butAll.Size = new System.Drawing.Size(51, 21);
            this.butAll.TabIndex = 24;
            this.butAll.Text = "All";
            this.butAll.UseVisualStyleBackColor = false;
            this.butAll.Visible = false;
            this.butAll.Click += new System.EventHandler(this.ButAll_Click);
            // 
            // but1o2
            // 
            this.but1o2.BackColor = System.Drawing.Color.SandyBrown;
            this.but1o2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but1o2.Location = new System.Drawing.Point(459, 230);
            this.but1o2.Name = "but1o2";
            this.but1o2.Size = new System.Drawing.Size(51, 21);
            this.but1o2.TabIndex = 25;
            this.but1o2.Text = "1/2";
            this.but1o2.UseVisualStyleBackColor = false;
            this.but1o2.Visible = false;
            this.but1o2.Click += new System.EventHandler(this.But1o2_Click);
            // 
            // but1o4
            // 
            this.but1o4.BackColor = System.Drawing.Color.SandyBrown;
            this.but1o4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but1o4.Location = new System.Drawing.Point(573, 229);
            this.but1o4.Name = "but1o4";
            this.but1o4.Size = new System.Drawing.Size(51, 21);
            this.but1o4.TabIndex = 27;
            this.but1o4.Text = "1/4";
            this.but1o4.UseVisualStyleBackColor = false;
            this.but1o4.Visible = false;
            this.but1o4.Click += new System.EventHandler(this.But1o4_Click);
            // 
            // but1o3
            // 
            this.but1o3.BackColor = System.Drawing.Color.SandyBrown;
            this.but1o3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but1o3.Location = new System.Drawing.Point(516, 229);
            this.but1o3.Name = "but1o3";
            this.but1o3.Size = new System.Drawing.Size(51, 21);
            this.but1o3.TabIndex = 26;
            this.but1o3.Text = "1/3";
            this.but1o3.UseVisualStyleBackColor = false;
            this.but1o3.Visible = false;
            this.but1o3.Click += new System.EventHandler(this.But1o3_Click);
            // 
            // txtNewQuantEdit
            // 
            this.txtNewQuantEdit.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtNewQuantEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewQuantEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNewQuantEdit.Location = new System.Drawing.Point(630, 229);
            this.txtNewQuantEdit.Name = "txtNewQuantEdit";
            this.txtNewQuantEdit.Size = new System.Drawing.Size(64, 21);
            this.txtNewQuantEdit.TabIndex = 28;
            this.txtNewQuantEdit.Visible = false;
            // 
            // butConfNewEdit
            // 
            this.butConfNewEdit.BackColor = System.Drawing.Color.SandyBrown;
            this.butConfNewEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butConfNewEdit.Location = new System.Drawing.Point(702, 229);
            this.butConfNewEdit.Name = "butConfNewEdit";
            this.butConfNewEdit.Size = new System.Drawing.Size(63, 21);
            this.butConfNewEdit.TabIndex = 29;
            this.butConfNewEdit.Text = "Confirm";
            this.butConfNewEdit.UseVisualStyleBackColor = false;
            this.butConfNewEdit.Visible = false;
            this.butConfNewEdit.Click += new System.EventHandler(this.ButConfNewEdit_Click);
            // 
            // Fridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(777, 470);
            this.Controls.Add(this.butConfNewEdit);
            this.Controls.Add(this.txtNewQuantEdit);
            this.Controls.Add(this.but1o4);
            this.Controls.Add(this.but1o3);
            this.Controls.Add(this.but1o2);
            this.Controls.Add(this.butAll);
            this.Controls.Add(this.butTakeOut);
            this.Controls.Add(this.butConfirm);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.butDeleteFood);
            this.Controls.Add(this.listVFridge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.Button butDeleteFood;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butConfirm;
        private System.Windows.Forms.Button butTakeOut;
        private System.Windows.Forms.Button butAll;
        private System.Windows.Forms.Button but1o2;
        private System.Windows.Forms.Button but1o4;
        private System.Windows.Forms.Button but1o3;
        private System.Windows.Forms.TextBox txtNewQuantEdit;
        private System.Windows.Forms.Button butConfNewEdit;
    }
}