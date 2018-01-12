namespace _10._01._2018_Hotel
{
    partial class DetailsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetailName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Detail Name :";
            // 
            // txtDetailName
            // 
            this.txtDetailName.Location = new System.Drawing.Point(175, 54);
            this.txtDetailName.Name = "txtDetailName";
            this.txtDetailName.Size = new System.Drawing.Size(172, 20);
            this.txtDetailName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(53, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgwData
            // 
            this.dgwData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detail});
            this.dgwData.Location = new System.Drawing.Point(427, 44);
            this.dgwData.Name = "dgwData";
            this.dgwData.Size = new System.Drawing.Size(240, 150);
            this.dgwData.TabIndex = 3;
            // 
            // detail
            // 
            this.detail.HeaderText = "Detail name";
            this.detail.Name = "detail";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 235);
            this.Controls.Add(this.dgwData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDetailName);
            this.Controls.Add(this.label1);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetailName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
    }
}