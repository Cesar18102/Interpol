namespace Interpol
{
    partial class RemoveCriminal
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
            this.CriminalRemove = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.RemovingID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RemovingID)).BeginInit();
            this.SuspendLayout();
            // 
            // CriminalRemove
            // 
            this.CriminalRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CriminalRemove.Font = new System.Drawing.Font("Segoe Marker", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriminalRemove.Location = new System.Drawing.Point(12, 39);
            this.CriminalRemove.Name = "CriminalRemove";
            this.CriminalRemove.Size = new System.Drawing.Size(244, 45);
            this.CriminalRemove.TabIndex = 31;
            this.CriminalRemove.Text = "Удалить!";
            this.CriminalRemove.UseVisualStyleBackColor = true;
            this.CriminalRemove.Click += new System.EventHandler(this.CriminalRemove_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Segoe Marker", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(12, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(32, 22);
            this.IDLabel.TabIndex = 29;
            this.IDLabel.Text = "ID:";
            // 
            // RemovingID
            // 
            this.RemovingID.Location = new System.Drawing.Point(110, 14);
            this.RemovingID.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.RemovingID.Name = "RemovingID";
            this.RemovingID.Size = new System.Drawing.Size(146, 20);
            this.RemovingID.TabIndex = 32;
            // 
            // RemoveCriminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 95);
            this.Controls.Add(this.RemovingID);
            this.Controls.Add(this.CriminalRemove);
            this.Controls.Add(this.IDLabel);
            this.Name = "RemoveCriminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveCriminal";
            ((System.ComponentModel.ISupportInitialize)(this.RemovingID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CriminalRemove;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.NumericUpDown RemovingID;
    }
}