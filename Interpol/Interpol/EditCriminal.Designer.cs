namespace Interpol
{
    partial class EditCriminal
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
            this.EditingID = new System.Windows.Forms.NumericUpDown();
            this.CriminalEdit = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EditingID)).BeginInit();
            this.SuspendLayout();
            // 
            // EditingID
            // 
            this.EditingID.Location = new System.Drawing.Point(112, 12);
            this.EditingID.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.EditingID.Name = "EditingID";
            this.EditingID.Size = new System.Drawing.Size(146, 20);
            this.EditingID.TabIndex = 38;
            // 
            // CriminalEdit
            // 
            this.CriminalEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CriminalEdit.Font = new System.Drawing.Font("Segoe Marker", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriminalEdit.Location = new System.Drawing.Point(12, 39);
            this.CriminalEdit.Name = "CriminalEdit";
            this.CriminalEdit.Size = new System.Drawing.Size(244, 45);
            this.CriminalEdit.TabIndex = 37;
            this.CriminalEdit.Text = "Изменить!";
            this.CriminalEdit.UseVisualStyleBackColor = true;
            this.CriminalEdit.Click += new System.EventHandler(this.CriminalEdit_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe Marker", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(12, 7);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(32, 22);
            this.IDLabel.TabIndex = 36;
            this.IDLabel.Text = "ID:";
            // 
            // EditCriminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 96);
            this.Controls.Add(this.EditingID);
            this.Controls.Add(this.CriminalEdit);
            this.Controls.Add(this.IDLabel);
            this.Name = "EditCriminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCriminal";
            ((System.ComponentModel.ISupportInitialize)(this.EditingID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown EditingID;
        private System.Windows.Forms.Button CriminalEdit;
        private System.Windows.Forms.Label IDLabel;

    }
}