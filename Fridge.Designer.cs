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
            this.butTest = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butRemoveFood = new System.Windows.Forms.Button();
            this.butBarcode = new System.Windows.Forms.Button();
            this.butFind = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.datePickerExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
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
            // butTest
            // 
            this.butTest.Location = new System.Drawing.Point(12, 344);
            this.butTest.Name = "butTest";
            this.butTest.Size = new System.Drawing.Size(129, 94);
            this.butTest.TabIndex = 1;
            this.butTest.Text = "Test";
            this.butTest.UseVisualStyleBackColor = true;
            this.butTest.Click += new System.EventHandler(this.ButTest_Click);
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
            // butRemoveFood
            // 
            this.butRemoveFood.Location = new System.Drawing.Point(475, 21);
            this.butRemoveFood.Name = "butRemoveFood";
            this.butRemoveFood.Size = new System.Drawing.Size(76, 38);
            this.butRemoveFood.TabIndex = 3;
            this.butRemoveFood.Text = "Remove food";
            this.butRemoveFood.UseVisualStyleBackColor = true;
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
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(191, 199);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(107, 20);
            this.txtBarcode.TabIndex = 6;
            // 
            // datePickerExpirationDate
            // 
            this.datePickerExpirationDate.Location = new System.Drawing.Point(313, 199);
            this.datePickerExpirationDate.Name = "datePickerExpirationDate";
            this.datePickerExpirationDate.Size = new System.Drawing.Size(212, 20);
            this.datePickerExpirationDate.TabIndex = 7;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(541, 201);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(111, 20);
            this.txtComment.TabIndex = 8;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(669, 201);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(106, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // Fridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.datePickerExpirationDate);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.butFind);
            this.Controls.Add(this.butBarcode);
            this.Controls.Add(this.butRemoveFood);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butTest);
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
        private System.Windows.Forms.Button butTest;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butRemoveFood;
        private System.Windows.Forms.Button butBarcode;
        private System.Windows.Forms.Button butFind;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.DateTimePicker datePickerExpirationDate;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}