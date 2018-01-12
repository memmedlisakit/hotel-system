namespace _10._01._2018_Hotel
{
    partial class ExpencesTypeForm
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
            this.txtExpencesTypeName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgwExpencesTypeData = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwExpencesTypeData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Expenses Type :";
            // 
            // txtExpencesTypeName
            // 
            this.txtExpencesTypeName.Location = new System.Drawing.Point(131, 28);
            this.txtExpencesTypeName.Name = "txtExpencesTypeName";
            this.txtExpencesTypeName.Size = new System.Drawing.Size(100, 20);
            this.txtExpencesTypeName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(86, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgwExpencesTypeData
            // 
            this.dgwExpencesTypeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwExpencesTypeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwExpencesTypeData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgwExpencesTypeData.Location = new System.Drawing.Point(254, 28);
            this.dgwExpencesTypeData.Name = "dgwExpencesTypeData";
            this.dgwExpencesTypeData.Size = new System.Drawing.Size(312, 92);
            this.dgwExpencesTypeData.TabIndex = 3;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(21, 69);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Expenses Type Name";
            this.Column1.Name = "Column1";
            // 
            // ExpencesTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 148);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgwExpencesTypeData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtExpencesTypeName);
            this.Controls.Add(this.label1);
            this.Name = "ExpencesTypeForm";
            this.Text = "ExpencesTypeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwExpencesTypeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpencesTypeName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgwExpencesTypeData;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}