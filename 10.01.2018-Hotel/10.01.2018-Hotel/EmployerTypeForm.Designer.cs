namespace _10._01._2018_Hotel
{
    partial class EmployerTypeForm
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
            this.txtEmloyerTypeName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgwEmployerTypeData = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployerTypeData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employer Type :";
            // 
            // txtEmloyerTypeName
            // 
            this.txtEmloyerTypeName.Location = new System.Drawing.Point(125, 30);
            this.txtEmloyerTypeName.Name = "txtEmloyerTypeName";
            this.txtEmloyerTypeName.Size = new System.Drawing.Size(100, 20);
            this.txtEmloyerTypeName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(73, 103);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgwEmployerTypeData
            // 
            this.dgwEmployerTypeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwEmployerTypeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEmployerTypeData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgwEmployerTypeData.Location = new System.Drawing.Point(246, 30);
            this.dgwEmployerTypeData.Name = "dgwEmployerTypeData";
            this.dgwEmployerTypeData.Size = new System.Drawing.Size(289, 104);
            this.dgwEmployerTypeData.TabIndex = 3;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 72);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 17);
            this.lblError.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employer Type Name";
            this.Column1.Name = "Column1";
            // 
            // EmployerTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 180);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgwEmployerTypeData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmloyerTypeName);
            this.Controls.Add(this.label1);
            this.Name = "EmployerTypeForm";
            this.Text = "EmployerTypeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwEmployerTypeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmloyerTypeName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgwEmployerTypeData;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}