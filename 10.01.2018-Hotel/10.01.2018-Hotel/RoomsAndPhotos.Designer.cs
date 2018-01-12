namespace _10._01._2018_Hotel
{
    partial class RoomsAndPhotos
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
            this.flwpRoomPhoto = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRoomNumber = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgwRoomAndPhotos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwRoomAndPhotos)).BeginInit();
            this.SuspendLayout();
            // 
            // flwpRoomPhoto
            // 
            this.flwpRoomPhoto.AutoScroll = true;
            this.flwpRoomPhoto.Location = new System.Drawing.Point(307, 28);
            this.flwpRoomPhoto.Name = "flwpRoomPhoto";
            this.flwpRoomPhoto.Size = new System.Drawing.Size(200, 200);
            this.flwpRoomPhoto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Number :";
            // 
            // cmbRoomNumber
            // 
            this.cmbRoomNumber.FormattingEnabled = true;
            this.cmbRoomNumber.Location = new System.Drawing.Point(119, 28);
            this.cmbRoomNumber.Name = "cmbRoomNumber";
            this.cmbRoomNumber.Size = new System.Drawing.Size(121, 21);
            this.cmbRoomNumber.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 200);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgwRoomAndPhotos
            // 
            this.dgwRoomAndPhotos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwRoomAndPhotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwRoomAndPhotos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgwRoomAndPhotos.Location = new System.Drawing.Point(15, 73);
            this.dgwRoomAndPhotos.Name = "dgwRoomAndPhotos";
            this.dgwRoomAndPhotos.Size = new System.Drawing.Size(286, 108);
            this.dgwRoomAndPhotos.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Room Number";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Photo id";
            this.Column2.Name = "Column2";
            // 
            // RoomsAndPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 257);
            this.Controls.Add(this.dgwRoomAndPhotos);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbRoomNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flwpRoomPhoto);
            this.Name = "RoomsAndPhotos";
            this.Text = "RoomsAndPhotos";
            ((System.ComponentModel.ISupportInitialize)(this.dgwRoomAndPhotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwpRoomPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRoomNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgwRoomAndPhotos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}