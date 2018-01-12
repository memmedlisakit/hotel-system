namespace _10._01._2018_Hotel
{
    partial class PhotoForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnUload = new System.Windows.Forms.Button();
            this.pctRoom = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnUload
            // 
            this.btnUload.Location = new System.Drawing.Point(12, 301);
            this.btnUload.Name = "btnUload";
            this.btnUload.Size = new System.Drawing.Size(160, 23);
            this.btnUload.TabIndex = 2;
            this.btnUload.Text = "Upload";
            this.btnUload.UseVisualStyleBackColor = true;
            this.btnUload.Click += new System.EventHandler(this.btnUload_Click);
            // 
            // pctRoom
            // 
            this.pctRoom.Location = new System.Drawing.Point(12, 12);
            this.pctRoom.Name = "pctRoom";
            this.pctRoom.Size = new System.Drawing.Size(387, 271);
            this.pctRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRoom.TabIndex = 3;
            this.pctRoom.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(239, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 330);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pctRoom);
            this.Controls.Add(this.btnUload);
            this.Name = "PhotoForm";
            this.Text = "PhotoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pctRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnUload;
        private System.Windows.Forms.PictureBox pctRoom;
        private System.Windows.Forms.Button btnSave;
    }
}