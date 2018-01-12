namespace _10._01._2018_Hotel
{
    partial class RoomsAndDetailsForm
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
            this.label = new System.Windows.Forms.Label();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbRoomDetail = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 43);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 13);
            this.label.TabIndex = 0;
            this.label.Text = "Room Number :";
            // 
            // cmbRoomNumber
            // 
            this.cmbRoomNumber.FormattingEnabled = true;
            this.cmbRoomNumber.Location = new System.Drawing.Point(121, 40);
            this.cmbRoomNumber.Name = "cmbRoomNumber";
            this.cmbRoomNumber.Size = new System.Drawing.Size(121, 21);
            this.cmbRoomNumber.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(121, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbRoomDetail
            // 
            this.cmbRoomDetail.FormattingEnabled = true;
            this.cmbRoomDetail.Location = new System.Drawing.Point(121, 104);
            this.cmbRoomDetail.Name = "cmbRoomDetail";
            this.cmbRoomDetail.Size = new System.Drawing.Size(121, 21);
            this.cmbRoomDetail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room Details :";
            // 
            // dgwData
            // 
            this.dgwData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgwData.Location = new System.Drawing.Point(301, 35);
            this.dgwData.Name = "dgwData";
            this.dgwData.Size = new System.Drawing.Size(307, 132);
            this.dgwData.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Room Number";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Room Details";
            this.Column2.Name = "Column2";
            // 
            // RoomsAndDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 195);
            this.Controls.Add(this.dgwData);
            this.Controls.Add(this.cmbRoomDetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbRoomNumber);
            this.Controls.Add(this.label);
            this.Name = "RoomsAndDetailsForm";
            this.Text = "RoomsAndDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbRoomDetail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}