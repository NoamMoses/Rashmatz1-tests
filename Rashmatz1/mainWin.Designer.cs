namespace Rashmatz1 {
    partial class mainWin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.mainTitle = new System.Windows.Forms.Label();
            this.mainList = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMakat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMakatFactory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSign = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelDebug = new System.Windows.Forms.Label();
            this.debugButton = new System.Windows.Forms.Button();
            this.newItem = new System.Windows.Forms.Button();
            this.infoInstruction = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainTitle
            // 
            this.mainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(0, 0);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.mainTitle.Size = new System.Drawing.Size(1157, 50);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "רשמ\"צ1";
            this.mainTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainList
            // 
            this.mainList.AllowColumnReorder = true;
            this.mainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnDesc,
            this.columnCount,
            this.columnMakat,
            this.columnMakatFactory,
            this.columnLocation,
            this.columnComments,
            this.columnSign});
            this.mainList.FullRowSelect = true;
            this.mainList.HideSelection = false;
            this.mainList.Location = new System.Drawing.Point(6, 112);
            this.mainList.MultiSelect = false;
            this.mainList.Name = "mainList";
            this.mainList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mainList.RightToLeftLayout = true;
            this.mainList.Size = new System.Drawing.Size(1139, 631);
            this.mainList.TabIndex = 1;
            this.mainList.UseCompatibleStateImageBehavior = false;
            this.mainList.View = System.Windows.Forms.View.Details;
            this.mainList.SelectedIndexChanged += new System.EventHandler(this.mainList_SelectedIndexChanged);
            this.mainList.DoubleClick += new System.EventHandler(this.mainList_DoubleClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 113;
            // 
            // columnName
            // 
            this.columnName.Text = "שם";
            this.columnName.Width = 117;
            // 
            // columnDesc
            // 
            this.columnDesc.Text = "תיאור";
            this.columnDesc.Width = 276;
            // 
            // columnCount
            // 
            this.columnCount.Text = "מלאי";
            // 
            // columnMakat
            // 
            this.columnMakat.Text = "מק\"ט";
            this.columnMakat.Width = 50;
            // 
            // columnMakatFactory
            // 
            this.columnMakatFactory.Text = "מק\"ט יצרן";
            this.columnMakatFactory.Width = 109;
            // 
            // columnLocation
            // 
            this.columnLocation.Text = "מיקום";
            this.columnLocation.Width = 109;
            // 
            // columnComments
            // 
            this.columnComments.Text = "הערות";
            this.columnComments.Width = 180;
            // 
            // columnSign
            // 
            this.columnSign.Text = "מי חתום";
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelDebug.Location = new System.Drawing.Point(43, 45);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(59, 13);
            this.labelDebug.TabIndex = 2;
            this.labelDebug.Text = "Debugging";
            // 
            // debugButton
            // 
            this.debugButton.Location = new System.Drawing.Point(135, 45);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(104, 23);
            this.debugButton.TabIndex = 3;
            this.debugButton.Text = "Debugging button";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // newItem
            // 
            this.newItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.newItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItem.ForeColor = System.Drawing.Color.White;
            this.newItem.Location = new System.Drawing.Point(282, 12);
            this.newItem.Name = "newItem";
            this.newItem.Size = new System.Drawing.Size(150, 80);
            this.newItem.TabIndex = 10;
            this.newItem.Text = "פריט חדש";
            this.newItem.UseVisualStyleBackColor = false;
            // 
            // infoInstruction
            // 
            this.infoInstruction.AutoSize = true;
            this.infoInstruction.Location = new System.Drawing.Point(855, 96);
            this.infoInstruction.Name = "infoInstruction";
            this.infoInstruction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.infoInstruction.Size = new System.Drawing.Size(290, 13);
            this.infoInstruction.TabIndex = 11;
            this.infoInstruction.Text = "* לחץ לחיצה כפולה על פריט על מנת לפתוח חלון עריכה";
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit.Location = new System.Drawing.Point(12, 751);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(55, 17);
            this.credit.TabIndex = 12;
            this.credit.Text = "*credits*";
            // 
            // mainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 773);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.infoInstruction);
            this.Controls.Add(this.newItem);
            this.Controls.Add(this.debugButton);
            this.Controls.Add(this.labelDebug);
            this.Controls.Add(this.mainList);
            this.Controls.Add(this.mainTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainWin";
            this.RightToLeftLayout = true;
            this.Text = "רשמ\"צ1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.ListView mainList;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnDesc;
        private System.Windows.Forms.ColumnHeader columnMakat;
        private System.Windows.Forms.ColumnHeader columnCount;
        private System.Windows.Forms.ColumnHeader columnComments;
        private System.Windows.Forms.ColumnHeader columnLocation;
        private System.Windows.Forms.ColumnHeader columnSign;
        private System.Windows.Forms.ColumnHeader columnMakatFactory;
        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.Button newItem;
        private System.Windows.Forms.Label infoInstruction;
        private System.Windows.Forms.Label credit;
    }
}

