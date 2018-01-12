namespace _10._01._2018_Hotel
{
    partial class Form1
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
            this.dgwRoomData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPhotoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomAndDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.roomAndPhotosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employerTypeAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.d = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBedCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRoomPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckbRoomReserv = new System.Windows.Forms.CheckBox();
            this.ckbRoomClear = new System.Windows.Forms.CheckBox();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.addExpencesTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRoomData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwRoomData
            // 
            this.dgwRoomData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRoomData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRoomData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgwRoomData.Location = new System.Drawing.Point(12, 183);
            this.dgwRoomData.Name = "dgwRoomData";
            this.dgwRoomData.Size = new System.Drawing.Size(1057, 253);
            this.dgwRoomData.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Room Number";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bed Count";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Rezervation";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Clearning";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsToolStripMenuItem,
            this.typesToolStripMenuItem,
            this.searchDetailsToolStripMenuItem,
            this.addTypesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDetailToolStripMenuItem,
            this.addTypeToolStripMenuItem,
            this.addPhotoToolStripMenuItem1,
            this.addUserToolStripMenuItem,
            this.addBookingToolStripMenuItem});
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.detailsToolStripMenuItem.Text = "Add Data";
            // 
            // addDetailToolStripMenuItem
            // 
            this.addDetailToolStripMenuItem.Name = "addDetailToolStripMenuItem";
            this.addDetailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addDetailToolStripMenuItem.Text = "Add Detail";
            this.addDetailToolStripMenuItem.Click += new System.EventHandler(this.addDetailToolStripMenuItem_Click);
            // 
            // addTypeToolStripMenuItem
            // 
            this.addTypeToolStripMenuItem.Name = "addTypeToolStripMenuItem";
            this.addTypeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addTypeToolStripMenuItem.Text = "Add Type";
            this.addTypeToolStripMenuItem.Click += new System.EventHandler(this.addTypeToolStripMenuItem_Click);
            // 
            // addPhotoToolStripMenuItem1
            // 
            this.addPhotoToolStripMenuItem1.Name = "addPhotoToolStripMenuItem1";
            this.addPhotoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addPhotoToolStripMenuItem1.Text = "Add Photo";
            this.addPhotoToolStripMenuItem1.Click += new System.EventHandler(this.addPhotoToolStripMenuItem1_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // addBookingToolStripMenuItem
            // 
            this.addBookingToolStripMenuItem.Name = "addBookingToolStripMenuItem";
            this.addBookingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addBookingToolStripMenuItem.Text = "Add Booking";
            this.addBookingToolStripMenuItem.Click += new System.EventHandler(this.addBookingToolStripMenuItem_Click);
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomAndDetailsToolStripMenuItem1,
            this.roomAndPhotosToolStripMenuItem1});
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.typesToolStripMenuItem.Text = "Add Connections";
            // 
            // roomAndDetailsToolStripMenuItem1
            // 
            this.roomAndDetailsToolStripMenuItem1.Name = "roomAndDetailsToolStripMenuItem1";
            this.roomAndDetailsToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.roomAndDetailsToolStripMenuItem1.Text = "Room And Details";
            this.roomAndDetailsToolStripMenuItem1.Click += new System.EventHandler(this.roomAndDetailsToolStripMenuItem1_Click);
            // 
            // roomAndPhotosToolStripMenuItem1
            // 
            this.roomAndPhotosToolStripMenuItem1.Name = "roomAndPhotosToolStripMenuItem1";
            this.roomAndPhotosToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.roomAndPhotosToolStripMenuItem1.Text = "Room And Photos";
            this.roomAndPhotosToolStripMenuItem1.Click += new System.EventHandler(this.roomAndPhotosToolStripMenuItem1_Click);
            // 
            // searchDetailsToolStripMenuItem
            // 
            this.searchDetailsToolStripMenuItem.Name = "searchDetailsToolStripMenuItem";
            this.searchDetailsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.searchDetailsToolStripMenuItem.Text = "Search Details";
            this.searchDetailsToolStripMenuItem.Click += new System.EventHandler(this.searchDetailsToolStripMenuItem_Click);
            // 
            // addTypesToolStripMenuItem
            // 
            this.addTypesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employerTypeAddToolStripMenuItem,
            this.addExpencesTypeToolStripMenuItem,
            this.addPaymentTypeToolStripMenuItem});
            this.addTypesToolStripMenuItem.Name = "addTypesToolStripMenuItem";
            this.addTypesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.addTypesToolStripMenuItem.Text = "Add Types";
            // 
            // employerTypeAddToolStripMenuItem
            // 
            this.employerTypeAddToolStripMenuItem.Name = "employerTypeAddToolStripMenuItem";
            this.employerTypeAddToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.employerTypeAddToolStripMenuItem.Text = "Add Employer Type";
            this.employerTypeAddToolStripMenuItem.Click += new System.EventHandler(this.employerTypeAddToolStripMenuItem_Click);
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(80, 78);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(81, 13);
            this.d.TabIndex = 2;
            this.d.Text = "Room Number :";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(167, 75);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRoomNumber.TabIndex = 3;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(167, 139);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(100, 21);
            this.cmbRoomType.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(874, 138);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Room Type :";
            // 
            // txtBedCount
            // 
            this.txtBedCount.Location = new System.Drawing.Point(504, 71);
            this.txtBedCount.Name = "txtBedCount";
            this.txtBedCount.Size = new System.Drawing.Size(100, 20);
            this.txtBedCount.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bed Count :";
            // 
            // txtRoomPrice
            // 
            this.txtRoomPrice.Location = new System.Drawing.Point(504, 140);
            this.txtRoomPrice.Name = "txtRoomPrice";
            this.txtRoomPrice.Size = new System.Drawing.Size(100, 20);
            this.txtRoomPrice.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Room Price :";
            // 
            // ckbRoomReserv
            // 
            this.ckbRoomReserv.AutoSize = true;
            this.ckbRoomReserv.Location = new System.Drawing.Point(696, 67);
            this.ckbRoomReserv.Name = "ckbRoomReserv";
            this.ckbRoomReserv.Size = new System.Drawing.Size(114, 17);
            this.ckbRoomReserv.TabIndex = 13;
            this.ckbRoomReserv.Text = "Room Reservation";
            this.ckbRoomReserv.UseVisualStyleBackColor = true;
            // 
            // ckbRoomClear
            // 
            this.ckbRoomClear.AutoSize = true;
            this.ckbRoomClear.Location = new System.Drawing.Point(696, 102);
            this.ckbRoomClear.Name = "ckbRoomClear";
            this.ckbRoomClear.Size = new System.Drawing.Size(98, 17);
            this.ckbRoomClear.TabIndex = 14;
            this.ckbRoomClear.Text = "Room Cleaning";
            this.ckbRoomClear.UseVisualStyleBackColor = true;
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Location = new System.Drawing.Point(696, 139);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(87, 17);
            this.ckbStatus.TabIndex = 15;
            this.ckbStatus.Text = "Room Status";
            this.ckbStatus.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(232, 163);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 16;
            // 
            // addExpencesTypeToolStripMenuItem
            // 
            this.addExpencesTypeToolStripMenuItem.Name = "addExpencesTypeToolStripMenuItem";
            this.addExpencesTypeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addExpencesTypeToolStripMenuItem.Text = "Add Expences Type";
            this.addExpencesTypeToolStripMenuItem.Click += new System.EventHandler(this.addExpencesTypeToolStripMenuItem_Click);
            // 
            // addPaymentTypeToolStripMenuItem
            // 
            this.addPaymentTypeToolStripMenuItem.Name = "addPaymentTypeToolStripMenuItem";
            this.addPaymentTypeToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.addPaymentTypeToolStripMenuItem.Text = "Add Payment Type";
            this.addPaymentTypeToolStripMenuItem.Click += new System.EventHandler(this.addPaymentTypeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 448);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.ckbStatus);
            this.Controls.Add(this.ckbRoomClear);
            this.Controls.Add(this.ckbRoomReserv);
            this.Controls.Add(this.txtRoomPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBedCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.d);
            this.Controls.Add(this.dgwRoomData);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRoomData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwRoomData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBedCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbRoomReserv;
        private System.Windows.Forms.CheckBox ckbRoomClear;
        private System.Windows.Forms.CheckBox ckbStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ToolStripMenuItem searchDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPhotoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roomAndDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem roomAndPhotosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employerTypeAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpencesTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentTypeToolStripMenuItem;
    }
}

